using Pasantes.Website.Models.GlassMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pasantes.Website.Models
{
    public class CreatedBy: BaseItem
    {
        public virtual string Copyright { get; set; }
        public virtual string Author { get; set; }
    }
}