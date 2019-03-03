import { Component, OnInit } from '@angular/core';

import { ParkingArea } from 'src/app/models/parking-area';
import { ParkingAreaService } from './../../services/parking-area.service';

@Component({
  selector: 'app-management',
  templateUrl: './management.component.html',
  styleUrls: ['./management.component.css']
})
export class ManagementComponent implements OnInit {
  private _parkingAreas: ParkingArea[];

  constructor(private parkingAreaService: ParkingAreaService) { }

  ngOnInit() {
    this.loadParkingAreas();
  }

  private loadParkingAreas() {
    this.parkingAreaService.getParkingAreas().subscribe(parkingAreas => {
      this._parkingAreas = parkingAreas;
    });
  }

  get parkingAreas() {
    return this._parkingAreas;
  }

}
