using Glass.Mapper.Sc.Fields;
using Pasantes.Website.Models.GlassMapper;

namespace Pasantes.Website.Models
{
    public class MainMenu : BaseItem
    {
        public virtual string Title { get; set; }

        public virtual Link Link { get; set; }
    }
}