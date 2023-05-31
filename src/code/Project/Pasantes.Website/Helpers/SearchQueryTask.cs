using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Linq.Utilities;
using Sitecore.ContentSearch.SearchTypes;
using System.Collections.Generic;
using System.Linq;

namespace Pasantes.Website.Helpers
{
    public class SearchQueryTask
    {
        public List<SearchResultItem> GetSearchResultItem(string term)
        {
            var index = ContentSearchManager.GetIndex($"sitecore_{Sitecore.Context.Database}_index");

            using (var context = index.CreateSearchContext())
            {
                var predicate = PredicateBuilder.True<SearchResultItem>();
                predicate = predicate.And(i => i.Path.StartsWith("/sitecore/content/Pasantes/Home"));
                predicate = predicate.And(i => i.Content.Contains(term));
                predicate = predicate.And(i => i["_latestversion"].Equals("1"));
                predicate = predicate.And(i => i.Language == "en");

                var searchResultItem = context.GetQueryable<SearchResultItem>().Where(predicate);
                return searchResultItem.ToList();
            }
        }
    }
}