import { Injectable } from '@angular/core';
import { ToastController, AlertController } from '@ionic/angular';

@Injectable({
  providedIn: 'root'
})
/**
 * Сервис отображения сообщений
 */
export class MessageService {

  constructor(private toastController: ToastController,
    private alertController: AlertController) { }

    /**
     * Показать всплывающую подсказку
     */
    toast(message: string): void {
      this.toastController.create({
          message: message,
          duration: 5000
      }).then(x => x.present());
  }

  /**
   * Показать модальное сообщение
   */
  async alert(title: string, message: string): Promise<void> {
      const alert = await this.alertController.create({
          header: title,
          message: message,
          buttons: [
              {
                  text: 'Ok',
                  role: 'cancel'
              }
          ]
      }) as any;
      await alert.present();
  }

  /**
   * Показать модальное сообщение
   */
  async input(title: string, message: string, inputTitle: string): Promise<string> {
      return new Promise<string>(async (resolve, reject) => {
          const alert = await this.alertController.create({
              header: title,
              message: message,
              inputs: [
                  {
                      name: 'input',
                      type: 'text',
                      placeholder: inputTitle
                  }
              ],
              buttons: [
                  {
                      text: 'Ok',
                      handler: data => {
                          resolve(data.input);
                      }
                  }
              ]
          }) as any;
          await alert.present();
      });
  }

  /**
   * Показать модальное окно с подтверждением
   * @param title
   * @param message
   * @returns {Promise<void>}
   */
  async confirm(title: string, message: string): Promise<void> {
      return new Promise<void>(async (resolve, reject) => {
          const alert = await this.alertController.create({
              header: title,
              message: message,
              buttons: [
                  {
                      text: 'Да',
                      handler: async () => {
                          resolve();
                      }
                  },
                  {
                      text: 'Нет',
                      role: 'cancel',
                      handler: () => {
                          reject();
                      }
                  }
              ]
          }) as any;
          await alert.present();
      });
  }
}
