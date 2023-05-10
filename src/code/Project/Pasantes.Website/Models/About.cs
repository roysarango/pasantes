
using Glass.Mapper.Sc.Fields;
using Pasantes.Website.Models.GlassMapper;

namespace Pasantes.Website.Models
{
    public class About: BaseItem
    {
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual Image Image { get; set; }

    }
}