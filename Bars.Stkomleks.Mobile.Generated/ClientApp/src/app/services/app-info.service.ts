import { Injectable } from '@angular/core';
import { UserInfo } from 'src/app/models/UserInfo';
import { Plugins } from '@capacitor/core';
const { Storage } = Plugins;


@Injectable({
  providedIn: 'root'
})
/**
 * Сервис с информацией о приложении
 */
export class AppInfoService {

  constructor() { }

  private currentUser: UserInfo;

  /**
   * Установить текущего пользователя
   * @param userInfo 
   */
  public async setCurrentUserAsync(userInfo: UserInfo) {
    await Storage.set({
      key: 'CurrentUser',
      value: userInfo 
        ? JSON.stringify(userInfo)
        : null
    });
    this.currentUser = userInfo;
  }

  /**
   * Получить текущего пользователя
   */
  public async getCurrentUserAsync(): Promise<UserInfo> {
    if (!this.currentUser) {
      const savedUserInfo = await Storage.get({ key: 'CurrentUser' });
      if (savedUserInfo.value) {
        this.currentUser = JSON.parse(savedUserInfo.value);
      }
    }

    return this.currentUser;
  }

  /**
   * Отображаемое наименование приложения
   */
  getAppDisplay() {
    return 'IT4SM.Стройкомплекс';
  }

  /**
   * Получить адрес WebApi
   */
  getWebApiEndpoint() {
    return '';
  }  
}
