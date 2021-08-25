import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
const { FileSelector, Filesystem } = Plugins;
//import 'capacitor-file-selector';
import { ApiService } from 'src/app/services/api.service';
import { LoadingController, Platform } from '@ionic/angular';
import { File } from '@ionic-native/file/ngx';
import { FileOpener } from '@ionic-native/file-opener/ngx';
import { MessageService } from 'src/app/services/message.service';
import { AppInfoService } from 'src/app/services/app-info.service';
import { AndroidPermissions } from '@ionic-native/android-permissions/ngx';
import { Plugins, FilesystemDirectory, FilesystemEncoding } from '@capacitor/core';
import { MimeTypesHelper } from 'src/app/components/filefield/mime-type-helper';

const mimeTypesHelper = new MimeTypesHelper();

@Component({
  selector: 'barsup-filefield',
  templateUrl: './filefield.component.html',
  styleUrls: ['./filefield.component.scss'],
})
export class FilefieldComponent implements OnInit {

  constructor(private apiService: ApiService,
              private platform: Platform,
              private file: File,
              private messageService: MessageService,
              private loadingController: LoadingController,
              private appInfoService: AppInfoService,
              private androidPermissions: AndroidPermissions,
              private fileOpener: FileOpener) {
  }

  ngOnInit(): void {
    FileSelector.addListener("onFilesSelected", (data: FileList) => {
      for (var i = 0; i < data.length; i++) {
        this.setFileData(data.item(i));
      }
    });
  }

  @Input()
  valueModel: any;

  @Input()
  label: string;

  @Input()
  displayField: string;

  @Input()
  multipleSelection: boolean = false;

  @Input()
  extensions: string[] = [];

  @Output()
  valueModelChange = new EventEmitter<any>();

  private fileData: Blob;

  private setFileData(fileData) {
    const fileInfo = this.valueModel || {};
    fileInfo.fileData = fileData;
    fileInfo.Name = fileInfo.fileData.name;
    this.valueModelChange.emit(fileInfo);
  }

  clear() {
    this.valueModelChange.emit(null);
  }

  private async openSelectorAsync(ev) {
    if (ev && ev.target.nodeName === 'ION-ICON') {
      return;
    }

    let selectedFile = await FileSelector.fileSelector({
      multiple_selection: this.multipleSelection,
      ext: this.extensions
    });

    if (this.platform.is("android")) {
      let paths = JSON.parse(selectedFile.paths)
      let original_names = JSON.parse(selectedFile.original_names)
      let extensions = JSON.parse(selectedFile.extensions)
      for (let index = 0; index < paths.length; index++) {
        const blob = await fetch(paths[index]).then((r) => r.blob());
        const file = this.blobToFile(blob, original_names + extensions[index]);
        this.setFileData(file);
      }
    }
    else if (this.platform.is("ios")) {
      for (let index = 0; index < selectedFile.paths.length; index++) {
        const blob = await fetch(selectedFile.paths[index]).then((r) => r.blob());
        const file = this.blobToFile(blob, selectedFile.original_names[index] + selectedFile.extensions[index]);
        this.setFileData(file);
      }
    }
  }

  private blobToFile(theBlob: Blob, fileName: string): File {
    var b: any = theBlob;
    b.lastModifiedDate = new Date();
    b.name = fileName;

    return <File><any>theBlob;
  }

  private async checkPermission(permission) {
    let checkResult = await this.androidPermissions.checkPermission(permission);
    if (!checkResult.hasPermission) {
      await this.androidPermissions.requestPermission(permission);
    }
  }

  private async downloadAsync() {
    const loading = await this.loadingController.create({
      message: 'Загрузка...'
    });
    await loading.present();

    try {
      await this.checkPermission(this.androidPermissions.PERMISSION.WRITE_EXTERNAL_STORAGE);
      await this.checkPermission(this.androidPermissions.PERMISSION.WRITE_EXTERNAL_STORAGE);

      const fileResponse = await this.apiService.getAsync(`MobileFile/Download?id=${this.valueModel.Id}`, {
        isBlob: true
      });

      const dir = await this.file.createDir(this.file.externalRootDirectory, 'Download', true);

      const fileEntry = await this.file.writeFile(dir.toURL(), this.valueModel.FullName, fileResponse, {
        replace: true
      });

      loading.dismiss();

      await this.messageService.confirm('Выполнено', 'Файл успешно сохранен в папку "Загрузки". Открыть его сейчас?');

      const nameParts = this.valueModel.FullName.split('.'),
          extension = nameParts[nameParts.length - 1];
      const contentType = mimeTypesHelper.getMimeTypefromString(extension);

      await this.fileOpener.open(fileEntry.nativeURL, contentType)
    }
    catch (e) {
      loading.dismiss();
      console.error(e);
      this.messageService.toast('При скачивании файла произошла ошибка');
    }
  }
}