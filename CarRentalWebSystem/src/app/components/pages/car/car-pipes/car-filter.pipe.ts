import { Pipe, PipeTransform } from '@angular/core';
import { Car } from 'src/app/models/Car';
import { isArray } from 'src/app/utils/utils';

@Pipe({
  name: 'carFilter',
})
export class CarFilterPipe implements PipeTransform {
  transform(input: Car[], brandId: number = 0, colorId: number = 0): Car[] {
    if (brandId == 0) {
      if (colorId == 0) {
        return input;
      } else {
        return input.filter((c: Car) => c.color.id == colorId);
      }
    } else {
      if (colorId == 0) {
        return input.filter((c: Car) => c.brand.id == brandId);
      } else {
        return input.filter(
          (c: Car) => c.brand.id == brandId && c.color.id == colorId
        );
      }
    }
  }
}
