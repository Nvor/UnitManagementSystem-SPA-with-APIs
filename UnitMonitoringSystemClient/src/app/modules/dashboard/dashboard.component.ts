import { Component, OnInit, ViewChild } from '@angular/core';
import { DashboardService } from '../dashboard.service';
import { GridsterConfig, GridsterItem, GridsterItemComponent, GridType } from 'angular-gridster2';
import { GridsterWidget } from './widgets/models/gridster-widget';
import { WidgetSize } from './widgets/models/widget-size';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {
  options: GridsterConfig;
  dashboard: Array<GridsterItem>;
  private tileHeight = 50;
  private tileWidth = 50;
  private tileBorder = 5;

  constructor(private dashboardService: DashboardService) { }

  ngOnInit() {
    this.options = {
      gridType: GridType.Fixed,
      margin: this.tileBorder,
      outerMargin: true,
      defaultItemCols: 0,
      defaultItemRows: 0,
      fixedColWidth: this.tileWidth + this.tileBorder,
      fixedRowHeight: this.tileHeight + this.tileBorder,
      draggable: {
        enabled: true
      },
      resizable: {
        enabled: true
      },
      swap: true,
      disableWindowResize: true,
      displayGrid: 'onDrag&Resize',
      itemChangeCallback: DashboardComponent.itemChange.bind(this),
      itemResizeCallback: DashboardComponent.itemResize.bind(this)
    };

    this.dashboard = [
      {cols: 2, rows: 1, y: 0, x: 0},
      {cols: 2, rows: 1, y: 0, x: 0}
    ];
  }

  // static itemChange(item, itemComponent) {
  //   console.info('itemChanged', item, itemComponent);
  // }

  static itemChange(widget: GridsterWidget, itemComponent: GridsterItemComponent) {
    if (widget) {
      this.checkSizeRestrictions(widget);
      widget.size = new WidgetSize(widget.rows, widget.cols);
      widget.size.height = itemComponent.height;
    }
  }

  static checkSizeRestrictions(widget: GridsterWidget) {
    //check resize restrictions
  }

  static itemResize(item, itemComponent) {
    console.info('itemResized', item, itemComponent);
  }

  changedOptions() {
    this.options.api.optionsChanged();
  }

  removeItem(item) {
    this.dashboard.splice(this.dashboard.indexOf(item), 1);
  }

  addItem(item) {
    this.dashboard.push(item);
  }
}
