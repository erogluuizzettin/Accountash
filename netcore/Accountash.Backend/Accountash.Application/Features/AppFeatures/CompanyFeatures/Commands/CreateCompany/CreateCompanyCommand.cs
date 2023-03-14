using Accountash.Application.Messaging;

namespace Accountash.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;

public sealed record CreateCompanyCommand(
    string Name,
    string ServerName,
    string DatabaseName,
    string DbUserId,
    string DbPassword) : ICommand<CreateCompanyCommandResponse>;
