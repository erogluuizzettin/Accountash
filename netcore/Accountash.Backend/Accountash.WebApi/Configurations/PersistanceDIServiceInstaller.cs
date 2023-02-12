using Accountash.Application.Services.AppServices;
using Accountash.Application.Services.CompanyServices;
using Accountash.Domain;
using Accountash.Domain.Repositories.UniformChartOfAccountRepository;
using Accountash.Persistance;
using Accountash.Persistance.Repositories.UniformChartOfAccountRepository;
using Accountash.Persistance.Services.AppServices;
using Accountash.Persistance.Services.CompanyServices;

namespace Accountash.WebApi.Configurations
{
    public class PersistanceDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            #region Context UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IContextService, ContextService>();
            #endregion

            #region Services
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IUniformChartOfAccountService, UniformChartOfAccountService>();
            #endregion

            #region Repositories
            services.AddScoped<IUniformChartOfAccountCommandRepository, UniformChartOfAccountCommandRepository>();
            services.AddScoped<IUniformChartOfAccountQueryRepository, UniformChartOfAccountQueryRepository>();
            #endregion
        }
    }
}
