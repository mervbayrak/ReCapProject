using CarRentalSystem.Core.DataAccess;
using CarRentalSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSystem.DataAccess.Abstract
{
    public interface ICarImageDal : IRepository<CarImage>
    {
    }
}
