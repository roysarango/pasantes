using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Pasantes.Website.Models.GlassMapper;

namespace Pasantes.Website.Models
{
    public class SocialNetworks:BaseItem
    {
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }

        public virtual Link Link1 { get; set; }
        [SitecoreField("Link1 Icon")]
        public virtual Image IconLink1 { get; set; }
        public virtual Link Link2 { get; set; }
        [SitecoreField("Link2 Icon")]
        public virtual Image IconLink2 { get; set; }
        public virtual Link Link3 { get; set; }
        [SitecoreField("Link3 Icon")]
        public virtual Image IconLink3 { get; set; }
        public virtual Link Link4 { get; set; }
        [SitecoreField("Link4 Icon")]
        public virtual Image IconLink4 { get; set; }
    }
}