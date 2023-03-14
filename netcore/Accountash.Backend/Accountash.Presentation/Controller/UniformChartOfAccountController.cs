using Accountash.Application.Features.CompanyFeatures.UniformChartOfAccountFeatures.Commands.CreateUniformChartOfAccount;
using Accountash.Presentation.BaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Accountash.Presentation.Controller;

public sealed class UniformChartOfAccountController : ApiController
{
    public UniformChartOfAccountController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> CreateUniformChartOfAccount(CreateUniformChartOfAccountCommand request, CancellationToken cancellationToken)
    {
        CreateUniformChartOfAccountCommandResponse response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}
