using Accountash.Application.Messaging;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountash.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany
{
    public sealed record CreateCompanyCommand(
        string Name,
        string ServerName,
        string DatabaseName,
        string DbUserId,
        string DbPassword) : ICommand<CreateCompanyCommandResponse>;
}
