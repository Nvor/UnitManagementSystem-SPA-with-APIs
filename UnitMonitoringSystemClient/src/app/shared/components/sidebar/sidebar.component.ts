import { Component, OnInit } from '@angular/core';
import { InstanceService } from 'src/app/core/services/instances.service';
import { Instance } from 'src/app/core/models/instance.model';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.scss']
})
export class SidebarComponent implements OnInit {

  availableInstances: Instance[];

  constructor(
    private instancesService: InstanceService
  ) { }

  ngOnInit() {
    this.instancesService.getInstances()
      .subscribe((i) => this.availableInstances = i);
  }

}
