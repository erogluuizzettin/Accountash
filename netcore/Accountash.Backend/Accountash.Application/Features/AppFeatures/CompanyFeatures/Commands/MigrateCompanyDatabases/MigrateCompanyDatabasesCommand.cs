using Accountash.Application.Messaging;
using MediatR;

namespace Accountash.Application.Features.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabase
{
    public sealed record MigrateCompanyDatabasesCommand() : ICommand<MigrateCompanyDatabasesCommandResponse>;
}
