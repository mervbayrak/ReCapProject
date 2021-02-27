using CarRentalSystem.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSystem.Business.ValidationRules.FluentValidation
{
    public class CarImageValidator : AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {

        }
    }
}
