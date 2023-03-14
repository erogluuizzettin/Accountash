using FluentValidation;

namespace Accountash.Application.Features.CompanyFeatures.UniformChartOfAccountFeatures.Commands.CreateUniformChartOfAccount;

public sealed class CreateUniformChartOfAccountCommandValidator : AbstractValidator<CreateUniformChartOfAccountCommand>
{
	public CreateUniformChartOfAccountCommandValidator()
	{
		RuleFor(x => x.Code).NotEmpty().WithMessage("Code cannot be empty.");
		RuleFor(x => x.Code).NotNull().WithMessage("Code cannot be empty.");
		RuleFor(x => x.Code).MinimumLength(4).WithMessage("Code must be at least 4 characters.");
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty.");
        RuleFor(x => x.Name).NotNull().WithMessage("Name cannot be empty.");
        RuleFor(x => x.CompanyId).NotEmpty().WithMessage("Company Id cannot be empty.");
        RuleFor(x => x.CompanyId).NotNull().WithMessage("Company Id cannot be empty.");
        RuleFor(x => x.Type).NotEmpty().WithMessage("Type cannot be empty.");
        RuleFor(x => x.Type).NotNull().WithMessage("Type cannot be empty.");
        RuleFor(x => x.Type).MaximumLength(1).WithMessage("Type must be 1 character.");
    }
}
