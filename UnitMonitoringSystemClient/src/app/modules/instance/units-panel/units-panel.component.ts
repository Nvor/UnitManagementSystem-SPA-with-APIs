import { Component, OnInit } from '@angular/core';
import { InstanceService } from '../instance.service';
import { Unit } from 'src/app/core/models/unit.model';

@Component({
  selector: 'app-units-panel',
  templateUrl: './units-panel.component.html',
  styleUrls: ['./units-panel.component.scss']
})
export class UnitsPanelComponent implements OnInit {

  unitNames: string[];
  units: Unit[];

  constructor(
    private instanceService: InstanceService
  ) { }

  ngOnInit(): void {
    this.instanceService.getUnits()
      //.subscribe((names) => this.unitNames = names);
      .subscribe((u) => this.units = u);
  }

}
