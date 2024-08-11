using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;

namespace ShamiEmployeeMangement.Databaseconnectivity
{
    public static class DBConfig
    {
        public static void AddDatabaseConfiguration(this IServiceCollection services,IConfiguration configuration)
        { 
        services.AddDbContext<EmployeeShamContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DevConnection")));
        }

    }
}
