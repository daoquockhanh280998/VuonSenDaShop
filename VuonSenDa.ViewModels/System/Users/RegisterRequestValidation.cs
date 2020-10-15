using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace VuonSenDa.ViewModels.System.Users
{
    public class RegisterRequestValidation : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidation()
        {
            RuleFor(x => x.FistName).NotEmpty().WithMessage("FistName is Not Empty")
                .MaximumLength(200).WithMessage("FistName must not exceed 200 characters");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("LastName is Not Empty")
                .MaximumLength(200).WithMessage("LastName must not exceed 200 characters");
            RuleFor(x => x.DOB).NotEmpty().WithMessage("Birthday is Not Empty")
                .GreaterThan(DateTime.Now.AddYears(-100)).WithMessage("Birthday cannot greater then 100 years");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is Not Empty")
                 .Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")
                 .WithMessage("Email format not match");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Phone Number is Not Empty");

            RuleFor(x => x.UserName).NotEmpty().WithMessage("User Name is Not Empty");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is Not Empty")
                .MinimumLength(3).WithMessage("Password must not be less than 3 characters")
                .MaximumLength(6).WithMessage("Password must not exceed 6 characters");
            RuleFor(x => x).Custom((request, context) =>
            {
                if (request.Password != request.ConfirmPassword)
                {
                    context.AddFailure("Confirm Password is not match");
                }
            });
        }
    }
}