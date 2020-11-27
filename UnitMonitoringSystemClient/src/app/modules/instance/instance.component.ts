import { Component, OnInit } from '@angular/core';
import { Instance } from 'src/app/core/models/instance.model';
import { Unit } from 'src/app/core/models/unit.model';
import { InstanceDataService } from 'src/app/core/services/instance-data.service';
import { UnitDetailsPanelComponent } from './unit-details-panel/unit-details-panel.component';

@Component({
  selector: 'app-instance',
  templateUrl: './instance.component.html',
  styleUrls: ['./instance.component.scss']
})
export class InstanceComponent implements OnInit {
  activeUnit: Unit;
  newUnit: boolean = false;
  instance: Instance;

  constructor(
    private instanceDataService: InstanceDataService) { 
    }

  ngOnInit(): void {
    this.instanceDataService.instanceData$.subscribe(instance => this.instance = instance);
  }

  setUnit(activeUnit: Unit) {
    console.log(activeUnit);
    this.activeUnit = activeUnit;
  }

  addNewUnit() {
    this.newUnit = !this.newUnit;
  }

}
