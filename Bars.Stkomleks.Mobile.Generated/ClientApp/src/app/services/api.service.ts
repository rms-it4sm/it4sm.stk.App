import { Injectable } from '@angular/core';
import { AuthService } from './auth.service';
import { AppInfoService } from './app-info.service';
import { HttpWrapperService } from './http-wrapper.service';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private httpWrapper: HttpWrapperService,
              private appInfoService: AppInfoService,
              private router: Router) { }

  /**
   * Отправить get запрос к WebApi
   * @param url
   * @param headers
   */
  async getAsync(url: string, headers?): Promise<any> {
    try {
      if (!headers) {
        headers = {};
      }

      const webApiEndpoint = this.appInfoService.getWebApiEndpoint();
      await this.setAuthorizationHeaderAsync(headers);
      return await this.httpWrapper.get(webApiEndpoint + '/' + url, headers);
    }
    catch (e) {
      if (e.status === 403) {
        await this.appInfoService.setCurrentUserAsync(null);
      }

      throw e;
    }
  }

  /**
   * Отправить post запрос к WebApi
   * @param url
   * @param headers
   */
  async postAsync(url: string, body: any, headers?): Promise<any> {
    try {
      if (!headers) {
        headers = {};
      }


      const clientTimezoneParams = {
        ClientTimeZoneOffset: new Date().getTimezoneOffset() / 60
      };

      if (body instanceof FormData) {
        body.append('clientTimezoneParams', JSON.stringify(clientTimezoneParams));
      }
      else {
        body.clientTimezoneParams = clientTimezoneParams;
      }

      const webApiEndpoint = this.appInfoService.getWebApiEndpoint();
      await this.setAuthorizationHeaderAsync(headers);
      return await this.httpWrapper.post(webApiEndpoint + '/' + url, body, headers);
    }
    catch (e) {
      if (e.status === 403) {
        await this.appInfoService.setCurrentUserAsync(null);
      }

      throw e;
    }
  }

  public async setAuthorizationHeaderAsync(headers) {
    const currentUserInfo = await this.appInfoService.getCurrentUserAsync();

    if (currentUserInfo && currentUserInfo.token) {
      headers['Authorization'] = `Bearer ${currentUserInfo.token}`;
    }
  }
}
