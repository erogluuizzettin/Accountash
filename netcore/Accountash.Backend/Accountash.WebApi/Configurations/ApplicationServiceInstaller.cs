using Accountash.Application;
using Accountash.Application.Behavior;
using FluentValidation;
using MediatR;

namespace Accountash.WebApi.Configurations
{
    public class ApplicationServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(typeof(AssemblyReference).Assembly);

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBahevior<,>));

            services.AddValidatorsFromAssembly(typeof(AssemblyReference).Assembly);
        }
    }
}
