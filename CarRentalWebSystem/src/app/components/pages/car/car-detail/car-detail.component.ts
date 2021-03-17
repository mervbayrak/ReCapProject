import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Car } from 'src/app/models/Car';
import { CarService } from 'src/app/services/car.service';

@Component({
  selector: 'app-car-detail',
  templateUrl: './car-detail.component.html',
  styleUrls: ['./car-detail.component.css'],
})
export class CarDetailComponent implements OnInit {
  constructor(
    private carService: CarService,
    private activatedRouter: ActivatedRoute
  ) {}
  car: Car;
  categoryId: number;
  ngOnInit(): void {
    this.getCar();
  }

  getCar() {
    this.activatedRouter.params.subscribe((params) => {
      this.categoryId = params['carId'];
      this.carService.getCar(this.categoryId).subscribe((response) => {
        this.car = response.data;
      });
    });
  }
}
