import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouteReuseStrategy } from '@angular/router';

import { IonicModule, IonicRouteStrategy } from '@ionic/angular';
import { SplashScreen } from '@ionic-native/splash-screen/ngx';
import { StatusBar } from '@ionic-native/status-bar/ngx';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AppInfoService } from './services/app-info.service';
import { AuthService } from './services/auth.service';
import { LoadingComponent } from './components/loading/loading.component';
import { EventBusService } from './services/event-bus.service';
import { HttpWrapperService } from './services/http-wrapper.service';
import { MessageService } from './services/message.service';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { ApiService } from './services/api.service';
import { ComponentsModule } from './components/components.module';
import { MainMenuService } from './services/main-menu.service';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { File } from '@ionic-native/file/ngx';
import { AndroidPermissions } from '@ionic-native/android-permissions/ngx';
import { FileOpener } from '@ionic-native/file-opener/ngx';

@NgModule({
  declarations: [AppComponent],
  entryComponents: [],
  imports: [
    BrowserModule,
    IonicModule.forRoot(),
    AppRoutingModule,
    HttpClientModule,
    ComponentsModule,
    BrowserAnimationsModule
  ],
  providers: [
    StatusBar,
    SplashScreen,
    { provide: RouteReuseStrategy, useClass: IonicRouteStrategy },
    AppInfoService,
    AuthService,
    EventBusService,
    HttpWrapperService,
    MessageService,
    HttpClient,
    ApiService,
    MainMenuService,
    File,
    AndroidPermissions,
    FileOpener
  ],
  bootstrap: [AppComponent]
})
export class AppModule {}
