using Accountash.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using Accountash.Application.Features.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabase;
using Accountash.Presentation.BaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Accountash.Presentation.Controller;

public class CompanyController : ApiController
{
    public CompanyController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> CreateCompany(CreateCompanyCommand request, CancellationToken cancellationToken)
    {
        CreateCompanyCommandResponse response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> MigrateCompanyDatabases()
    {
        MigrateCompanyDatabasesCommand request = new();
        MigrateCompanyDatabasesCommandResponse response = await _mediator.Send(request);
        return Ok(response);
    }
}
