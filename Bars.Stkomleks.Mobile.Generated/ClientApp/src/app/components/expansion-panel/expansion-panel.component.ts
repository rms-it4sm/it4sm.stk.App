import { Component, OnInit, Input } from '@angular/core';

/**
 * Расширяемая панель
 */
@Component({
  selector: 'barsup-expansion-panel',
  templateUrl: './expansion-panel.component.html',
  styleUrls: ['./expansion-panel.component.scss'],
})
export class ExpansionPanelComponent {

  constructor() { }

  /**
   * Заголовок панели
   */
  @Input()
  title: string = '';

  /**
   * Панель открыта по умолчанию
   */
  @Input()
  expanded: boolean = true;

  /**
   * Сворачивание панели отключено
   */
  @Input()
  disabled: boolean = false;
}
