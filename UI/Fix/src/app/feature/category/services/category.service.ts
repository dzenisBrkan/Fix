import { Injectable } from '@angular/core';
import { AddCategoryRequest } from '../models/add-category-request.mode';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Mehanics } from '../models/mehanics.model';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

constructor(private http: HttpClient) { }

  addCategory(model: AddCategoryRequest): Observable<void> {
    return this.http.post<void>('https://localhost:7204/api/Mechanics', model)
  }

  getMechanics(): Observable<Mehanics[]> {
    return this.http.get<Mehanics[]>('https://localhost:7204/api/Mechanics');
  }
}
