import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Color } from '../models/Color';
import { ListResponseModel } from '../models/ListResponseModel';

@Injectable({
  providedIn: 'root',
})
export class ColorService {
  constructor(private http: HttpClient) {}
  path = 'https://localhost:44313/api/colors';
  getColors(): Observable<ListResponseModel<Color>> {
    return this.http.get<ListResponseModel<Color>>(this.path);
  }
}
