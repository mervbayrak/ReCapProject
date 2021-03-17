import { Component, OnInit } from '@angular/core';
import { Brand } from 'src/app/models/Brand';
import { Car } from 'src/app/models/Car';
import { Color } from 'src/app/models/Color';
import { BrandService } from 'src/app/services/brand.service';
import { CarService } from 'src/app/services/car.service';
import { ColorService } from 'src/app/services/color.service';

@Component({
  selector: 'app-car',
  templateUrl: './car.component.html',
  styleUrls: ['./car.component.css'],
})
export class CarComponent implements OnInit {
  constructor(
    private carService: CarService,
    private colorService: ColorService,
    private brandService: BrandService
  ) {}
  cars: Car[];
  colors: Color[];
  brands: Brand[];
  colorId: number;
  brandId: number;
  ngOnInit(): void {
    this.getCars();
    this.getColors();
    this.getBrands();
  }

  getCars() {
    this.carService.getCars().subscribe((response) => {
      this.cars = response.data;
    });
  }
  getColors() {
    this.colorService.getColors().subscribe((response) => {
      this.colors = response.data;
    });
  }
  getBrands() {
    this.brandService.getBrands().subscribe((response) => {
      this.brands = response.data;
    });
  }
  brandFilter(event: any) {
    this.brandId = event.target.value;
  }
  colorFilter(event: any) {
    this.colorId = event.target.value;
  }
}
