using Glass.Mapper.Sc.Fields;
using Pasantes.Website.Models.GlassMapper;

namespace Pasantes.Website.Models
{
    public interface TitleAndText : BaseItem
    {
        string Title { get; set; }

        string Text { get; set; }

        Image Image1 { get; set; }
    }
}