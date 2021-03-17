import { ResponseModel } from './ResponseModel';
export interface ListResponseModel<T> extends ResponseModel {
  data: T[];
}
