import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { CarAddComponent } from './components/pages/car/car-add/car-add.component';
import { CarDetailComponent } from './components/pages/car/car-detail/car-detail.component';
import { CarComponent } from './components/pages/car/car.component';
import { RentalComponent } from './components/pages/rental/rental.component';

const routes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'home', component: DashboardComponent },
  { path: 'car', component: CarComponent },
  { path: 'caradd', component: CarAddComponent },
  { path: 'rental', component: RentalComponent },
  { path: 'car/details/:carId', component: CarDetailComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
