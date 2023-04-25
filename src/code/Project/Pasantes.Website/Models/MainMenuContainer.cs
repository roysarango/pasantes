using System.Collections.Generic;
using BaseItem = Pasantes.Website.Models.GlassMapper.BaseItem;

namespace Pasantes.Website.Models
{
    public class MainMenuContainer : BaseItem
    {
        public virtual List<MainMenu> MenuOptions  { get; set; }
    }
}