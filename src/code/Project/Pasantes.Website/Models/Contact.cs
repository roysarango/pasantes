using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Pasantes.Website.Models.GlassMapper;


namespace Pasantes.Website.Models
{
    public class Contact: BaseItem
    {
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual string City { get; set; }
        public virtual string Country { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Email { get; set; }
        public virtual string Address { get; set; }
        [SitecoreField("Location Icon")]
        public virtual Image IconLocation { get; set; }
        [SitecoreField("Phone Icon")]
        public virtual Image IconPhone { get; set; }
        [SitecoreField("Email Icon")]
        public virtual Image IconEmail { get; set; }

    }
}