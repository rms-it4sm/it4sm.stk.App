import { Injectable, EventEmitter } from '@angular/core';
import { EventBusMessage } from 'src/app/models/EventBusMessage';

@Injectable({
  providedIn: 'root'
})
export class EventBusService {

  constructor() { }
  
  private messageSentEvent: EventEmitter<EventBusMessage> = new EventEmitter<EventBusMessage>();

  /**
   *  Отправить сообщение в шину
   * @param key ключ сообщения
   * @param value рабочая нагрузка
   */
  public sendMessage(key: string, value?: any) {
    this.messageSentEvent.emit(new EventBusMessage(key, value || {}));
  }

  /**
   * Подписаться на сообщение
   * @param key ключ
   * @param callback колбэк 
   */
  public subscribe(key: string, callback: Function) {
    this.messageSentEvent.subscribe(messageInfo => {
      if (messageInfo.key == key) {
        callback(messageInfo.value);
      }
    });
  }
}
