using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(rental => rental.CarId).NotNull();
            RuleFor(rental => rental.CustomerId).NotNull();
            RuleFor(rental => rental.RentDate).NotNull();
        }
    }
}
