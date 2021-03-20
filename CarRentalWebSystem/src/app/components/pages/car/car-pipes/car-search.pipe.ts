import { Pipe, PipeTransform } from '@angular/core';
import { Car } from 'src/app/models/Car';

@Pipe({
  name: 'carSearch',
})
export class CarSearchPipe implements PipeTransform {
  transform(value: Car[], filterText: string): Car[] {
    filterText = filterText ? filterText.toLocaleLowerCase() : '';
    return filterText
      ? value.filter(
          (p: Car) => p.name.toLocaleLowerCase().indexOf(filterText) !== -1
        )
      : value;
  }
}
