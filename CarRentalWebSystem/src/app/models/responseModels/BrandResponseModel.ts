import { Brand } from '../Brand';
import { ResponseModel } from './ResponseModel';

export interface BrandResponseModel extends ResponseModel {
  data: Brand[];
}
