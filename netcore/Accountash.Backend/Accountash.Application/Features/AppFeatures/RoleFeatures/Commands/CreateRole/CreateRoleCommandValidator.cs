using FluentValidation;

namespace Accountash.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;

public sealed class CreateRoleCommandValidator : AbstractValidator<CreateRoleCommand>
{
	public CreateRoleCommandValidator()
	{
		RuleFor(x => x.Code).NotEmpty().WithMessage("Role Code cannot be ampty.");
		RuleFor(x => x.Code).NotNull().WithMessage("Role Code cannot be empty.");
		RuleFor(x => x.Name).NotEmpty().WithMessage("Role Name cannot be empty.");
		RuleFor(x => x.Name).NotNull().WithMessage("Role Name cannot be empty.");
    }
}
