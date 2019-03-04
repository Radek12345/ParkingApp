import { Routes } from '@angular/router';
import { ParkingAreaFormComponent } from './components/parking-area-form/parking-area-form.component';
import { ManagementComponent } from './components/management/management.component';
import { PaymentComponent } from './components/payment/payment.component';
import { HomeComponent } from './components/home/home.component';

export const routes: Routes = [
    { path: '', component: HomeComponent, pathMatch: 'full' },
    { path: 'parking-area-form', component: ParkingAreaFormComponent },
    { path: 'management', component: ManagementComponent },
    { path: 'payment', component: PaymentComponent },
    { path: '**', redirectTo: '', pathMatch: 'full' }
];
