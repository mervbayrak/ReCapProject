import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './components/nav/nav.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { SidebarComponent } from './components/sidebar/sidebar.component';
import { HttpClientModule } from '@angular/common/http';
import { CarComponent } from './components/pages/car/car.component';
import { RentalComponent } from './components/pages/rental/rental.component';
import { CarFilterPipe } from './components/pages/car/car-pipes/car-filter.pipe';
import { CarDetailComponent } from './components/pages/car/car-detail/car-detail.component';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    DashboardComponent,
    SidebarComponent,
    CarComponent,
    RentalComponent,
    CarFilterPipe,
    CarDetailComponent,
  ],
  imports: [BrowserModule, AppRoutingModule, HttpClientModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
