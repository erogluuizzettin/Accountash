using Accountash.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using Accountash.Domain.AppEntities;

namespace Accountash.Application.Services.AppServices
{
    public interface ICompanyService
    {
        Task CreateCompany(CreateCompanyRequest request);
        Task MigrateCompanyDatabases();
        Task<Company?> GetCompanyByName(string name);
    }
}
