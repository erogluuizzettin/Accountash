namespace Accountash.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole;

public sealed record DeleteRoleCommandResponse(
    string Message = "The role was successfully deleted.");
