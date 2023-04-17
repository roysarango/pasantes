using Sitecore.Mvc.Presentation;
using System.Web.Mvc;
using Pasantes.Website.Models;
using Pasantes.Website.Services.GlassMapper;

namespace Pasantes.Website.Controller
{
    public class DefaultController : System.Web.Mvc.Controller
    {
        private readonly IRenderingService _renderingService;

        public DefaultController(IRenderingService renderingService)
        {
            _renderingService = renderingService;
        }

        public ActionResult Sample()
        {
            return View("~/Views/Sample.cshtml");
        }

        public ActionResult TitleAndText()
        {
            var dataSourceId = RenderingContext.CurrentOrNull.Rendering.DataSource;

            var item = Sitecore.Context.Database.GetItem(dataSourceId);

            return View("~/Views/TitleAndText.cshtml", item);
        }

        public ActionResult TitleAndTextGlassMapper()
        {
            var item = _renderingService.GetDataSource<TitleAndText>();

            return View("~/Views/TitleAndTextGlassMapper.cshtml", item);
        }
    }
}