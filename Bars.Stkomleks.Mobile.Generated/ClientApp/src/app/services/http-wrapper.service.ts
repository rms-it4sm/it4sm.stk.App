import {Injectable} from '@angular/core';
import {AppInfoService} from './app-info.service';
import {HttpClient} from "@angular/common/http";
import {AuthService} from './auth.service';

@Injectable({
    providedIn: 'root'
})
/**
 * Сервис-обертка для работы с http
 */
export class HttpWrapperService {

    constructor(private angularHttp: HttpClient,
                private appInfoService: AppInfoService) {
    }

    get(url, headers): Promise<any> {
        return new Promise<any>((resolve, reject) => {
            try {
                headers = headers || {};
                if (!headers['Accept']) {
                    headers['Accept'] = 'application/json';
                }
                if (!headers['Content-Type']) {
                    headers['Content-Type'] = 'application/json';
                }

                const options = {
                    headers: headers
                } as any;

                if (headers.isBlob) {
                    options.responseType = 'blob';
                }

                this.angularHttp.get(url, options).subscribe(response => {
                    resolve(response);
                }, e => {
                    reject(e);
                });
            } catch (e) {
                reject(e);
            }
        });
    }

    post(url, body, headers): Promise<any> {
        return new Promise<any>((resolve, reject) => {
            try {
                headers = headers || {};
                this.angularHttp.post(url, body, {
                    headers: headers
                }).subscribe(response => {
                    resolve(response);
                }, e => {
                    reject(e);
                });
            } catch (e) {
                reject(e);
            }
        });
    }
}
