using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidation : AbstractValidator<Customer>
    {
        public CustomerValidation()
        {
            RuleFor(customer => customer.CompanyName).MaximumLength(100);
            RuleFor(customer => customer.UserId).NotNull();
        }
    }
}
