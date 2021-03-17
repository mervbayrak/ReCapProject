import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Brand } from '../models/Brand';
import { ListResponseModel } from '../models/ListResponseModel';

@Injectable({
  providedIn: 'root',
})
export class BrandService {
  constructor(private http: HttpClient) {}

  path = 'https://localhost:44313/api/brands';
  getBrands(): Observable<ListResponseModel<Brand>> {
    return this.http.get<ListResponseModel<Brand>>(this.path);
  }
}
