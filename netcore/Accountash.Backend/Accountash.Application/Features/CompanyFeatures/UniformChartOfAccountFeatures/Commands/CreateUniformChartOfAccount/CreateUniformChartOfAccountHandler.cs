using Accountash.Application.Services.CompanyServices;
using MediatR;

namespace Accountash.Application.Features.CompanyFeatures.UniformChartOfAccountFeatures.Commands.CreateUniformChartOfAccount
{
    public sealed class CreateUniformChartOfAccountHandler : IRequestHandler<CreateUniformChartOfAccountRequest, CreateUniformChartOfAccountResponse>
    {
        private readonly IUniformChartOfAccountService _uniformChartOfAccountService;

        public CreateUniformChartOfAccountHandler(IUniformChartOfAccountService uniformChartOfAccountService)
        {
            _uniformChartOfAccountService = uniformChartOfAccountService;
        }

        public async Task<CreateUniformChartOfAccountResponse> Handle(CreateUniformChartOfAccountRequest request, CancellationToken cancellationToken)
        {
            await _uniformChartOfAccountService.CreateUniformChartOfAccountAsync(request);
            return new();
        }
    }
}
