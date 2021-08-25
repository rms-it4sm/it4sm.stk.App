import { Component, OnInit, Input, Output, EventEmitter, AfterViewInit, ViewChildren, QueryList, ContentChildren, ViewChild, ContentChild } from '@angular/core';
import { ApiService } from 'src/app/services/api.service';
import { Router, ActivatedRoute } from '@angular/router';
import { MessageService } from 'src/app/services/message.service';
import { LoadingController, PopoverController, NavController } from '@ionic/angular';
import { EventBusService } from 'src/app/services/event-bus.service';
import { PopoverAction } from 'src/app/models/PopoverAction';
import { FilefieldComponent } from '../filefield/filefield.component';

/**
 * Редактор
 */
@Component({
  selector: 'barsup-editor',
  templateUrl: './editor.component.html',
  styleUrls: ['./editor.component.scss'],
})
export class EditorComponent implements AfterViewInit {

  constructor(private route: ActivatedRoute,
              private messageService: MessageService,
              private apiService: ApiService,
              private loadingController: LoadingController,
              private popoverController: PopoverController,
              private navController: NavController,
              private eventBus: EventBusService,
              private router: Router) { }

  ngAfterViewInit() {
    this.recordId = Number.parseInt(this.route.snapshot.paramMap.get('id'));
    this.redirectRoute = this.route.snapshot.paramMap.get('redirect');
    this.loadDataAsync();
  }

  /**
   * Идентификатор записи
   */
  private recordId: number;

  /**
   * Роут, на который нужно редиректить после создания записи
   */
  private redirectRoute: string;

  /**
   * Заголовок формы
   */
  @Input()
  title: string;

  /**
   * Наименование WebApi контроллера редактора
   */
  @Input()
  apiEditorControllerName: string;

  /**
   * Наименование WebApi контроллера списка
   */
  @Input()
  apiListControllerName: string

  /**
   * Дополнительные действия всплывающего окна
   */
  @Input()
  popoverActions: Array<PopoverAction> = [];

  /**
   * Данные формы
   */
  @Input()
  data: object;

  @Output()
  dataChange = new EventEmitter<Object>();

  /**
   * Событие клика на действие из поповера
   */
  @Output()
  onPopoverActionClick = new EventEmitter<Object>();

  /**
   * Событие загрузки данных
   */
  @Output()
  onDataLoaded = new EventEmitter<Object>();

  /**
   * Выбор действия из поповера
   * @param action
   */
  popoverActionClick(action: string) {
    switch (action) {
      case 'delete': {
        this.deleteAsync();
        return;
      }
      default: {
        this.onPopoverActionClick.emit(action);
      }
    }
  }

  /**
   * Загрузить данные
   */
  protected async loadDataAsync() {
    const loading = await this.loadingController.create({
      message: 'Загрузка...'
    });
    await loading.present();

    try {
      if (this.recordId > 0) {
        const response = await this.apiService.getAsync(`${this.apiEditorControllerName}/get?id=${this.recordId}`);
        this.dataChange.emit(response.data);
        this.onDataLoaded.emit(response.data);
      }
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
      loading.dismiss();
    }
  }

  /**
   * Сохранить данные
   */
  protected async saveAsync() {
    await this.executeApiAction('Выполняется сохранение...', async () => {
      const isNewRecord = this.recordId < 0,
          formData = new FormData();

      formData.append('modelData', JSON.stringify(this.data));

      // Добавляем файлы
      for (let key of Object.keys(this.data)) {
        let dataProp = this.data[key];
        if (dataProp.fileData) {
          formData.append(key, dataProp.fileData, dataProp.fileData.name);
        }
      }

      const response = await this.apiService.postAsync(`${this.apiEditorControllerName}/update`, formData);

      this.messageService.toast('Данные успешно сохранены');

      this.recordId = response.data.Id;

      if (isNewRecord) {
        this.eventBus.sendMessage('refresh' + this.apiListControllerName);
      }

      if (this.redirectRoute !== 'null') {
        this.router.navigateByUrl(`/${this.redirectRoute}/${this.recordId}/`, { replaceUrl: true });
      }
      else {
        this.loadDataAsync();
      }
    });
  }

  /**
   * Отобразить поповер с меню
   * @param ev
   */
  async showPopoverAsync(ev) {
    const popover = await this.popoverController.create({
      component: EditorPopoverComponent,
      componentProps: {
        buttons: [
          {
            action: 'delete',
            display: 'Удалить запись'
          },
          ...this.popoverActions
        ],
        actionClick: action => {
          this.popoverActionClick.call(this, action);
        }
      },
      event: ev,
      translucent: true
    });
    return popover.present();
  }

  /**
   * Удалить запись
   */
  async deleteAsync() {
    if (this.recordId < 0) {
      this.messageService.toast('Запись ещё не создана');
      return;
    }

    await this.messageService.confirm('Удаление', 'Удалить текущую запись?');

    await this.executeApiAction('Выполняется удаление...', async () => {
      const response = await this.apiService.postAsync(`${this.apiListControllerName}/delete`, {
        records: [
          this.recordId
        ]
      });

      this.messageService.toast('Запись успешно удалена');
      this.navController.pop();
      this.eventBus.sendMessage('refresh' + this.apiListControllerName, {
        clearData: true
      });
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

/**
 * Компонент всплывающего меню
 */
@Component({
  selector: 'editor-popover',
  template:
        `<ion-list>
    <ion-item *ngFor="let item of buttons" button (click)="onClick(item.action)">{{item.display}}</ion-item>
  </ion-list>`
})
export class EditorPopoverComponent {
  constructor(private popoverController: PopoverController) { }

  @Input()
  private actionClick: Function;

  @Input()
  private buttons: Array<PopoverAction> = [];

  onClick(action) {
    this.actionClick(action);
    this.popoverController.dismiss();
  }
}