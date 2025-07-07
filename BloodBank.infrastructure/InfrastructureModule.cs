using BloodBank.Core.Respositories;
using BloodBank.infrastructure.Persistence;
using BloodBank.infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace BloodBank.infrastructure
{
    public static class InfrastructureModule
    {

        public static IServiceCollection AddInfrastructure(this IServiceCollection service, IConfiguration configuratios)
        {
            service
                .AddRepositories(configuratios)
                .AddData(configuratios);

            return service;
        }

        private static IServiceCollection AddData(this IServiceCollection service, IConfiguration configuratio)
        {
            var connectString = configuratio.GetConnectionString("BloodbankCs");

            service.AddDbContext<BloodBankDbContext>(o => o.UseSqlServer(connectString));

            return service;
        }

        private static IServiceCollection AddRepositories (this IServiceCollection service, IConfiguration configuration)
        {
            service.AddScoped<IDonorRespository, DonorRepository>();
            service.AddScoped<IAddressRepository, AddressRepository>();
            service.AddScoped<IDonationRepository, DonationRepository>();
            service.AddScoped<IBloodStockRepository, BloodStockRepository>();

            return service;
        }
    }
}
