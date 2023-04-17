using Glass.Mapper.Sc.Fields;
using Pasantes.Website.Models.GlassMapper;

namespace Pasantes.Website.Models
{
    public class TitleAndText : BaseItem
    {
        public virtual string Title { get; set; }

        public virtual string Text { get; set; }

        public virtual Image Image1 { get; set; }
    }
}