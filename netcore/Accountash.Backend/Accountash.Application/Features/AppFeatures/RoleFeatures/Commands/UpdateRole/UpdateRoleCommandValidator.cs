using FluentValidation;

namespace Accountash.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole;

public sealed class UpdateRoleCommandValidator : AbstractValidator<UpdateRoleCommand>
{
	public UpdateRoleCommandValidator()
	{
        RuleFor(x => x.Id).NotEmpty().WithMessage("Id cannot be empty.");
        RuleFor(x => x.Id).NotNull().WithMessage("Id cannot be empty.");
        RuleFor(x => x.Code).NotEmpty().WithMessage("Role Code cannot be ampty.");
        RuleFor(x => x.Code).NotNull().WithMessage("Role Code cannot be empty.");
        RuleFor(x => x.Name).NotEmpty().WithMessage("Role Name cannot be empty.");
        RuleFor(x => x.Name).NotNull().WithMessage("Role Name cannot be empty.");
    }
}
