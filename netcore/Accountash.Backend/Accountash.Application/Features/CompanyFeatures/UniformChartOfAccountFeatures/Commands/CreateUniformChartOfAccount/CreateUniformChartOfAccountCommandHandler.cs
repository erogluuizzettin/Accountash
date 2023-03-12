using Accountash.Application.Messaging;
using Accountash.Application.Services.CompanyServices;

namespace Accountash.Application.Features.CompanyFeatures.UniformChartOfAccountFeatures.Commands.CreateUniformChartOfAccount
{
    public sealed class CreateUniformChartOfAccountCommandHandler : ICommandHandler<CreateUniformChartOfAccountCommand, CreateUniformChartOfAccountCommandResponse>
    {
        private readonly IUniformChartOfAccountService _uniformChartOfAccountService;

        public CreateUniformChartOfAccountCommandHandler(IUniformChartOfAccountService uniformChartOfAccountService)
        {
            _uniformChartOfAccountService = uniformChartOfAccountService;
        }

        public async Task<CreateUniformChartOfAccountCommandResponse> Handle(CreateUniformChartOfAccountCommand request, CancellationToken cancellationToken)
        {
            await _uniformChartOfAccountService.CreateUniformChartOfAccountAsync(request);
            return new();
        }
    }
}
