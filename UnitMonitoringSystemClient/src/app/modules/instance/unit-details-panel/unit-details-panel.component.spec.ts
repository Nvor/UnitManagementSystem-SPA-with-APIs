import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UnitDetailsPanelComponent } from './unit-details-panel.component';

describe('UnitDetailsPanelComponent', () => {
  let component: UnitDetailsPanelComponent;
  let fixture: ComponentFixture<UnitDetailsPanelComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UnitDetailsPanelComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UnitDetailsPanelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
