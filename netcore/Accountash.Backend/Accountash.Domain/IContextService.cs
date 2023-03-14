using Microsoft.EntityFrameworkCore;

namespace Accountash.Domain;

public interface IContextService
{
    DbContext CreateDbContextInstance(string companyId);
}
