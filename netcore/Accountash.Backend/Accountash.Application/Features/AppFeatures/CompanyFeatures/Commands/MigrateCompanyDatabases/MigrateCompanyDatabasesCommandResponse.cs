namespace Accountash.Application.Features.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabase
{
    public sealed record MigrateCompanyDatabasesCommandResponse(
        string Message = "The database information of the companies was migrated.");
}
