using ShamiEmployeeMangement.Repositories.Interface;
using ShamiEmployeeMangement.Repositories;
using ShamiEmployeeMangement.Services.Interface;
using ShamiEmployeeMangement.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ShamiEmployeeMangement.ConfigureServices
{
    public static class ServiceConfiguration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAccountService, AccountService>();
        }
    }
}
