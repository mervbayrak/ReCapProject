import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CarResponseModel } from '../models/responseModels/CarResponseModel';

@Injectable({
  providedIn: 'root',
})
export class CarService {
  constructor(private http: HttpClient) {}

  path = 'https://localhost:44313/api/cars';

  getCars(): Observable<CarResponseModel> {
    return this.http.get<CarResponseModel>(this.path);
  }
}
