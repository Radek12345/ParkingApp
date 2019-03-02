import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { ParkingAreaService } from './services/parking-area.service';
import { PaymentComponent } from './components/payment/payment.component';

@NgModule({
  declarations: [
    AppComponent,
    PaymentComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule
  ],
  providers: [
    ParkingAreaService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
