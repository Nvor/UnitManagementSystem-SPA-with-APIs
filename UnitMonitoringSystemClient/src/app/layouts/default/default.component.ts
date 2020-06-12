import { Component, OnInit } from '@angular/core';
import { Instance } from 'src/app/core/models/instance.model';
import { InstanceService } from 'src/app/core/services/instances.service';

@Component({
  selector: 'app-default',
  templateUrl: './default.component.html',
  styleUrls: ['./default.component.scss']
})
export class DefaultComponent implements OnInit {

  sideBarOpen: boolean = true;
  availableInstances: Array<Instance>;
  
  constructor(
    private instancesService: InstanceService
  ) { }

  ngOnInit() {
    this.instancesService.getInstances()
      .subscribe((i) => this.availableInstances = i);
  }

  sideBarToggle() {
    this.sideBarOpen = !this.sideBarOpen;
  }
}
