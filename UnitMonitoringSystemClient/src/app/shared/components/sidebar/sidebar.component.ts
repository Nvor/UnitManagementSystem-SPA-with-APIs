import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { InstanceService } from 'src/app/core/services/instances.service';
import { Instance } from 'src/app/core/models/instance.model';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.scss']
})
export class SidebarComponent implements OnInit {
  @Input() availableInstances: Array<Instance>;
  @Output() activeInstance: EventEmitter<Instance> = new EventEmitter<Instance>();

  constructor(
  ) { }

  ngOnInit() {
  }

  selectInstance(selectedInstance: Instance): void {
    this.activeInstance.emit(selectedInstance);
  }

}
