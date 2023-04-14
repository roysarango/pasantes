using Glass.Mapper.Sc;
using System;
using System.Linq;
using Sitecore;
using Sitecore.Data;
using System.Collections.Generic;

namespace Pasantes.Website.Services.GlassMapper
{
    public class SitecoreServiceFactory : ISitecoreServiceFactory
    {

        public static IEnumerable<string> Sites = new[]
        {
            "admin", "login", "modules_shell", "modules_website",
            "publisher", "service", "shell", "system", "testing"
        };

        public ISitecoreService CreateInstance(ContextDb db = ContextDb.NotSet, Database sitecoreDb = null)
        {
            try
            {
                var systemSites = Sites.ToList();
                if (db == ContextDb.Custom && sitecoreDb == null)
                {
                    db = ContextDb.NotSet;
                }

                if (sitecoreDb != null)
                {
                    db = ContextDb.Custom;
                }

                switch (db)
                {
                    case ContextDb.Master:
                        return new SitecoreService(Databases.MasterDb);
                    case ContextDb.Web:
                        return new SitecoreService(Databases.WebDb);
                    case ContextDb.Custom:
                        return new SitecoreService(sitecoreDb);
                    case ContextDb.NotSet:
                    case ContextDb.Preview:
                    default:
                        if (Context.Site == null)
                            return new SitecoreService(Database.GetDatabase(Databases.WebDb));

                        if (systemSites.Contains(Context.Site.Name) ||
                            Context.PageMode.IsExperienceEditor ||
                            Context.PageMode.IsPreview)
                            return new SitecoreService(Database.GetDatabase(Databases.MasterDb));

                        return new SitecoreService(Database.GetDatabase(Context.Site.Database == null ?
                            Databases.MasterDb :
                            Context.Site.Database.Name));
                }
            }
            catch (Exception)
            {
                if (Context.Database != null)
                {
                    throw;
                }

                return null;
            }
        }

        public ISitecoreService CreateInstance(Database sitecoreDb)
        {
            return CreateInstance(ContextDb.Custom, sitecoreDb);
        }

        public struct Databases
        {
            public const string MasterDb = "master";
            public const string WebDb = "web";
            public const string CoreDb = "core";
        }
    }
}