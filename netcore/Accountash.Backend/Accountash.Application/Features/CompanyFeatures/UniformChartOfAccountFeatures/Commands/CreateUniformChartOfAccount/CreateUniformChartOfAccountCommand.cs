using Accountash.Application.Messaging;

namespace Accountash.Application.Features.CompanyFeatures.UniformChartOfAccountFeatures.Commands.CreateUniformChartOfAccount;

public sealed record CreateUniformChartOfAccountCommand(
    string Code,
    string Name,
    string Type,
    string CompanyId) : ICommand<CreateUniformChartOfAccountCommandResponse>;
