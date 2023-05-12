using Pasantes.Website.Models.GlassMapper;
using System.Collections.Generic;

namespace Pasantes.Website.Models
{
    public interface ImageList : BaseItem
    {
          IList<ImageInList> Images { get; set; }

          string Title { get; set; }
    }
}