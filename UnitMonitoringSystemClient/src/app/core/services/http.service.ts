import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http'
import { Observable, throwError } from 'rxjs';
import { JwtHandlerService } from './jwt-handler.service';
import { environment } from '../../../environments/environment';
import { catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(
    private httpClient: HttpClient,
    private jwtHandlerService: JwtHandlerService
  ) { }

  //Http Verbs
  get(path: string, params: HttpParams = new HttpParams()): Observable<any> {
    return this.httpClient.get(`${environment.api_url}${path}`, { params })
      .pipe(catchError(error => this.handleError(error)));
  }

  put(path: string, body: object = {}): Observable<any> {
    return this.httpClient.put(`${environment.api_url}${path}`, JSON.stringify(body))
      .pipe(catchError(error => this.handleError(error)));
  }

  post(path: string, body: object = {}): Observable<any> {
    return this.httpClient.post(`${environment.api_url}${path}`, JSON.stringify(body))
      .pipe(catchError(error => this.handleError(error)));
  }

  delete(path: string): Observable<any> {
    return this.httpClient.delete(`${environment.api_url}${path}`)
      .pipe(catchError(error => this.handleError(error)));
  }

  //Helpers
  handleError(error: any): Observable<any> {
    console.log('Http Error', error)
    return throwError(error);
  }
}
