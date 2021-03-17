import { Brand } from './Brand';
import { CarImages } from './CarImages';
import { Color } from './Color';

export class Car {
  id: number;
  name: string;
  modelYear: number;
  dailyPrice: string;
  description: string;
  carImages: CarImages[];
  brand: Brand;
  color: Color;
}
