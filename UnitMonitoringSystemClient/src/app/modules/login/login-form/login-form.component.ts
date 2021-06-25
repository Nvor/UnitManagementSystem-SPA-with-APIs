import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { delay } from 'rxjs/operators';
import { LoginService } from '../login.service';

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.scss']
})
export class LoginFormComponent implements OnInit {
  loginForm: FormGroup;
  errorMessages: string[];
  @Output() loggingIn = new EventEmitter<boolean>();

  constructor(
    private formBuilder: FormBuilder, 
    private loginService: LoginService) { }

  ngOnInit(): void {
    this.loginForm = this.formBuilder.group({
      email: ['', Validators.required],
      password: ['', Validators.required]
    })
  }

  onSubmit(loginForm: FormGroup) {
    if (!loginForm.valid) {
      this.errorMessages.push('Invalid credentials')
    }

    let email = loginForm.value.email,
        password = loginForm.value.password;
    
    this.userIsloggingIn(true);
    try {
      var userAuth = this.loginService.login(email, password);
    } catch (error) {
      console.log('Error logging in: ' + error)
      this.errorMessages.push('Error trying to log in')
    }


  }

  userIsloggingIn(disable: boolean) {
    this.loggingIn.emit(disable);
  }

}
