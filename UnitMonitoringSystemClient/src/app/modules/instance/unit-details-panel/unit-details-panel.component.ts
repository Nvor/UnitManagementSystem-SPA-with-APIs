import { Component, OnInit, Input, OnChanges, SimpleChanges } from '@angular/core';
import { FormGroup, FormControl, FormBuilder, Validators } from '@angular/forms';
import { Unit } from 'src/app/core/models/unit.model';

@Component({
  selector: 'app-unit-details-panel',
  templateUrl: './unit-details-panel.component.html',
  styleUrls: ['./unit-details-panel.component.scss']
})
export class UnitDetailsPanelComponent implements OnInit, OnChanges {
  @Input() activeUnit: Unit;
  @Input() newUnit: boolean = false;

  unitInUse: Unit;
  editUnitDetails: boolean = false;
  displayMode: UnitDisplayMode = UnitDisplayMode.View;
  unitForm: FormGroup;

  public get unitDisplayMode(): typeof UnitDisplayMode {
    return UnitDisplayMode;
  }

  constructor(
    private formBuilder: FormBuilder
  ) { }

  ngOnInit() {
    this.unitForm = this.formBuilder.group({
      id: [''],
      name: ['', Validators.required],
      description: ['', Validators.required]
    });

    if (this.unitInUse == null) {
      this.createUnit();
    }
  }

  ngOnChanges(changes: SimpleChanges) {
    if (changes['activeUnit'] && !changes['activeUnit'].firstChange) {
      this.setUnit();
    }
    if (changes['newUnit']) {
      this.createUnit();
    }
  }

  createUnit() {
    if (this.unitForm) {
      this.resetForm();
    }
    this.displayMode = UnitDisplayMode.Create;
    this.editUnitDetails = true;
  }

  setUnit() {
    this.displayMode = UnitDisplayMode.Edit;
    this.editUnitDetails = true;
    this.displayData();
    this.populateFormData();
  }

  displayData() {
    console.log(this.activeUnit.id);
    console.log(this.activeUnit.name);
    console.log(this.activeUnit.description);
  }

  populateFormData() {
    this.unitForm = this.formBuilder.group({
      id: [this.activeUnit.id],
      name: [this.activeUnit.name, Validators.required],
      description: [this.activeUnit.description, Validators.required]
    });
  }

  saveUnit() {
    this.toggleEdit();
  }

  deleteUnit() {
    this.toggleEdit();
  }

  cancelEdit() {
    this.toggleEdit();
  }

  toggleEdit() {
    this.editUnitDetails = !this.editUnitDetails;
  }

  onSubmit(form: FormGroup) {
    console.log('Valid?', form.valid);
    console.log('Id', form.value.id);
    console.log('Name', form.value.name);
    console.log('Description', form.value.description);

    this.resetForm();
    this.toggleEdit();
  }

  resetForm() {
    this.unitForm.reset();
  }

  getNameError() {
    return this.unitForm.get('name').hasError('required')
  }

  getDescriptionError() {
    return this.unitForm.get('description').hasError('required')
  }
}

enum UnitDisplayMode {
  Create,
  Edit,
  View
}