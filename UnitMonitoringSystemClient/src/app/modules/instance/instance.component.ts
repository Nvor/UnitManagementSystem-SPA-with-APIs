import { Component, OnInit } from '@angular/core';
import { UnitDetailsPanelComponent } from './unit-details-panel/unit-details-panel.component';

@Component({
  selector: 'app-instance',
  templateUrl: './instance.component.html',
  styleUrls: ['./instance.component.scss']
})
export class InstanceComponent implements OnInit {

  newUnit: boolean = false;

  constructor() { }

  ngOnInit(): void {
  }

  addNewUnit() {
    console.log('new unit click emitted');
    this.newUnit = !this.newUnit;
  }

}
