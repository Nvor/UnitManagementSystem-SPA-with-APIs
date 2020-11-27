import { Component, OnInit, Output, Input, EventEmitter } from '@angular/core';
import { InstanceService } from '../instance.service';
import { Unit } from 'src/app/core/models/unit.model';
import { Instance } from 'src/app/core/models/instance.model';

@Component({
  selector: 'app-units-panel',
  templateUrl: './units-panel.component.html',
  styleUrls: ['./units-panel.component.scss']
})
export class UnitsPanelComponent implements OnInit {

  @Output() addNewUnit: EventEmitter<any> = new EventEmitter<any>();
  @Output() activeUnit: EventEmitter<Unit> = new EventEmitter<Unit>();
  @Input() instance: Instance;

  units: Unit[];

  constructor(
    private instanceService: InstanceService
  ) { }

  ngOnInit(): void {
    this.instanceService.getUnitsByInstance(this.instance.id)
      .subscribe((u) => this.units = u);
  }

  accessUnit(unit: Unit) {
    this.activeUnit.emit(unit);
  }

  addUnit() {
    this.addNewUnit.emit();
    setTimeout(() => {
      window.dispatchEvent(
        new Event("addUnit")
      );
    }, 300);
  }

}
