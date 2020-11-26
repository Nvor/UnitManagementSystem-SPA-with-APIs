import { Injectable } from '@angular/core';
import { BehaviorSubject, Subject } from 'rxjs';
import { Instance } from '../models/instance.model';

@Injectable({
  providedIn: 'root'
})
export class InstanceDataService {

  constructor() { }

  private instanceData: BehaviorSubject<Instance> = new BehaviorSubject<Instance>();

  instanceData$ = this.instanceData.asObservable();

  passInstance(instance: Instance) {
    this.instanceData.next(instance);
  }
}
