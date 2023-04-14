using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Data.Items;
using Sitecore.Globalization;
using System;
using System.Collections.Generic;

namespace Pasantes.Website.Models.GlassMapper
{
    /// <summary>
    /// Base Glass Mapper Item Interface.
    /// </summary>
    public interface IBaseItem
    {
        /// <summary>
        /// Id
        /// </summary>
        [SitecoreId]
        Guid Id { get; }

        /// <summary>
        /// Item Name
        /// </summary>
        [SitecoreInfo(SitecoreInfoType.Name)]
        string ItemName { get; set; }

        /// <summary>
        /// Language
        /// </summary>
        [SitecoreInfo(SitecoreInfoType.Language)]
        Language Language { get; }

        /// <summary>
        /// Item
        /// </summary>
        [SitecoreItem]
        Item Item { get; set; }

        /// <summary>
        /// Version
        /// </summary>
        [SitecoreInfo(SitecoreInfoType.Version)]
        int Version { get; set; }

        /// <summary>
        /// Gets or sets template id.
        /// </summary>
        /// <value>string</value>
        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        Guid TemplateId { get; set; }

        /// <summary>
        /// Item URL
        /// </summary>
        [SitecoreInfo(SitecoreInfoType.Url)]
        string Url { get; }

        /// <summary>
        /// Gets or sets template name.
        /// </summary>
        /// <value>string</value>
        string TemplateName { get; set; }

        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        /// <value>string</value>
        string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets full path.
        /// </summary>
        /// <value>string</value>
        string FullPath { get; set; }

        /// <summary>
        /// Gets or sets updated Date.
        /// </summary>
        /// <value>string</value>
        DateTime Updated { get; set; }

        /// <summary> 
        /// Gets or sets base template Id. 
        /// </summary> 
        /// <value>Object Return.</value> 
        IEnumerable<Guid> BaseTemplateIds
        {
            get;
            set;
        }
    }
}
