import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';
import { LoadingComponent } from './loading/loading.component';
import { ListComponent } from './list/list.component';
import { EditorComponent, EditorPopoverComponent } from './editor/editor.component';
import { CurrentUserComponent } from './current-user/current-user.component';
import { SelectfieldComponent } from './selectfield/selectfield.component';
import { SelectfieldListComponent } from './selectfield-list/selectfield-list.component';
import { SwipeTabPanelComponent } from './swipe-tab-panel/swipe-tab-panel.component';
import { MatTabsModule } from '@angular/material/tabs';
import { MatExpansionModule } from '@angular/material/expansion';
import { ExpansionPanelComponent } from './expansion-panel/expansion-panel.component';
import { CardComponent } from './card/card.component';
import { ListHeaderComponent } from './list-header/list-header.component';
import { EditorHeaderComponent } from './editor-header/editor-header.component';
import { FilefieldComponent } from './filefield/filefield.component';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    MatTabsModule,
    MatExpansionModule
  ],
  declarations: [
    LoadingComponent,
    ListComponent,
    EditorComponent,
    CurrentUserComponent,
    SelectfieldComponent,
    SelectfieldListComponent,
    SwipeTabPanelComponent,
    ExpansionPanelComponent,
    CardComponent,
    EditorPopoverComponent,
    ListHeaderComponent,
    EditorHeaderComponent,
    FilefieldComponent
  ],
  exports: [
    LoadingComponent,
    ListComponent,
    EditorComponent,
    CurrentUserComponent,
    SelectfieldComponent,
    SelectfieldListComponent,
    SwipeTabPanelComponent,
    ExpansionPanelComponent,
    CardComponent,
    EditorPopoverComponent,
    ListHeaderComponent,
    EditorHeaderComponent,
    FilefieldComponent
  ]
})
export class ComponentsModule {}
