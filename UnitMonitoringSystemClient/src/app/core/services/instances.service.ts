import { Injectable } from '@angular/core';
import { HttpService } from './http.service';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Instance } from '../models/instance.model';
import { HttpParams } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class InstanceService {

  constructor(
    private httpService: HttpService
  ) { }

  getInstances(): Observable<Array<Instance>> {
    const params = {};

    return this.httpService.get(
      '/instance',
      new HttpParams({ fromObject: params })
    ).pipe(map((data) => data));
  }
}
