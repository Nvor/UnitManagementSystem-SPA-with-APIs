import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FlexLayoutModule } from '@angular/flex-layout'
import { MatCardModule, MatDividerModule, MatListModule } from '@angular/material';
import { InstanceComponent } from './instance.component';
import { UnitsPanelComponent } from './units-panel/units-panel.component';
import { UnitDetailsPanelComponent } from './unit-details-panel/unit-details-panel.component';
import { UnitsOperationsLogComponent } from './units-operations-log/units-operations-log.component'

@NgModule({
  declarations: [
    InstanceComponent,
    UnitsPanelComponent,
    UnitDetailsPanelComponent,
    UnitsOperationsLogComponent
  ],
  imports: [
    CommonModule,
    FlexLayoutModule,
    MatCardModule,
    MatDividerModule,
    MatListModule
  ]

})
export class InstanceModule { }
