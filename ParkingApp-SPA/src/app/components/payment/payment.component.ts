import { Component, OnInit } from '@angular/core';

import { ParkingAreaService } from './../../services/parking-area.service';
import { ParkingArea } from './../../models/parking-area';

@Component({
  selector: 'app-payment',
  templateUrl: './payment.component.html',
  styleUrls: ['./payment.component.css']
})
export class PaymentComponent implements OnInit {
  private parkingAreas: ParkingArea[];

  constructor(private parkingAreaService: ParkingAreaService) { }

  ngOnInit() {
    this.loadParkingAreas();
  }

  private loadParkingAreas() {
    this.parkingAreaService.getParkingAreas().subscribe(parkingAreas => {
      this.parkingAreas = parkingAreas;
      console.log(this.parkingAreas);
    });
  }

}
