using Glass.Mapper.Sc.Fields;
using Pasantes.Website.Models.GlassMapper;

namespace Pasantes.Website.Models
{
    public interface ImageInList : BaseItem
    {
         Image Image { get; set; }

         string Description { get; set; }

         Link Link { get; set; }
    }
}