using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Google.Protobuf.WellKnownTypes;
using Pasantes.Website.Models.GlassMapper;

namespace Pasantes.Website.Models
{
    public class TitleAndText : BaseItem
    {
        public virtual string Title { get; set; }

        public virtual string Text { get; set; }
        [SitecoreField("Image 1")]
        public virtual Image Image { get; set; }
    }
}