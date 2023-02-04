using Accountash.Application.Services.AppServices;
using Accountash.Domain.AppEntities;
using MediatR;

namespace Accountash.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany
{
    public sealed class CreateCompanyHandler : IRequestHandler<CreateCompanyRequest, CreateCompanyResponse>
    {
        private readonly ICompanyService _companyService;

        public CreateCompanyHandler(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public async Task<CreateCompanyResponse> Handle(CreateCompanyRequest request, CancellationToken cancellationToken)
        {
            Company company = await _companyService.GetCompanyByName(request.Name);
            if (company != null) throw new Exception("This company name has been used before!");

            await _companyService.CreateCompany(request);
            return new();
        }
    }
}
