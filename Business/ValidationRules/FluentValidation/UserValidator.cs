using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(user => user.FirstName).NotEmpty();
            RuleFor(user => user.FirstName).Matches(@"^[a-zA-Z]+$");
            RuleFor(user => user.FirstName).Length(2,50);
            RuleFor(user => user.LastName).NotEmpty();
            RuleFor(user => user.LastName).Matches(@"^[a-zA-Z]+$");
            RuleFor(user => user.LastName).Length(2, 50);
            RuleFor(user => user.Password).NotEmpty();
            RuleFor(user => user.Password).Length(8, 50);
            RuleFor(user => user.Password).Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$");
            RuleFor(user => user.Email).EmailAddress();
        }
    }
}
