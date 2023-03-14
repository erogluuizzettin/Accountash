using Accountash.Application.Messaging;

namespace Accountash.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole;

public sealed record DeleteRoleCommand(
    string Id) : ICommand<DeleteRoleCommandResponse>;
