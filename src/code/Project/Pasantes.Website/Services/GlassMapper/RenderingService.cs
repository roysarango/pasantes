//using Glass.Mapper.Sc;
//using Pasantes.Website.Models.GlassMapper;
//using System;

//namespace Pasantes.Website.Services.GlassMapper
//{
//    /// <summary>
//    /// Injectable Rendering Context
//    /// </summary>
//    public class RenderingService : IRenderingService
//    {
//        protected readonly IDataSourceServices DataSourceServices;
//        protected readonly ISitecoreService SitecoreService;
//        public RenderingService(IDataSourceServices dataSourceServices,
//            ISitecoreServiceFactory sieSitecoreService)
//        {
//            DataSourceServices = dataSourceServices;
//            SitecoreService = sieSitecoreService.CreateInstance();
//        }

//        /// <summary>
//        /// Get DataSource ID
//        /// </summary>
//        public Guid? DataSourceId => DataSourceServices.GetDataSourceGuid(DataSource, out var dataSourceId)
//            ? (Guid?)dataSourceId
//            : null;

//        /// <summary>
//        /// Get Rendering Parameters as Glass object of type T
//        /// </summary>
//        /// <typeparam name="T"></typeparam>
//        /// <returns></returns>
//        public T GetRenderingParameters<T>() where T : BaseItem
//        {
//            return DataSourceServices.GetRenderingParameters<T>(Parameters);
//        }

//        /// <summary>
//        /// Get DataSource as Glass object of type T
//        /// </summary>
//        /// <typeparam name="T"></typeparam>
//        /// <returns></returns>
//        public T GetDataSource<T>() where T : BaseItem
//        {
//            return DataSourceId.HasValue ? SitecoreService.GetItem<T>(DataSourceId.Value) : null;
//        }

//        /// <summary>
//        /// Get Parameters
//        /// </summary>
//        public string Parameters => Sitecore.Mvc.Presentation.RenderingContext.CurrentOrNull?.Rendering != null
//            ? Sitecore.Mvc.Presentation.RenderingContext.Current.Rendering["Parameters"]
//            : null;

//        /// <summary>
//        /// Get DataSource
//        /// </summary>
//        /// <returns></returns>
//        public string DataSource => Sitecore.Mvc.Presentation.RenderingContext.CurrentOrNull?.Rendering?.Item != null
//        ? Sitecore.Mvc.Presentation.RenderingContext.Current.Rendering.Item?.ID.ToString()
//        : Guid.Empty.ToString();
//    }
//}
