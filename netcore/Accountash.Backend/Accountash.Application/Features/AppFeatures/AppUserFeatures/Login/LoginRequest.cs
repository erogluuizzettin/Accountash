using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountash.Application.Features.AppFeatures.AppUserFeatures.Login
{
    public sealed class LoginRequest : IRequest<LoginResponse>
    {
        public string EMailOrUserName { get; set; }
        public string Password { get; set; }
    }
}
