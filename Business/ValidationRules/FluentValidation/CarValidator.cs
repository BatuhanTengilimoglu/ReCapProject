using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(car => car.ColorId).NotEmpty();
            RuleFor(car => car.BrandId).NotEmpty();
            RuleFor(car => car.DailyPrice).NotEmpty();
            RuleFor(car => car.DailyPrice).GreaterThan(0);
            RuleFor(car => car.Description).NotEmpty();
            RuleFor(car => car.Description).MaximumLength(40);
            RuleFor(car => car.ModelYear).NotEmpty();
            RuleFor(car => car.ModelYear).Length(4, 4);
            RuleFor(car => car.ModelYear).Matches(@"^[0 - 9] *$");
        }

     
    }
}
