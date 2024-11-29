using application;
using domain.Interfaces;
using infrastructure;
using infrastructure.Repository;

namespace web_api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddWebAPI(this IServiceCollection services)
        {
            return services;
        }
    }
}
