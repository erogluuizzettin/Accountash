using System.Reflection;

namespace Accountash.WebApi.Configurations;

public static class DependecyInjection
{
    public static IServiceCollection InstallServices(
            this IServiceCollection services,
            IConfiguration configuration,
            params Assembly[] assemblies
        )
    {
        IEnumerable<IServiceInstaller> serviceInstallers = assemblies
            .SelectMany(x => x.DefinedTypes)
            .Where(IsAssignableToTypes<IServiceInstaller>)
            .Select(Activator.CreateInstance)
            .Cast<IServiceInstaller>();

        foreach (IServiceInstaller serviceInstaller in serviceInstallers)
        {
            serviceInstaller.Install(services, configuration);
        }

        return services;

        static bool IsAssignableToTypes<T>(TypeInfo typeInfo) =>
            typeof(T).IsAssignableFrom(typeInfo) &&
            !typeInfo.IsInterface &&
            !typeInfo.IsAbstract;
    }
}
