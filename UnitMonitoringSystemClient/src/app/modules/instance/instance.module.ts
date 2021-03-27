import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FlexLayoutModule } from '@angular/flex-layout'
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatOptionModule } from '@angular/material/core';
import { MatDividerModule } from '@angular/material/divider';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatIconModule } from '@angular/material/icon';
import { MatInputModule } from '@angular/material/input';
import { MatListModule } from '@angular/material/list';
import { MatSelectModule } from '@angular/material/select';
import { MatToolbarModule } from '@angular/material/toolbar';
import { InstanceComponent } from './instance.component';
import { UnitsPanelComponent } from './units-panel/units-panel.component';
import { UnitDetailsPanelComponent } from './unit-details-panel/unit-details-panel.component';
import { UnitsOperationsLogComponent } from './units-operations-log/units-operations-log.component'
import { ReactiveFormsModule } from '@angular/forms'

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
    MatListModule,
    MatIconModule,
    MatButtonModule,
    MatFormFieldModule,
    MatSelectModule,
    MatOptionModule,
    MatInputModule,
    MatToolbarModule,
    ReactiveFormsModule
  ]

})
export class InstanceModule { }
