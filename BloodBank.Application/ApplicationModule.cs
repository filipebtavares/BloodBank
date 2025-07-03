
using BloodBank.Application.Commands.InsertDonor;
using Microsoft.Extensions.DependencyInjection;

namespace BloodBank.Application
{
    public static class ApplicationModule
    {

        public static IServiceCollection AddAplication(this IServiceCollection service)
        {
            service.AddHandlers();

            return service;
        }

        private static IServiceCollection AddHandlers(this IServiceCollection service)
        {
            service.AddMediatR(config =>
            config.RegisterServicesFromAssemblyContaining<CreateDonorCommand>());

            return service;
        }
    }
}
