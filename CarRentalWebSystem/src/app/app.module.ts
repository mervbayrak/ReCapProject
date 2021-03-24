import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

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
import { CarSearchPipe } from './components/pages/car/car-pipes/car-search.pipe';

import { ToastrModule } from 'ngx-toastr';
import { CarAddComponent } from './components/pages/car/car-add/car-add.component';

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
    CarSearchPipe,
    CarAddComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot({
      positionClass: 'toast-bottom-right',
    }),
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
