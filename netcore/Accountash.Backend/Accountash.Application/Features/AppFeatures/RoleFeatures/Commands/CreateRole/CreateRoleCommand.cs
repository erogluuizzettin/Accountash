using Accountash.Application.Messaging;

namespace Accountash.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;

public sealed record CreateRoleCommand(
    string Code,
    string Name) : ICommand<CreateRoleCommandResponse>;
