import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UnitsOperationsLogComponent } from './units-operations-log.component';

describe('UnitsOperationsLogComponent', () => {
  let component: UnitsOperationsLogComponent;
  let fixture: ComponentFixture<UnitsOperationsLogComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UnitsOperationsLogComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UnitsOperationsLogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
