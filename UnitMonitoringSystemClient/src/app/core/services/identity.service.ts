import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { take } from 'rxjs/operators';
import { UserAuth } from '../models/user-auth.model';
import { HttpService } from './http.service';

@Injectable({
  providedIn: 'root'
})
export class IdentityService {
  url: string = '/identity/'

  constructor(
    private httpService: HttpService
  ) { }

  BasicLogin(loginData: object): Observable<object> {
    return this.httpService.post(this.url, loginData)
      .pipe(
        take(1)
      )
  }
}
