using Sitecore.Pipelines;
using System.Web.Http;
using System.Web.Routing;

namespace Pasantes.Website.Infrastructure
{
    public class RegisterServicesApiRoutes
    {

        public void Process(PipelineArgs args)
        {
            RegisterRoute(RouteTable.Routes);
        }

        protected virtual void RegisterRoute(RouteCollection routes)
        {
            routes.MapHttpRoute("APAServicesApiRoute",
                "sitecore/api/{controller}/{action}"
            );
        }
    }
}