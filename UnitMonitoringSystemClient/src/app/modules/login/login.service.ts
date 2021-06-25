import { HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map, share } from 'rxjs/operators';
import { UserAuth } from 'src/app/core/models/user-auth.model';
import { IdentityService } from 'src/app/core/services/identity.service';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  constructor(
    private identityService: IdentityService
  ) { }

  login(email: string, password: string): Observable<UserAuth> {
    const headers = new HttpHeaders({
      Accept: 'application/json text/plain, */*'
    });
    
    var data = {
      username: email,
      password: password
    }

    return this.identityService.BasicLogin(data)
      .pipe(
        map((response: any) => {
          let authModel = new UserAuth();
          authModel.Username = response.username;
          authModel.AccessToken = response.access_token;

          return authModel;
        }),
        share()
      );
  }
}
