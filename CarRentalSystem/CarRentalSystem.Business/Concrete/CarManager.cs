using CarRentalSystem.Business.Abstract;
using CarRentalSystem.DataAccess.Abstract;
using CarRentalSystem.Entities.Concrete;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSystem.Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public Car GetById(int id)
        {
            return _carDal.GetById(id);
        }
        public List<Car> GetAll()
        {
            return _carDal.GetList();
        }

        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }
    }
}
