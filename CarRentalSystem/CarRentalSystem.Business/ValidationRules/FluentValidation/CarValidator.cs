using CarRentalSystem.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSystem.Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.Name).MinimumLength(2).WithMessage("Araba ismi minimum 2 karakter olmalıdır");
            RuleFor(p => p.DailyPrice).GreaterThan(0).WithMessage("Araba günlük fiyatı 0'dan büyük olmalıdır.");
        }
    }
}
