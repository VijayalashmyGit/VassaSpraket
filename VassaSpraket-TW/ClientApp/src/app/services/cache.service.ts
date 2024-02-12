import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { tap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root',
})
export class CacheService {
  private cache = new Map<string, any>();

  constructor() { }

  get(key: string): Observable<any> | undefined {
    return this.cache.has(key) ? of(this.cache.get(key)) : undefined;
  }

  set(key: string, data: any): void {
    this.cache.set(key, data);
  }
}
