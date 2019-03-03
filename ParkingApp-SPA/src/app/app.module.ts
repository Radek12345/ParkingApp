import { ParkingAreaFormComponent } from './components/parking-area-form/parking-area-form.component';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { BsDatepickerModule } from 'ngx-bootstrap';
import { TimepickerModule } from 'ngx-bootstrap';

import { AppComponent } from './app.component';
import { ParkingAreaService } from './services/parking-area.service';
import { PaymentComponent } from './components/payment/payment.component';
import { ManagementComponent } from './components/management/management.component';
import { MinValueValidatorDirective } from './validators/min-value-validator.directive';
import { MaxValueValidatorDirective } from './validators/max-value-validator.directive';


@NgModule({
  declarations: [
    AppComponent,
    PaymentComponent,
    ManagementComponent,
    ParkingAreaFormComponent,
    MinValueValidatorDirective,
    MaxValueValidatorDirective
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    BsDatepickerModule.forRoot(),
    TimepickerModule.forRoot()
  ],
  providers: [
    ParkingAreaService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
