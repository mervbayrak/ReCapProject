using CarRentalSystem.Business.Abstract;
using CarRentalSystem.Business.Constants;
using CarRentalSystem.Business.ValidationRules.FluentValidation;
using CarRentalSystem.Core.Utilities.Results;
using CarRentalSystem.DataAccess.Abstract;
using CarRentalSystem.Entities.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRentalSystem.Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        BrandValidator validator;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
            validator = new BrandValidator();
        }

        public IResult Add(Brand brand)
        {
            ValidationResult result = validator.Validate(brand);
            if (!result.IsValid)
            {
                return new ErrorResult(result.Errors.FirstOrDefault().ErrorMessage);
            }

            _brandDal.Add(brand);

            return new SuccessResult(Messages.Added);
        }

        public IResult Update(Brand brand)
        {
            ValidationResult result = validator.Validate(brand);
            if (!result.IsValid)
            {
                return new ErrorResult(result.Errors.FirstOrDefault().ErrorMessage);
            }

            _brandDal.Update(brand);

            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(Brand brand)
        {
            ValidationResult result = validator.Validate(brand);
            if (!result.IsValid)
            {
                return new ErrorResult(result.Errors.FirstOrDefault().ErrorMessage);
            }

            _brandDal.Delete(brand);

            return new SuccessResult(Messages.Deleted);
        }


        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetList());
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(m => m.Id == id));
        }

        
    }
}
