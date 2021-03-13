import { Rental } from '../Rental';
import { ResponseModel } from './ResponseModel';

export interface RentalResponseModel extends ResponseModel {
  data: Rental[];
}
