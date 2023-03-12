using Accountash.Application.Messaging;
using Accountash.Application.Services.AppServices;
using Accountash.Domain.AppEntities.Identity;
using MediatR;

namespace Accountash.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole
{
    public sealed class DeleteRoleCommandHandler : ICommandHandler<DeleteRoleCommand, DeleteRoleCommandResponse>
    {
        private readonly IRoleService _roleService;

        public DeleteRoleCommandHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<DeleteRoleCommandResponse> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
        {
            AppRole role = await _roleService.GetByIdAsync(request.Id);
            if (role == null) throw new Exception("Role not found.");

            await _roleService.DeleteAsync(role);
            return new();
        }
    }
}
