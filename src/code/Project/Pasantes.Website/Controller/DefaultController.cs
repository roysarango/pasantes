using System.Web.Mvc;

namespace Pasantes.Website.Controller
{
    public class DefaultController : System.Web.Mvc.Controller
    {
        public ActionResult Sample()
        {
            return View("~/Views/Sample.cshtml");
        }
    }
}