using Accountash.Application.Services.AppServices;
using Accountash.Domain.AppEntities.Identity;
using MediatR;

namespace Accountash.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole;

public sealed class UpdateRoleCommandHandler : IRequestHandler<UpdateRoleCommand, UpdateRoleCommandResponse>
{
    private readonly IRoleService _roleService;

    public UpdateRoleCommandHandler(IRoleService roleService)
    {
        _roleService = roleService;
    }

    public async Task<UpdateRoleCommandResponse> Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
    {
        AppRole role = await _roleService.GetByIdAsync(request.Id);

        if (role == null) throw new Exception("Role not found.");

        if (role.Code != request.Code && await _roleService.CheckCode(request.Code))
        {
            throw new Exception("This code has been saved before.");
        }

        role.Code = request.Code;
        role.Name = request.Name;
        await _roleService.UpdateAsync(role);
        return new();
    }
}
