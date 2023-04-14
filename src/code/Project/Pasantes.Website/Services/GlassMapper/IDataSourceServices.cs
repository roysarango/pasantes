using Pasantes.Website.Models.GlassMapper;
using System;

namespace Pasantes.Website.Services.GlassMapper
{
    /// <summary>
    /// Data source Service. 
    /// </summary>
    public interface IDataSourceServices
    {
        /// <summary>
        /// Checks if data source exits and return its Guid.
        /// </summary>
        /// <param name="dataSource"></param>
        /// <param name="dataSourceId"></param>
        /// <returns></returns>
        bool GetDataSourceGuid(string dataSource, out Guid dataSourceId);

        /// <summary>
        /// Get rendering parameters.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parameters"></param>
        /// <returns></returns>
        T GetRenderingParameters<T>(string parameters)
            where T : BaseItem;
    }
}
