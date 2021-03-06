import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ListResponseModel } from '../models/ListResponseModel';
import { Rental } from '../models/Rental';

@Injectable({
  providedIn: 'root',
})
export class RentalService {
  constructor(private http: HttpClient) {}

  path = 'https://localhost:44313/api/rentals';

  getRentals(): Observable<ListResponseModel<Rental>> {
    return this.http.get<ListResponseModel<Rental>>(this.path);
  }
}
