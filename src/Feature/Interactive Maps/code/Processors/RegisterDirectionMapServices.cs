using Hackathon.Feature.InteractiveMaps.Controllers;
using Hackathon.Feature.InteractiveMaps.Models;
using Hackathon.Feature.InteractiveMaps.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;


namespace Hackathon.Feature.InteractiveMaps.Processors
{
    public class RegisterDependencies : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IDirectionMapRepository, DirectionMapRepository>();
            serviceCollection.AddTransient<InteractiveMapsController>();
        }
    }
}

