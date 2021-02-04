using CarRentalSystem.Core.DataAccess.EntityFramework;
using CarRentalSystem.DataAccess.Abstract;
using CarRentalSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSystem.DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfRepository<CarRentalDbContext, Color>, IColorDal
    {
    }
}
