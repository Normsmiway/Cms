namespace Cms.Api.Core
{
    public static class ServiceCompositionRoot
    {
        private static IServiceCollection _services;

        public static void Set(IServiceCollection services)
        {
            _services = services;
        }
        public static IServiceScope BeginLifetimeScope()
        {
            var provider = _services.BuildServiceProvider(new ServiceProviderOptions() { ValidateScopes = true, ValidateOnBuild = true });
            return provider.CreateScope();
        }
    }
}
