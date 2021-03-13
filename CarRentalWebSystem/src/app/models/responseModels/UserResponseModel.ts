import { User } from '../User';
import { ResponseModel } from './ResponseModel';

export interface UserResponseModel extends ResponseModel {
  data: User[];
}
