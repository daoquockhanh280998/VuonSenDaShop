using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace VuonSenDa.ViewModels.System.Users
{
    public class LoginRequestValidation : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidation()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("User Name is Not Empty");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is Not Empty")
                .MinimumLength(3).WithMessage("Password must not be less than 3 characters")
                .MaximumLength(6).WithMessage("Password must not exceed 6 characters");
        }
    }
}