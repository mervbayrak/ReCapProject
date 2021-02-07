using CarRentalSystem.Core.DataAccess.EntityFramework;
using CarRentalSystem.DataAccess.Abstract;
using CarRentalSystem.Entities.Concrete;
using CarRentalSystem.Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CarRentalSystem.DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfRepository<CarRentalDbContext, Car>, ICarDal
    {
        public virtual List<Car> GetList(Expression<Func<Car, bool>> filter = null)
        {
            using (var context = new CarRentalDbContext())
            {
                return filter == null
                    ? context.Set<Car>().Include(x=>x.Brand).Include(x => x.Color).ToList()
                    : context.Set<Car>().Include(x => x.Brand).Include(x => x.Color).Where(filter).ToList();
            }
        }
        public virtual List<CarDetailDto> GetProductDetails()
        {
            using (var context = new CarRentalDbContext())
            {
                return context.Set<Car>().Include(x => x.Brand).Include(x => x.Color).Select(
                    x => new CarDetailDto
                    {
                        CarName = x.Name,
                        BrandName = x.Brand.Name,
                        ColorName= x.Color.Name,
                        DailyPrice = x.DailyPrice
                    }).ToList();
            }
        }
    }
}
