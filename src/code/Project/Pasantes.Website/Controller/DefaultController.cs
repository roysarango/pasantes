using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Mvc;
using Pasantes.Website.Models;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Pasantes.Website.Controller
{
    public class DefaultController : System.Web.Mvc.Controller
    {
        private readonly ISitecoreService _sitecoreService;
        private readonly IMvcContext _mvcContext;

        public DefaultController(ISitecoreService sitecoreService, IMvcContext mvcContext)
        {
            _sitecoreService = sitecoreService;
            _mvcContext = mvcContext;
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
            var model = _mvcContext.GetDataSourceItem<TitleAndText>();

            return View("~/Views/TitleAndTextGlassMapper.cshtml", model);
        }

        public ActionResult MainMenu()
        {
            var mainMenuContainer = _mvcContext.GetDataSourceItem<MainMenuContainer>();

            var menuOptions = new List<MainMenu>();

            if (mainMenuContainer.Item.Children != null)
            {
                foreach (Item item in mainMenuContainer.Item.GetChildren())
                {
                    if (item.TemplateID.ToString().ToUpper() == "{3F5A16EC-3C44-40B9-A066-D0C806F3CB8A}")
                    {
                        var menuOption = _sitecoreService.GetItem<MainMenu>(item);

                        menuOptions.Add(menuOption);
                    }
                }
            }

            mainMenuContainer.MenuOptions = menuOptions;

            return View("~/Views/MainMenu.cshtml", mainMenuContainer);
        }


        public ActionResult Banner()
        {
            var item = _mvcContext.GetDataSourceItem<Banner>();

            return View("~/Views/Banner.cshtml", item);
        }


        public ActionResult ImageList()
        {
            var imageListContainer = _mvcContext.GetDataSourceItem<ImageList>();

            /*var imagesInList = new List<ImageInList>();

            if (imageListContainer.Item.Children != null)
            {
                foreach (Item item in imageListContainer.Item.GetChildren())
                {
                    
                        var image = _sitecoreService.GetItem<ImageInList>(item);

                        imagesInList.Add(image);
                }
            }

            imageListContainer.Images = imagesInList;*/

            return View("~/Views/ImageList.cshtml", imageListContainer);
        }
    }
}