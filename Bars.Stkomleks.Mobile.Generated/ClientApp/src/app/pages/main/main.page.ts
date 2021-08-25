import { Component, OnInit } from '@angular/core';
import { MainMenuItem } from 'src/app/models/MainMenuItem';
import { MainMenuService } from 'src/app/services/main-menu.service';
import { Router } from '@angular/router';

import { Plugins, PushNotification, PushNotificationActionPerformed, PushNotificationToken } from '@capacitor/core';
const { PushNotifications } = Plugins;
import { FCM } from '@capacitor-community/fcm';

@Component({
  selector: 'app-main',
  templateUrl: './main.page.html',
  styleUrls: ['./main.page.scss'],
})
export class MainPage implements OnInit {

  constructor(private mainMenuService: MainMenuService,
    private router: Router) { }

  ngOnInit() {
    this.mainMenuItems = this.mainMenuService.getMenuItems().filter(x => x.visibleOnMainPage);
    this.registerPush();
  }

  private mainMenuItems: Array<MainMenuItem> = [];

  mainMenuItemClick(item) {
    this.router.navigateByUrl(`/${item.route}`);
  }

  async registerPush() {
    return;
    const result = await PushNotifications.requestPermission()
    if (result.granted) {
      PushNotifications.addListener('registration',
        (token: PushNotificationToken) => {
         // alert('Push registration success, token: ' + token.value);
        }
      );

      // Some issue with our setup and push will not work
      PushNotifications.addListener('registrationError',
        (error: any) => {
          alert('Произошла ошибка при подписке на PUSH уведомления: ' + JSON.stringify(error));
        }
      );

      // Show us the notification payload if the app is open on our device
      PushNotifications.addListener('pushNotificationReceived',
        (notification: PushNotification) => {
          alert('Push received: ' + JSON.stringify(notification));
        }
      );

      // Method called when tapping on a notification
      PushNotifications.addListener('pushNotificationActionPerformed',
        (notification: PushNotificationActionPerformed) => {
          alert('Push action performed: ' + JSON.stringify(notification));
        }
      );

      try {
        await PushNotifications.register();
      }
      catch (e) {
        alert(`register error ` + e);
      }
      try {
        const fcm = new FCM();
        const subscribeResult = await fcm.subscribeTo({ topic: 'main' });
        alert(`subscribed to topic`);
      }
      catch (e) {
        alert(`subscription error ` + e);
      }
    } else {
      alert('Не дали разрешения');
    }
  }
}
