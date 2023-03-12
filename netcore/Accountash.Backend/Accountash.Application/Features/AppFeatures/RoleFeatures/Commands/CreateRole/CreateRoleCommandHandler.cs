using Accountash.Application.Messaging;
using Accountash.Application.Services.AppServices;
using Accountash.Domain.AppEntities.Identity;

namespace Accountash.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole
{
    public sealed class CreateRoleCommandHandler : ICommandHandler<CreateRoleCommand, CreateRoleCommandResponse>
    {
        private readonly IRoleService _roleService;

        public CreateRoleCommandHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<CreateRoleCommandResponse> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
        {
            AppRole role = await _roleService.GetByCodeAsync(request.Code);
            if (role != null) throw new Exception("This role has already been registered!");

            await _roleService.AddAsync(request);
            return new();
        }
    }
}
