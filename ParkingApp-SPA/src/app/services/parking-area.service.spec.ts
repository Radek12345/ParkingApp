/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { ParkingAreaService } from './parking-area.service';

describe('Service: ParkingArea', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ParkingAreaService]
    });
  });

  it('should ...', inject([ParkingAreaService], (service: ParkingAreaService) => {
    expect(service).toBeTruthy();
  }));
});
