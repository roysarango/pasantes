using Glass.Mapper.Sc;
using Sitecore.Data;

namespace Pasantes.Website.Services.GlassMapper
{
    /// <summary>
    /// Service Factory for IoC injection of Glass Mapper Sitecore Service
    /// </summary>
    public interface ISitecoreServiceFactory
    {
        /// <summary>
        /// Create an instance of ISitecoreService.
        /// </summary>
        /// <param name="db"></param>
        /// <param name="sitecoreDb"></param>
        /// <returns></returns>
        ISitecoreService CreateInstance(ContextDb db = ContextDb.NotSet, Database sitecoreDb = null);

        /// <summary>
        /// Create an instance of ISitecoreService.
        /// </summary>
        /// <param name="sitecoreDb"></param>
        /// <returns></returns>
        ISitecoreService CreateInstance(Database sitecoreDb);
    }

    public enum ContextDb
    {
        NotSet,
        Master,
        Web,
        Custom,
        Preview
    }
}
