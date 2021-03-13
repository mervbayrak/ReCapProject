import { Color } from '../Color';
import { ResponseModel } from './ResponseModel';

export interface ColorResponseModel extends ResponseModel {
  data: Color[];
}
