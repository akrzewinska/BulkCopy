using System.Configuration;
using BulkCopy.Domain.Repository;
using BulkCopy.Infrastructure.EF;
using BulkCopy.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BulkCopy.Api.IoC
{
    public static class ApiInfrastructure
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddEntityFrameworkNpgsql().AddDbContext<SampleDbContext>(opt =>
                opt.UseNpgsql(configuration.GetConnectionString("SampleDb")));

            services.AddTransient<ISomeRepository, SomeRepository>();
            services.AddTransient<SampleDbContext>();
            return services;
        }

        public static IServiceCollection AddApplications(this IServiceCollection services)
        {
            return services;
        }
    }


}