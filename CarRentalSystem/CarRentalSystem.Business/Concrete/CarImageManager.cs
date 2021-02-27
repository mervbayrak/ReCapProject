using CarRentalSystem.Business.Abstract;
using CarRentalSystem.Business.Constants;
using CarRentalSystem.Business.ValidationRules.FluentValidation;
using CarRentalSystem.Core.Aspects.Autofac.Validation;
using CarRentalSystem.Core.Utilities.Business;
using CarRentalSystem.Core.Utilities.Results;
using CarRentalSystem.DataAccess.Abstract;
using CarRentalSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSystem.Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }
        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(CarImage carImage)
        {
            var result = BusinessRules.Run(CheckIfImageCountOfCarCorrect(carImage.CarId));

            if (!result.Success)
            {
                return result;
            }

            _carImageDal.Add(carImage);

            return new SuccessResult();
        }
        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Update(CarImage carImage)
        {
            var result = BusinessRules.Run(CheckIfImageCountOfCarCorrect(carImage.CarId));

            if (!result.Success)
            {
                return result;
            }

            _carImageDal.Update(carImage);

            return new SuccessResult();
        }
        public IResult Delete(CarImage carImage)
        {
            _carImageDal.Delete(carImage);

            return new SuccessResult();
        }

        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(m => m.Id == id));
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetList());
        }

        //Business Rules
        private IResult CheckIfImageCountOfCarCorrect(int carId)
        {
            var result = _carImageDal.GetList(m => m.CarId == carId).Count;
            if (result >= 5)
            {
                return new ErrorResult(Messages.ImageCountOfCarError);
            }
            return new SuccessResult();
        }

    }
}
