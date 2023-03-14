﻿using Accountash.Domain.CompanyEntities;
using Accountash.Domain.Repositories.UniformChartOfAccountRepository;

namespace Accountash.Persistance.Repositories.UniformChartOfAccountRepository;

public sealed class UniformChartOfAccountCommandRepository : CommandRepository<UniformChartOfAccount>, IUniformChartOfAccountCommandRepository
{
}
