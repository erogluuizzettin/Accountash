using FluentValidation;

namespace Accountash.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;

public sealed class CreateCompanyCommandValidator : AbstractValidator<CreateCompanyCommand>
{
	public CreateCompanyCommandValidator()
	{
		RuleFor(x => x.DatabaseName).NotEmpty().WithMessage("Database Name cannot be empty.");
		RuleFor(x => x.DatabaseName).NotNull().WithMessage("Database Name cannot be empty.");
        RuleFor(x => x.ServerName).NotEmpty().WithMessage("Server Name cannot be empty.");
        RuleFor(x => x.ServerName).NotNull().WithMessage("Server Name cannot be empty.");
		RuleFor(x => x.Name).NotEmpty().WithMessage("Company Name cannot be empty.");
		RuleFor(x => x.Name).NotNull().WithMessage("Company Name cannot be empty.");
    }
}
