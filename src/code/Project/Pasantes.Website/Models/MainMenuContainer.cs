using System.Collections.Generic;
using BaseItem = Pasantes.Website.Models.GlassMapper.BaseItem;

namespace Pasantes.Website.Models
{
    public interface MainMenuContainer : BaseItem
    {
         List<MainMenu> MenuOptions  { get; set; }
    }
}