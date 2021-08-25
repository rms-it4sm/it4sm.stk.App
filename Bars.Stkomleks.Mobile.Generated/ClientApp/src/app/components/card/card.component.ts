import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'barsup-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.scss'],
})
export class CardComponent {

  constructor() { }

  @Input()
  title: string = '';
}
