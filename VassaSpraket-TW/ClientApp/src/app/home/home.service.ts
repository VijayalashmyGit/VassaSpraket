import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { ApiResponse } from '../models/apiResponse';
import { ChaptersViewModel } from '../models/chapters.model';
import { Observable, tap } from 'rxjs';
import { CacheService } from '../services/cache.service';


@Injectable({
  providedIn: 'root'
})

export class HomeService {

  private baseUrl: string = environment.apiBaseUrl;

  constructor(private httpClient: HttpClient, private cacheService: CacheService) { }


  getAllChapters(): Observable<ApiResponse<ChaptersViewModel>> {
    const cacheKey = 'allChapters';
    const cachedResponse = this.cacheService.get(cacheKey);

    if (cachedResponse) {
      return cachedResponse;
    } else {
      return this.httpClient.get<ApiResponse<ChaptersViewModel>>(this.baseUrl + "Chapters/GetAllChapters").pipe(
        tap((data: any) => {
          this.cacheService.set(cacheKey, data);
        })
      );
    }
  }


}
