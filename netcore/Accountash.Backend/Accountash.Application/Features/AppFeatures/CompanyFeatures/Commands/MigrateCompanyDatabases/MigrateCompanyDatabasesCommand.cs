using Accountash.Application.Messaging;

namespace Accountash.Application.Features.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabase;

public sealed record MigrateCompanyDatabasesCommand() : ICommand<MigrateCompanyDatabasesCommandResponse>;
