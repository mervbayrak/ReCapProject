using CarRentalSystem.Core.Utilities.Results;
using CarRentalSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSystem.Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(CarImage carImage);
        IResult Update(CarImage carImage);
        IResult Delete(CarImage carImage);
        IDataResult<CarImage> GetById(int id);
        IDataResult<List<CarImage>> GetAll();
    }
}
