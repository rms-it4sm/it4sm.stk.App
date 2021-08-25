import { Injectable } from '@angular/core';
import { MainMenuItem } from 'src/app/models/MainMenuItem';

/**
 * Сервис главного меню
 */
@Injectable({
  providedIn: 'root'
})
export class MainMenuService {

  constructor() { }

  private menuItems: Array<MainMenuItem> = [];

  /**
   * Добавить пункт меню
   * @param item 
   */
  addMenuItem(item: MainMenuItem) {
    this.menuItems.push(item);
  }

  /**
   * Получить пункты меню
   */
  getMenuItems() {
    return this.menuItems.map(x => Object.assign({}, x));
  }
}
