import { Component, OnInit } from '@angular/core';
import { AppInfoService } from 'src/app/services/app-info.service';
import { AuthService } from 'src/app/services/auth.service';
import { Router } from '@angular/router';
import { LoadingController } from '@ionic/angular';
import { EventBusService } from 'src/app/services/event-bus.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.page.html',
  styleUrls: ['./login.page.scss'],
})
export class LoginPage implements OnInit {

  constructor(private appInfoService: AppInfoService,
              private authService: AuthService,
              private router: Router,
              private loadingController: LoadingController,
              private eventBus: EventBusService) { }

  ngOnInit() {
    this.eventBus.sendMessage('unauthorized');

    this.isLoading = true;
    this.appDisplay = this.appInfoService.getAppDisplay();

    this.appInfoService.getCurrentUserAsync()
        .then(userInfo => {
          if (userInfo) {
            this.proceedAuthorized();
          }
        }).finally(() => {
      this.isLoading = false;
    });
  }

  private appDisplay: string = '';
  private isLoading: boolean = false;

  async authorize(form) {
    const loading = await this.loadingController.create({
      message: 'Выполняется авторизация...'
    });
    await loading.present();

    try {
      const loginResult = await this.authService.authorizeAsync(form.value.login, form.value.password);
      if (loginResult === true) {
        this.proceedAuthorized();
      }
    }
    finally {
      loading.dismiss();
    }
  }

  proceedAuthorized() {
    this.eventBus.sendMessage('authorized');
    this.router.navigateByUrl('/app', { skipLocationChange: true });
  }
}
