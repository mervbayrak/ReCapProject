using CarRentalSystem.DataAccess.Abstract;
using CarRentalSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CarRentalSystem.DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>();
            CarListFill();
        }

        public void CarListFill()
        {
            _cars.Add(new Car() { Id = 1, ModelYear = "2019", DailyPrice = "5000", Description = "Citroen C3 Otomatik", Brand = new Brand { Id = 1, BrandName = "Citroen" }, BrandId = 1, Color = new Color { Id = 1, ColorName = "Black" }, ColorId = 1 });
            _cars.Add(new Car() { Id = 2, ModelYear = "2020", DailyPrice = "5000", Description = "Hyundai i20 Otomatik", Brand = new Brand { Id = 2, BrandName = "Hyundai" }, BrandId = 2, Color = new Color { Id = 1, ColorName = "Black" }, ColorId = 1 });
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Add(carToDelete);
        }
        public void Update(Car car)
        {
            var carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
        public Car GetById(int id)
        { 
            return _cars.Where(m => m.Id == id).FirstOrDefault();
        }

        public List<Car> GetList()
        {
            return  _cars.ToList();
        }

    }
}
