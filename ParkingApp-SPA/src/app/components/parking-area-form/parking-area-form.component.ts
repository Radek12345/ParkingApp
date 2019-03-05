import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';

import { ParkingArea } from './../../models/parking-area';
import { ParkingAreaService } from './../../services/parking-area.service';

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

  isEditMode = false;

  constructor(private parkingAreaService: ParkingAreaService, private router: Router,
    private route: ActivatedRoute) { 
      route.params.subscribe(p => {
        if (+p['id']) {
          this.isEditMode = true;
          this.parkingArea.id = +p['id'];
        }
      });
    }

  ngOnInit() {
    if (this.isEditMode) {
      this.parkingAreaService.getParkingArea(this.parkingArea.id).subscribe(parkingArea => {
        this.parkingArea = parkingArea;
        this.parkingArea.discount *= 100;
      });
    }
  }

  createArea() {
    this.parkingArea.discount /= 100;

    this.parkingAreaService.createParkingArea(this.parkingArea).subscribe(() => {
      this.router.navigate(['/management']);
    });
  }

  editArea() {
    this.parkingArea.discount /= 100;

    this.parkingAreaService.updateParkingArea(this.parkingArea).subscribe(() => {
      this.router.navigate(['/management']);
    });
  }

}
