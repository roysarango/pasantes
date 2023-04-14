using System;
using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Data.Items;
using Sitecore.Globalization;

namespace Pasantes.Website.Models.GlassMapper
{
    public abstract class BaseItem : IBaseItem
    {
        [SitecoreId]
        public virtual Guid Id { get; private set; }

        [SitecoreInfo(SitecoreInfoType.Name)]
        public virtual string ItemName { get; set; }

        [SitecoreInfo(SitecoreInfoType.Language)]
        public virtual Language Language { get; }

        [SitecoreItem]
        public virtual Item Item { get; set; }

        [SitecoreInfo(SitecoreInfoType.Version)]
        public virtual int Version { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        public virtual Guid TemplateId { get; set; }

        [SitecoreInfo(SitecoreInfoType.Url)]
        public virtual string Url { get; private set; }

        public virtual string TemplateName { get; set; }

        public virtual string DisplayName { get; set; }

        public virtual string FullPath { get; set; }

        public virtual DateTime Updated { get; set; }

        public virtual IEnumerable<Guid> BaseTemplateIds { get; set; }
    }
}