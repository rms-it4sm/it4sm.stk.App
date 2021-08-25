import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-selectfield-list',
  templateUrl: './selectfield-list.component.html',
  styleUrls: ['./selectfield-list.component.scss'],
})
export class SelectfieldListComponent {

  @Input()
  apiControllerName: string;

  @Input()
  displayField: string;

  @Input()
  onSelect: Function;

  @Input()
  title: string;

  private data: Array<any> = [];
}
