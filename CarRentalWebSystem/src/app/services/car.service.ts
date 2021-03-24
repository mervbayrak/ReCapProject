import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Car } from '../models/Car';
import { ItemResponseModel } from '../models/ItemResponseModel';
import { ListResponseModel } from '../models/ListResponseModel';
import { ResponseModel } from '../models/ResponseModel';

@Injectable({
  providedIn: 'root',
})
export class CarService {
  constructor(private http: HttpClient) {}

  path = 'https://localhost:44313/api/cars';

  getCars(): Observable<ListResponseModel<Car>> {
    return this.http.get<ListResponseModel<Car>>(this.path);
  }
  getCar(carId): Observable<ItemResponseModel<Car>> {
    if (carId) {
      this.path += '/' + carId;
    }
    return this.http.get<ItemResponseModel<Car>>(this.path);
  }
  add(car:Car):Observable<ResponseModel>{
    return this.http.post<ResponseModel>(this.path + "cars/add", car);
  }
}
