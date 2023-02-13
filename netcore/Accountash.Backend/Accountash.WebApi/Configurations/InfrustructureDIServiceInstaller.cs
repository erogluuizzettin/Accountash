
using Accountash.Application.Abstractions;
using Accountash.Infrastructure.Authentication;

namespace Accountash.WebApi.Configurations
{
    public class InfrustructureDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IJwtProvider, JwtProvider>();
        }
    }
}
