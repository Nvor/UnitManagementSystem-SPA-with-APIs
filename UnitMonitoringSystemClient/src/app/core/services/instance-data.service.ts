import { Injectable } from '@angular/core';
import { BehaviorSubject, ReplaySubject, Subject } from 'rxjs';
import { Instance } from '../models/instance.model';

@Injectable({
  providedIn: 'root'
})
export class InstanceDataService {

  constructor() { }

  private instanceData: ReplaySubject<Instance> = new ReplaySubject<Instance>();

  instanceData$ = this.instanceData.asObservable();

  passInstance(instance: Instance) {
    this.instanceData.next(instance);
  }
}
