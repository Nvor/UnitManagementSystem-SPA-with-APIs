import { Component, OnInit } from '@angular/core';
import { Instance } from 'src/app/core/models/instance.model';
import { InstanceDataService } from 'src/app/core/services/instance-data.service';
import { UnitDetailsPanelComponent } from './unit-details-panel/unit-details-panel.component';

@Component({
  selector: 'app-instance',
  templateUrl: './instance.component.html',
  styleUrls: ['./instance.component.scss']
})
export class InstanceComponent implements OnInit {

  newUnit: boolean = false;
  instance: Instance;

  constructor(
    private instanceDataService: InstanceDataService) { 
    }

  ngOnInit(): void {
    this.instanceDataService.instanceData$.subscribe(instance => this.instance = instance);
  }

  addNewUnit() {
    this.newUnit = !this.newUnit;
  }

}
