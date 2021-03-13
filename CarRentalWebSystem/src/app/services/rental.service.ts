import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { RentalResponseModel } from '../models/responseModels/RentalResponseModel';

@Injectable({
  providedIn: 'root',
})
export class RentalService {
  constructor(private http: HttpClient) {}

  path = 'https://localhost:44313/api/rentals';

  getRentals(): Observable<RentalResponseModel> {
    return this.http.get<RentalResponseModel>(this.path);
  }
}
