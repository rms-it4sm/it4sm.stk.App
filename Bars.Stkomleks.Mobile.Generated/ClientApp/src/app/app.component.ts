import { Component, ViewChildren, QueryList, OnInit } from '@angular/core';

import { Platform, IonRouterOutlet } from '@ionic/angular';
import { SplashScreen } from '@ionic-native/splash-screen/ngx';
import { StatusBar } from '@ionic-native/status-bar/ngx';
import { EventBusService } from './services/event-bus.service';
import { AppInfoService } from './services/app-info.service';
import { Router } from '@angular/router';
import { MessageService } from './services/message.service';
import { MainMenuService } from './services/main-menu.service';
import { AppMenu } from './menu/app-menu';
import { AppGeneratedMenu } from './menu/app-menu.generated';

@Component({
  selector: 'app-root',
  templateUrl: 'app.component.html',
  styleUrls: ['app.component.scss']
})
export class AppComponent {
  constructor(
      private platform: Platform,
      private splashScreen: SplashScreen,
      private statusBar: StatusBar,
      private eventBus: EventBusService,
      private appInfoService: AppInfoService,
      private messageService: MessageService,
      private router: Router,
      private mainMenuService: MainMenuService
  ) {
    this.initializeApp();
  }

  initializeApp() {
    // Обработка нажатия на кнопку Назад
    this.platform.backButton.subscribe(() => {
      this.routerOutlets.forEach((outlet: IonRouterOutlet) => {
        if (outlet && outlet.canGoBack()) {
          outlet.pop();
        }
      });
    });

    this.eventBus.subscribe('authorized', () => {
      this.menuDisabled = false;
    });

    this.eventBus.subscribe('unauthorized', () => {
      this.menuDisabled = true;
    });

    this.appDisplay = this.appInfoService.getAppDisplay();

    this.platform.ready().then(() => {
      this.statusBar.styleDefault();
      this.splashScreen.hide();
    });

    // Регистрируем пункты меню
    [...AppMenu, ...AppGeneratedMenu].forEach(x => this.mainMenuService.addMenuItem(x));

    this.appPages = this.mainMenuService.getMenuItems();
  }

  @ViewChildren(IonRouterOutlet) routerOutlets: QueryList<IonRouterOutlet>;
  private appDisplay: string = '';
  private menuDisabled: boolean = false;
  private appPages = [];

  /**
   * Выйти из профиля
   */
  async exitAsyn() {
    await this.messageService.confirm('Выход', 'Выйти из текущего профиля?');

    await this.appInfoService.setCurrentUserAsync(null);
    this.menuDisabled = true;
    this.router.navigateByUrl('/');
  }
}
