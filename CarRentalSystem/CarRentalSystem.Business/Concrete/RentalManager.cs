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
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        RentalValidator validator;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
            validator = new RentalValidator();
        }
        public IResult Add(Rental rental)
        {
            ValidationResult result = validator.Validate(rental);
            if (!result.IsValid)
            {
                return new ErrorResult(result.Errors.FirstOrDefault().ErrorMessage);
            }

            _rentalDal.Add(rental);

            return new SuccessResult(Messages.Added);
        }

        public IResult Update(Rental rental)
        {
            if (rental.ReturnDate != null)
            {
                return new ErrorResult();
            }
            rental.ReturnDate = DateTime.Now;
            _rentalDal.Update(rental);

            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(Rental rental)
        {
            ValidationResult result = validator.Validate(rental);
            if (!result.IsValid)
            {
                return new ErrorResult(result.Errors.FirstOrDefault().ErrorMessage);
            }

            _rentalDal.Delete(rental);

            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetList());
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(m => m.Id == id));
        }

       
    }
}
