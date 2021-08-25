import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { MessageService } from 'src/app/services/message.service';
import { ApiService } from 'src/app/services/api.service';
import { Router } from '@angular/router';
import { EventBusService } from 'src/app/services/event-bus.service';
import { LoadingController } from '@ionic/angular';

@Component({
  selector: 'barsup-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss'],
})
export class ListComponent implements OnInit {

  constructor(private messageService: MessageService,
              private apiService: ApiService,
              private eventBus: EventBusService,
              private router: Router,
              private loadingController: LoadingController) { }

  private pageSize = 25;
  private searchValue: string = '';
  private dataLoaded: boolean = false;

  /**
   * Заголовок
   */
  @Input()
  title: string;

  /**
   * Наименование WebApi контроллера
   */
  @Input()
  apiControllerName: string;

  /**
   * Роут формы редактирования
   */
  @Input()
  editorRoute: string;

  /**
   * Роут формы создания
   */
  @Input()
  creatorRoute: string;

  /**
   * Поле, по которому проводится поиск
   */
  @Input()
  searchField: string;

  @Input()
  data: Array<any>;

  @Output()
  dataChange = new EventEmitter<Object>();

  ngOnInit(): void {
    this.eventBus.subscribe('refresh' + this.apiControllerName, opt => {
      this.loadDataAsync.call(this, null, opt.clearData);
    });
    this.loadDataAsync();
  }

  private async search() {
    this.loadDataAsync(null, true, true);
  }

  private getDataFilter() {
    if (this.searchValue) {
      return {
        "Group": 2,
        "Filters": [
          {
            "Operand": 6,
            "Value": this.searchValue,
            "DataIndex": this.searchField
          }]
      };
    }

    return null;
  }

  /**
   * Загрузить данные списка
   */
  protected async loadDataAsync(event?, clearLoadedData?: boolean, forceLoading?: boolean): Promise<any> {
    let loading;

    if (!this.data.length || forceLoading) {
      loading = await this.loadingController.create({
        message: 'Загрузка...'
      });
      await loading.present();
    }

    try {
      const response = await this.apiService.postAsync(`${this.apiControllerName}/list`, {
        limit: this.pageSize,
        start: clearLoadedData ? 0 : this.data.length,
        sort: [{ property: "Id", direction: "ASC" }],
        dataFilter: this.getDataFilter()
      });

      const data = clearLoadedData
          ? response.data
          : [...this.data, ...response.data];

      this.dataChange.emit(data);
      this.dataLoaded = true;
    }
    catch (e) {
      switch(e.status) {
        case 403: {
          this.router.navigateByUrl('/');
          this.messageService.toast('Требуется авторизация');
          this.eventBus.sendMessage('unauthorized');
          break;
        }
        case 404: {
          this.messageService.toast('Не найден api-контроллер. Скорее всего, нужно обновить основное веб-приложение.');
          break;
        }
        default: {
          console.error(e);
          this.messageService.toast('При загрузке данных произошла ошибка');
        }
      }
    }
    finally {
      event && event.target.complete();
      loading && loading.dismiss();
    }
  }

  /**
   * Открыть запись на редактирование
   * @param record
   */
  protected async edit(record: any): Promise<any> {
    if (!this.editorRoute) {
      throw new Error('Не указан роут для редактора');
    }

    this.router.navigateByUrl(`/${this.editorRoute}/${record.Id}/null`);
  }

  /**
   * Открыть добавление записи
   * @param record
   */
  protected async add(): Promise<any> {
    if (!this.editorRoute) {
      throw new Error('Не указан роут для редактора');
    }

    if (this.creatorRoute) {
      this.router.navigateByUrl(`/${this.creatorRoute}/-1/${this.editorRoute}`);
    }
    else {
      this.router.navigateByUrl(`/${this.editorRoute}/-1/null`);
    }
  }

  /**
   * Удалить запись
   */
  async delete(record) {
    await this.messageService.confirm('Удаление', 'Удалить выбранную запись?');

    await this.executeApiAction('Выполняется удаление...', async () => {
      const response = await this.apiService.postAsync(`${this.apiControllerName}/delete`, {
        records: [
          record.Id
        ]
      });

      this.messageService.toast('Запись успешно удалена');
      const recordIndex = this.data.indexOf(record);
      const res = this.data.splice(recordIndex, 1);
    });
  }

  /**
   * Выполнить действие на API
   * @param loadingMessage
   * @param action
   */
  async executeApiAction(loadingMessage: string, action: Function) {
    const loading = await this.loadingController.create({
      message: loadingMessage
    });
    await loading.present();

    try {
      await action();
    }
    catch (e) {
      if (e.status === 403) {
        this.router.navigateByUrl('/');
        this.messageService.toast('Требуется авторизация');
        this.eventBus.sendMessage('unauthorized');
      } else {
        console.error(e);
        this.messageService.toast('При выполнении произошла ошибка');
      }
    }
    finally {
      await loading.dismiss();
    }
  }
}
