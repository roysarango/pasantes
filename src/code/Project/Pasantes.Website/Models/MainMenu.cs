using Glass.Mapper.Sc.Fields;
using Pasantes.Website.Models.GlassMapper;

namespace Pasantes.Website.Models
{
    public interface MainMenu : BaseItem
    {
        string Title { get; set; }

         Link Link { get; set; }
    }
}