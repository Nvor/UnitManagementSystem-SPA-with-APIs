import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class JwtHandlerService {

  constructor() { }

  getToken(): string {
    return window.localStorage['jwt_token']
  }

  saveToken(signedToken: string) {
    window.localStorage.setItem('jwt_token', signedToken);
  }

  deleteToken() {
    window.localStorage.removeItem('jwt_token');
  }
}
