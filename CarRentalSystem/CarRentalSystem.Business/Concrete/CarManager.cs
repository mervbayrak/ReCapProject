using CarRentalSystem.Business.Abstract;
using CarRentalSystem.DataAccess.Abstract;
using CarRentalSystem.Entities.Concrete;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using CarRentalSystem.Business.ValidationRules.FluentValidation;
using FluentValidation.Results;

namespace CarRentalSystem.Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        CarValidator validator;
        public CarManager(ICarDal carDal)
        {
            validator = new CarValidator();
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            ValidationResult result = validator.Validate(car);
            if (result.IsValid)
                _carDal.Add(car);
            else
                Console.WriteLine(result.Errors.FirstOrDefault().ErrorMessage);
        }

        public void Update(Car car)
        {
            ValidationResult result = validator.Validate(car);
            if (result.IsValid)
                _carDal.Update(car);
            else
                Console.WriteLine(result.Errors.FirstOrDefault().ErrorMessage);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public Car GetById(int id)
        {
            return _carDal.Get(m => m.Id == id);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetList();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetList(m => m.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetList(m => m.ColorId == colorId);
        }
    }
}
