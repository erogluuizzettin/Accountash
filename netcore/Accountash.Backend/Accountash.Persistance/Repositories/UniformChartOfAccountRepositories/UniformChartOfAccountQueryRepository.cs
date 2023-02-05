using Accountash.Domain.CompanyEntities;
using Accountash.Domain.Repositories.UniformChartOfAccountRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountash.Persistance.Repositories.UniformChartOfAccountRepository
{
    public sealed class UniformChartOfAccountQueryRepository : QueryRepository<UniformChartOfAccount>, IUniformChartOfAccountQueryRepository
    {
    }
}
