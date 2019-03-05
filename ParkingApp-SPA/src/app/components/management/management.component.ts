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

  deleteParkingArea(id: number) {
    if (confirm('Do you want to delete this parking area?')) {
      this.parkingAreaService.deleteParkingArea(id).subscribe(() => {
        const index = this._parkingAreas.findIndex(p => p.id === id);
        this._parkingAreas.splice(index, 1);
      });
    }
  }

  get parkingAreas() {
    return this._parkingAreas;
  }

}
