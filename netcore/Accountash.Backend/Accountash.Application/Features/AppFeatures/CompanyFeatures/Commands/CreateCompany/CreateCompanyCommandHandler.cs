using Accountash.Application.Messaging;
using Accountash.Application.Services.AppServices;
using Accountash.Domain.AppEntities;

namespace Accountash.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;

public sealed class CreateCompanyCommandHandler : ICommandHandler<CreateCompanyCommand, CreateCompanyCommandResponse>
{
    private readonly ICompanyService _companyService;

    public CreateCompanyCommandHandler(ICompanyService companyService)
    {
        _companyService = companyService;
    }

    public async Task<CreateCompanyCommandResponse> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
    {
        Company company = await _companyService.GetCompanyByName(request.Name);
        if (company != null) throw new Exception("This company name has been used before!");

        await _companyService.CreateCompany(request, cancellationToken);
        return new();
    }
}
