﻿using Glass.Mapper.Sc.Fields;
using Pasantes.Website.Models.GlassMapper;

namespace Pasantes.Website.Models
{
    public interface Banner : BaseItem
    {
        Image Image { get; set; }

        string Title { get; set; }

         string Description { get; set; }
    }
}