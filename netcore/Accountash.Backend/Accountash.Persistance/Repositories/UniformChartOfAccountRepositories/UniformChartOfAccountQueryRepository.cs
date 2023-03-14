using Accountash.Domain.CompanyEntities;
using Accountash.Domain.Repositories.UniformChartOfAccountRepository;

namespace Accountash.Persistance.Repositories.UniformChartOfAccountRepository;

public sealed class UniformChartOfAccountQueryRepository : QueryRepository<UniformChartOfAccount>, IUniformChartOfAccountQueryRepository
{
}
