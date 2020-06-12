import { Component, OnInit, Input, OnChanges, SimpleChanges } from '@angular/core';
import { FormGroup, FormControl, FormBuilder, Validators } from '@angular/forms';
import { Unit } from 'src/app/core/models/unit.model';

@Component({
  selector: 'app-unit-details-panel',
  templateUrl: './unit-details-panel.component.html',
  styleUrls: ['./unit-details-panel.component.scss']
})
export class UnitDetailsPanelComponent implements OnInit, OnChanges {

  @Input() newUnit: boolean = false;

  editUnitDetails: boolean = false;
  unitForm: FormGroup;

  constructor(
    private formBuilder: FormBuilder
  ) { }

  ngOnInit() {
    this.unitForm = this.formBuilder.group({
      name: ['', Validators.required],
      description: ['', Validators.required]
    });
  }

  ngOnChanges(changes: SimpleChanges) {
    if (changes['newUnit']) {
      this.createUnit();
    }
  }

  createUnit() {
    this.resetForm();
    this.editUnitDetails = true;
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
