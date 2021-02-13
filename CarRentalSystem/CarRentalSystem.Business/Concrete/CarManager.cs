using CarRentalSystem.Business.Abstract;
using CarRentalSystem.DataAccess.Abstract;
using CarRentalSystem.Entities.Concrete;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using CarRentalSystem.Business.ValidationRules.FluentValidation;
using FluentValidation.Results;
using CarRentalSystem.Entities.DTOs;
using CarRentalSystem.Core.Utilities.Results;
using CarRentalSystem.Business.Constants;

namespace CarRentalSystem.Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        CarValidator validator;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
            validator = new CarValidator();
        }

        public IResult Add(Car car)
        {
            ValidationResult result = validator.Validate(car);
            if (!result.IsValid)
            {
                return new ErrorResult(result.Errors.FirstOrDefault().ErrorMessage);
            }

            _carDal.Add(car);

            return new SuccessResult(Messages.Added);
        }

        public IResult Update(Car car)
        {
            ValidationResult result = validator.Validate(car);
            if (!result.IsValid)
            {
                return new ErrorResult(result.Errors.FirstOrDefault().ErrorMessage);
            }

            _carDal.Update(car);

            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(Car car)
        {
            ValidationResult result = validator.Validate(car);
            if (!result.IsValid)
            {
                return new ErrorResult(result.Errors.FirstOrDefault().ErrorMessage);
            }

            _carDal.Delete(car);

            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(m => m.Id == id));
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetList());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetList(m => m.BrandId == brandId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetList(m => m.ColorId == colorId));
        }

        public IDataResult<List<CarDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetProductDetails());
        }
    }
}
