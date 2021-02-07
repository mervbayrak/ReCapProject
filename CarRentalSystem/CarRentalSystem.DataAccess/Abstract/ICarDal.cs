using CarRentalSystem.Core.DataAccess;
using CarRentalSystem.Entities.Concrete;
using CarRentalSystem.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSystem.DataAccess.Abstract
{
    public interface ICarDal : IRepository<Car>
    {
        List<CarDetailDto> GetProductDetails();
    }
}
