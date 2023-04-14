using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Mvc;
using Pasantes.Website.Models.GlassMapper;
using System;

namespace Pasantes.Website.Services.GlassMapper
{
    /// <summary>
    ///     DataSource Services
    /// </summary>
    public class DataSourceServices : IDataSourceServices
    {
        protected readonly ISitecoreService SitecoreService;

        protected readonly IMvcContext MvcContext;

        public DataSourceServices(ISitecoreServiceFactory sitecoreService, IMvcContext mvcContext)
        {
            MvcContext = mvcContext;
            SitecoreService = sitecoreService.CreateInstance();
        }

        /// <summary>
        ///     Get DataSource Id
        /// </summary>
        /// <param name="dataSource"></param>
        /// <param name="dataSourceId"></param>
        /// <returns></returns>
        public bool GetDataSourceGuid(string dataSource, out Guid dataSourceId)
        {
            dataSourceId = Guid.Empty;
            return dataSource != null && Guid.TryParse(dataSource, out dataSourceId) && dataSourceId != Guid.Empty;
        }

        /// <summary>
        ///     Cast Rendering Parameters to type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public T GetRenderingParameters<T>(string parameters) where T : BaseItem
        {
            return MvcContext.GlassHtml.GetRenderingParameters<T>(MvcContext.RenderingParameters);
        }
    }
}