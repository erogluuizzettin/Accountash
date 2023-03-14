using Accountash.Application.Features.AppFeatures.AppUserFeatures.Login;
using Accountash.Presentation.BaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Accountash.Presentation.Controller;

public class AuthController : ApiController
{
    public AuthController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> Login(LoginCommand request)
    {
        LoginCommandResponse response = await _mediator.Send(request);
        return Ok(response);
    }
}
