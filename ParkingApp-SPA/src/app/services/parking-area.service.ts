import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { environment } from 'src/environments/environment';
import { ParkingArea } from './../models/parking-area';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ParkingAreaService {
  baseUrl = environment.apiUrl + 'parkingAreas';

  constructor(private http: HttpClient) { }

  getParkingArea(id: number): Observable<ParkingArea> {
    return this.http.get<ParkingArea>(this.baseUrl + '/' + id);
  }

  getParkingAreas(): Observable<ParkingArea[]> {
    return this.http.get<ParkingArea[]>(this.baseUrl);
  }

}
