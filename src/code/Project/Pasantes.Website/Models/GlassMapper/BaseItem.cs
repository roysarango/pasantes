using System;
using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Data.Items;
using Sitecore.Globalization;

namespace Pasantes.Website.Models.GlassMapper
{
    public interface BaseItem : IBaseItem
    {

        

      

        [SitecoreInfo(SitecoreInfoType.Version)]
        int Version { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        Guid TemplateId { get; set; }

        [SitecoreInfo(SitecoreInfoType.Url)]
        string Url { get;  set; }

         string TemplateName { get; set; }

         string DisplayName { get; set; }

        string FullPath { get; set; }

         DateTime Updated { get; set; }

         IEnumerable<Guid> BaseTemplateIds { get; set; }
    }
}