using CarRentalSystem.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSystem.Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(m => m.ReturnDate == null); // Araba teslim edilmemiş demektir. Add ve delete işlemi yapılamaz.
        }
    }
}
