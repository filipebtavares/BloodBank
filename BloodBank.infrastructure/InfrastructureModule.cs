using BloodBank.infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace BloodBank.infrastructure
{
    public static class InfrastructureModule
    {

        public static IServiceCollection AddInfrastructure(this IServiceCollection service, IConfiguration configuratios)
        {
            service.AddData(configuratios);

            return service;
        }

        private static IServiceCollection AddData(this IServiceCollection service, IConfiguration configuratio)
        {
            var connectString = configuratio.GetConnectionString("BloodbankDb");

            service.AddDbContext<BloodBankDbContext>(o => o.UseSqlServer(connectString));

            return service;
        }
    }
}
