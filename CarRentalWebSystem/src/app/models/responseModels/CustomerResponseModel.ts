import { Customer } from '../Customer';
import { ResponseModel } from './ResponseModel';

export interface CustomerResponseModel extends ResponseModel {
  data: Customer[];
}
