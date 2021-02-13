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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        ColorValidator validator;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
            validator = new ColorValidator();
        }
        public IResult Add(Color color)
        {
            ValidationResult result = validator.Validate(color);
            if (!result.IsValid)
            {
                return new ErrorResult(result.Errors.FirstOrDefault().ErrorMessage);
            }

            _colorDal.Add(color);

            return new SuccessResult(Messages.Added);
        }

        public IResult Update(Color color)
        {
            ValidationResult result = validator.Validate(color);
            if (!result.IsValid)
            {
                return new ErrorResult(result.Errors.FirstOrDefault().ErrorMessage);
            }

            _colorDal.Update(color);

            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(Color color)
        {
            ValidationResult result = validator.Validate(color);
            if (!result.IsValid)
            {
                return new ErrorResult(result.Errors.FirstOrDefault().ErrorMessage);
            }

            _colorDal.Delete(color);

            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetList());
        }

        public IDataResult<Color> GetById(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(m => m.Id == id));
        }
      
    }
}
