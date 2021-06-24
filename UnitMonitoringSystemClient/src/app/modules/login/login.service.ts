import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { UserAuth } from 'src/app/core/models/user-auth.model';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  constructor() { }

  login(username: string, password: string): Observable<UserAuth> {
    return new Observable<UserAuth>();
  }
}
