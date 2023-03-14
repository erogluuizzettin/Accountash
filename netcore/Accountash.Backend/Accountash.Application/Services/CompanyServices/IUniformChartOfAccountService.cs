using Accountash.Application.Features.CompanyFeatures.UniformChartOfAccountFeatures.Commands.CreateUniformChartOfAccount;

namespace Accountash.Application.Services.CompanyServices;

public interface IUniformChartOfAccountService
{
    Task CreateUniformChartOfAccountAsync(CreateUniformChartOfAccountCommand request, CancellationToken cancellationToken);
}
