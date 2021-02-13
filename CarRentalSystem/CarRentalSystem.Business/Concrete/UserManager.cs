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
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        UserValidator validator;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
            validator = new UserValidator();
        }

        public IResult Add(User user)
        {
            ValidationResult result = validator.Validate(user);
            if (!result.IsValid)
            {
                return new ErrorResult(result.Errors.FirstOrDefault().ErrorMessage);
            }

            _userDal.Add(user);

            return new SuccessResult(Messages.Added);
        }

        public IResult Update(User user)
        {
            ValidationResult result = validator.Validate(user);
            if (!result.IsValid)
            {
                return new ErrorResult(result.Errors.FirstOrDefault().ErrorMessage);
            }

            _userDal.Update(user);

            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(User user)
        {
            ValidationResult result = validator.Validate(user);
            if (!result.IsValid)
            {
                return new ErrorResult(result.Errors.FirstOrDefault().ErrorMessage);
            }

            _userDal.Delete(user);

            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetList());
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(m => m.Id == id));
        }

       
    }
}
