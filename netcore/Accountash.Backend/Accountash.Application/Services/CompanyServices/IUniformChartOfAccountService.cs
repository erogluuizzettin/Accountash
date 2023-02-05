using Accountash.Application.Features.CompanyFeatures.UniformChartOfAccountFeatures.Commands.CreateUniformChartOfAccount;
using Accountash.Domain.CompanyEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountash.Application.Services.CompanyServices
{
    public interface IUniformChartOfAccountService
    {
        Task CreateUniformChartOfAccountAsync(CreateUniformChartOfAccountRequest request);
    }
}
