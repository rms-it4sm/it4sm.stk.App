import { Component, OnInit, AfterViewInit, ViewChild, ViewChildren, ContentChildren, QueryList, ElementRef, ApplicationRef, ChangeDetectorRef } from '@angular/core';
import { MatTabGroup, MatTab } from '@angular/material/tabs';
import { GestureController } from '@ionic/angular';

/**
 * Компонент табов с поддержкой свайпов
 */
@Component({
  selector: 'barsup-swipe-tab-panel',
  templateUrl: './swipe-tab-panel.component.html',
  styleUrls: ['./swipe-tab-panel.component.scss'],
})
export class SwipeTabPanelComponent implements AfterViewInit {

  constructor(private gestureController: GestureController, private ref: ChangeDetectorRef) { }

  @ViewChild('divcontainer')
  div: ElementRef;

  @ViewChild(MatTabGroup)
  matTabGroup: MatTabGroup;

  @ViewChildren(MatTab)
  inclusiveTabs: QueryList<MatTab>;

  @ContentChildren(MatTab, { descendants: true })
  tabsFromNgContent: QueryList<MatTab>;

  private selectedTab: number = 0;

  ngAfterViewInit() {
    this.matTabGroup._tabs.reset([...this.inclusiveTabs.toArray(), ...this.tabsFromNgContent.toArray()]);
    this.matTabGroup._tabs.notifyOnChanges();

    const gesture = this.gestureController.create({
      gestureName: 'Swipe',
      el: this.div.nativeElement,
      onEnd: (detail) => { this.swipe(detail); }
    });

    gesture.enable();
  }

  swipe(e): void {
    const xAbs = Math.abs(e.deltaX),
      yAbs = Math.abs(e.deltaY);

    if (xAbs <= yAbs || xAbs < 50) {
      return;
    }

    if (e.deltaX > 0) {
      if (this.selectedTab >= 1) {
        this.selectedTab = this.selectedTab - 1;
      }
    }
    else {
      if (this.selectedTab < this.matTabGroup._tabs.length - 1) {
        this.selectedTab = this.selectedTab + 1;
      }
    }

    this.ref.detectChanges();
  }
}
