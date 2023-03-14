using FluentValidation;

namespace Accountash.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole;

public sealed class DeleteRoleCommandValidator : AbstractValidator<DeleteRoleCommand>
{
	public DeleteRoleCommandValidator()
	{
		RuleFor(x => x.Id).NotEmpty().WithMessage("Id cannot be empty.");
		RuleFor(x => x.Id).NotNull().WithMessage("Id cannot be empty.");
    }
}
