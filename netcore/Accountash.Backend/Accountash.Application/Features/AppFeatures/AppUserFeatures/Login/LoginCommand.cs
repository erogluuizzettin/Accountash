using Accountash.Application.Messaging;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountash.Application.Features.AppFeatures.AppUserFeatures.Login
{
    public sealed record LoginCommand(
        string EMailOrUserName, 
        string Password) : ICommand<LoginCommandResponse>;
}
