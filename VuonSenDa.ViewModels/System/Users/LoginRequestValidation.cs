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
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is Not Empty");
        }
    }
}