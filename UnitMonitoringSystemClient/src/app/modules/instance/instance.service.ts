import { Injectable } from '@angular/core';
import { HttpService } from 'src/app/core/services/http.service';
import { Observable } from 'rxjs';
import { Unit } from 'src/app/core/models/unit.model';
import { HttpParams } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class InstanceService {

  constructor(
    private httpService: HttpService
  ) { }

  getUnits(): Observable<Unit[]> {
    const params = {};

    return this.httpService.get(
      '/Unit',
      new HttpParams({ fromObject: params })
    ).pipe(map((data) => data));
  }

  getUnitsByInstance(instanceId: number): Observable<Unit[]> {
    return this.httpService.get(
      '/Unit/' + instanceId)
      .pipe(map((data) => data));
  }
}
