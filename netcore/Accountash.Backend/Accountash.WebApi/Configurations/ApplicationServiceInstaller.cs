using Accountash.Application;
using MediatR;

namespace Accountash.WebApi.Configurations
{
    public class ApplicationServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(typeof(AssemblyReference).Assembly);
        }
    }
}
