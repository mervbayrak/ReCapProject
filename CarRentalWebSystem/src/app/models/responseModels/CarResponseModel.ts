import { Car } from '../Car';
import { ResponseModel } from './ResponseModel';

export interface CarResponseModel extends ResponseModel {
  data: Car[];
}
