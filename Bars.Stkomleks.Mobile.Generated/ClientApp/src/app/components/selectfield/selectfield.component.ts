import { Component, OnInit, Input, Output, EventEmitter, ComponentRef } from '@angular/core';
import { PopoverController } from '@ionic/angular';
import { SelectfieldListComponent } from '../selectfield-list/selectfield-list.component';

@Component({
  selector: 'barsup-selectfield',
  templateUrl: './selectfield.component.html',
  styleUrls: ['./selectfield.component.scss'],
})
export class SelectfieldComponent {

  constructor(private popoverController: PopoverController) { }

  @Input()
  valueModel: Object;

  @Input()
  label: string;

  @Input()
  apiControllerName: string;

  @Input()
  displayField: string;

  @Output()
  valueModelChange = new EventEmitter<Object>();

  async openSelectorAsync(ev) {
    if (ev && ev.target.nodeName === 'ION-ICON') {
      return;
    }

    const popover = await this.popoverController.create({
      component: SelectfieldListComponent,
      componentProps: {
        apiControllerName: this.apiControllerName,
        displayField: this.displayField,
        title: this.label,
        onSelect: record => {
          this.valueModelChange.emit(record);
          popover.dismiss();
        }
      },
      translucent: true,
      cssClass: 'custom-popover'
    });

    return popover.present();
  }

  clear() {
    this.valueModelChange.emit(null);
  }
}
