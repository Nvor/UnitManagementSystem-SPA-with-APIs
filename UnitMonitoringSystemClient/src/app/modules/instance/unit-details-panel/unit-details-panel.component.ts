import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-unit-details-panel',
  templateUrl: './unit-details-panel.component.html',
  styleUrls: ['./unit-details-panel.component.scss']
})
export class UnitDetailsPanelComponent implements OnInit {

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

  getNameError() {
    return this.unitForm.get('name').hasError('required')
  }

  getDescriptionError() {
    return this.unitForm.get('description').hasError('required')
  }

  onSubmit(form: FormGroup) {
    
    console.log('Valid?', form.valid);
    console.log('Name', form.value.name);
    console.log('Description', form.value.description);
  }
}
