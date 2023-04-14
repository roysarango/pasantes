using Pasantes.Website.Models.GlassMapper;
using System;

namespace Pasantes.Website.Services.GlassMapper
{
    /// <summary>
    /// Rendering Service.
    /// </summary>
    public interface IRenderingService
    {
        string DataSource { get; }
        string Parameters { get; }
        Guid? DataSourceId { get; }

        /// <summary>
        /// Gets rendering parameters.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T GetRenderingParameters<T>() where T : BaseItem;

        /// <summary>
        /// Gets data source.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T GetDataSource<T>() where T : BaseItem;
    }
}
