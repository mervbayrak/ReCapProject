import { CarImages } from '../CarImages';
import { ResponseModel } from './ResponseModel';

export interface CarImagesResponseModel extends ResponseModel {
  data: CarImages[];
}
