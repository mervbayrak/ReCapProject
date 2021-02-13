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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        CustomerValidator validator;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
            validator = new CustomerValidator();
        }

        public IResult Add(Customer customer)
        {
            ValidationResult result = validator.Validate(customer);
            if (!result.IsValid)
            {
                return new ErrorResult(result.Errors.FirstOrDefault().ErrorMessage);
            }

            _customerDal.Add(customer);

            return new SuccessResult(Messages.Added);
        }

        public IResult Update(Customer customer)
        {
            ValidationResult result = validator.Validate(customer);
            if (!result.IsValid)
            {
                return new ErrorResult(result.Errors.FirstOrDefault().ErrorMessage);
            }

            _customerDal.Update(customer);

            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(Customer customer)
        {
            ValidationResult result = validator.Validate(customer);
            if (!result.IsValid)
            {
                return new ErrorResult(result.Errors.FirstOrDefault().ErrorMessage);
            }

            _customerDal.Delete(customer);

            return new SuccessResult(Messages.Deleted);
        }


        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetList());
        }

        public IDataResult<Customer> GetById(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(m => m.Id == id));
        }

       
    }
}
