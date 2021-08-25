import { Injectable } from '@angular/core';
import { UserInfo } from 'src/app/models/UserInfo';
import { EventBusService } from './event-bus.service';
import { HttpWrapperService } from './http-wrapper.service';
import { MessageService } from './message.service';
import { ApiService } from './api.service';
import { AppInfoService } from './app-info.service';

@Injectable({
  providedIn: 'root'
})
/**
 * Сервис авторизации
 */
export class AuthService {

  constructor(private eventBus: EventBusService,
    private apiService: ApiService,
    private messageService: MessageService,
    private appInfoService: AppInfoService) {
  }

  /**
   * Выполнить попытку авторизации
   * @param login логин
   * @param password пароль
   */
  public async authorizeAsync(login, password): Promise<boolean> {
    try {
      const response = await this.apiService.postAsync('mobilesecurity/token', {
        login: login,
        password: password
      });

      if (!response.success) {
        this.messageService.toast(response.message);
        return;
      }

      const userInfo = new UserInfo(response.userId, response.userName, response.token);
      await this.appInfoService.setCurrentUserAsync(userInfo);

      return true;
    }
    catch (e) {
      if (e.status === 404) {
        this.messageService.toast('Сервер не найден.');        
      } else {
        console.error(e);
        this.messageService.toast('При авторизации произошла ошибка');
      }
      
      return false;
    }
  }  
}
