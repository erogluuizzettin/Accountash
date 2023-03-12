using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountash.Application.Features.AppFeatures.AppUserFeatures.Login
{
    public sealed class LoginCommandValidator : AbstractValidator<LoginCommand>
    {
        public LoginCommandValidator()
        {
            RuleFor(x => x.EMailOrUserName).NotEmpty().WithMessage("EMail or User Name cannot be empty.");
            RuleFor(x => x.EMailOrUserName).NotNull().WithMessage("EMail or User Name cannot be empty.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password cannot be empty.");
            RuleFor(x => x.Password).NotNull().WithMessage("Password cannot be empty.");
            RuleFor(x => x.Password).MinimumLength(6).WithMessage("Password must be at least 6 characters.");
            RuleFor(x => x.Password).Matches("[A-Z]").WithMessage("Password must contain at least 1 capital letter.");
            RuleFor(x => x.Password).Matches("[a-z]").WithMessage("Password must contain at least 1 lowercase letter.");
            RuleFor(x => x.Password).Matches("[0-9]").WithMessage("Password must contain at least 1 number.");
            RuleFor(x => x.Password).Matches("[a-zA-Z0-9]").WithMessage("Password must contain at least 1 special character.");
        }
    }
}
