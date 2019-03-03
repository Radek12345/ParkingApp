import { ParkingAreaService } from './../../services/parking-area.service';
import { Component, OnInit } from '@angular/core';

import { ParkingArea } from './../../models/parking-area';

@Component({
  selector: 'app-parking-area-form',
  templateUrl: './parking-area-form.component.html',
  styleUrls: ['./parking-area-form.component.css']
})
export class ParkingAreaFormComponent implements OnInit {
  parkingArea: ParkingArea = {
    id: 0,
    name: '',
    weekdaysHourlyRate: 0,
    weekendHourlyRate: 0,
    discount: 0
  };

  constructor(private parkingAreaService: ParkingAreaService) { }

  ngOnInit() {
  }

  createArea() {
    this.parkingArea.discount /= 100;

    this.parkingAreaService.createParkingArea(this.parkingArea).subscribe(() => {
      console.log('success');
    });
  }

}
