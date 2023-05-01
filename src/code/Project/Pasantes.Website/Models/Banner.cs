using Glass.Mapper.Sc.Fields;
using Pasantes.Website.Models.GlassMapper;

namespace Pasantes.Website.Models
{
    public class Banner : BaseItem
    {
        public virtual Image Image { get; set; }

        public virtual string Title { get; set; }

        public virtual string Description { get; set; }
    }
}