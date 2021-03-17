import { ResponseModel } from './ResponseModel';

export interface ItemResponseModel<T> extends ResponseModel {
  data: T;
}
