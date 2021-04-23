import { WidgetType } from "../enums/widget-type.enum";
import { WidgetSize } from "./widget-size";

export class GridsterWidget {
    id: string;
    type: WidgetType;
    size: WidgetSize;

    cols: number;
    rows: number;
    x: number;
    y: number;

    constructor(init?: Partial<GridsterWidget>) {
        Object.assign(this, init)
    }
}
