import { Component, Input } from '@angular/core';

/**
 * Компонент хедера списка
 */
@Component({
  selector: 'barsup-list-header',
  templateUrl: './list-header.component.html',
  styleUrls: ['./list-header.component.scss'],
})
export class ListHeaderComponent {

  constructor() { }

  /**
   * Заголовок
   */
  @Input()
  title: string;
}
