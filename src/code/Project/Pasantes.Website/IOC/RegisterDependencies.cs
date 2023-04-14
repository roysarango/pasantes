using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Pasantes.Website.Controller;
using Pasantes.Website.Services.GlassMapper;
using Sitecore.DependencyInjection;

namespace Pasantes.Website.IOC
{
    public class RegisterDependencies : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            // Sitecore Service Factory.
            serviceCollection.AddScoped<ISitecoreServiceFactory, SitecoreServiceFactory>();

            // Services
            serviceCollection.AddTransient<IDataSourceServices, DataSourceServices>();
            serviceCollection.AddTransient<IRenderingService, RenderingService>();


            // Controllers.
            serviceCollection.AddTransient<DefaultController>();

            // GlassMapper Services.
            serviceCollection.AddTransient<IGlassHtml>(provider =>
                new GlassHtml(new SitecoreServiceFactory().CreateInstance()));

            serviceCollection.AddTransient<IMvcContext>(provider =>
                new MvcContext(new SitecoreServiceFactory().CreateInstance(),
                    new GlassHtml(new SitecoreServiceFactory().CreateInstance())));

            serviceCollection.AddScoped(provider => new SitecoreServiceFactory().CreateInstance());
        }
    }
}