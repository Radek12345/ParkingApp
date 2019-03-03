import { Component, OnInit } from '@angular/core';
import { BsDatepickerConfig } from 'ngx-bootstrap';

import { ParkingAreaService } from './../../services/parking-area.service';
import { ParkingArea } from './../../models/parking-area';

@Component({
  selector: 'app-payment',
  templateUrl: './payment.component.html',
  styleUrls: ['./payment.component.css']
})
export class PaymentComponent implements OnInit {
  private _parkingAreas: ParkingArea[];

  parkingAreaId: number;
  timeStart: Date;
  timeEnd: Date;
  parkingDay: Date;

  fee: number;

  bsConfig: Partial<BsDatepickerConfig>;

  constructor(private parkingAreaService: ParkingAreaService) { }

  ngOnInit() {
    this.bsConfig = {
      containerClass: 'theme-dark-blue'
    };
    this.loadParkingAreas();
  }

  private loadParkingAreas() {
    this.parkingAreaService.getParkingAreas().subscribe(parkingAreas => {
      this._parkingAreas = parkingAreas;
    });
  }

  calculateFee() {
    // tslint:disable-next-line:triple-equals
    const parkingArea = this._parkingAreas.find(p => p.id == this.parkingAreaId);
    const parkingHours =
      Math.ceil((this.timeEnd.getTime() - this.timeStart.getTime()) / 1000 / 60 / 60);

    if (this.parkingDay.getDay() % 6 === 0) {
      this.fee = parkingHours * parkingArea.weekendHourlyRate;
    } else {
      this.fee = parkingHours * parkingArea.weekdaysHourlyRate;
    }

    this.fee = this.fee - (this.fee * parkingArea.discount);
  }

  get parkingAreas() {
    return this._parkingAreas;
  }

}
