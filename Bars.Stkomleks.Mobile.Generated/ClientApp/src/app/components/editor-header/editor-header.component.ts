import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'barsup-editor-header',
  templateUrl: './editor-header.component.html',
  styleUrls: ['./editor-header.component.scss'],
})
export class EditorHeaderComponent {

  constructor() { }
  
  @Input()
  title: string;

  @Output()
  onShowPopover = new EventEmitter<any>();

}
