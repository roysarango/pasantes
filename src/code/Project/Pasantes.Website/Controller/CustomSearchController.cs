using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Http;
using System.Web.Http.Results;
using Newtonsoft.Json;
using Pasantes.Website.Helpers;
using Sitecore.Data;
using Sitecore.Services.Infrastructure.Web.Http;

namespace Pasantes.Website.Controller
{
    public class CustomSearchController : ServicesApiController
    {
        [HttpGet]
        public IHttpActionResult Index()
        {
            var comment = new Result
            {
                Id = ID.NewID.ToGuid(),
                Term = "No terms have been searched!!!"
            };
            return new JsonResult<Result>(comment, new JsonSerializerSettings(), Encoding.UTF8, this);
        }

        [HttpGet]
        public IHttpActionResult Index(string term)
        {
            var query = new SearchQueryTask();

            var results = query.GetSearchResultItem(term);

            var comment = new Result
            {
                Id = ID.NewID.ToGuid(),
                Term = $"Searched term: {term}",
                ResultItems = new List<ResultItem>()
            };

            foreach (var result in results)
            {
                comment.ResultItems.Add(
                    new ResultItem
                    {
                        Id = result.ItemId.ToString(), 
                        Path = result.Path,
                        Content = result.Fields["title_t"].ToString(),
                    });
            }


            return new JsonResult<Result>(comment, new JsonSerializerSettings(), Encoding.UTF8, this);
        }
    }

    public class Result
    {
        public Guid Id { get; set; }
        public string Term { get; set; }
        public List <ResultItem> ResultItems { get; set; }
    }

    public class ResultItem
    {
        public string Id { get; set; }
        public string Path { get; set; }

        public string Content { get; set; }
    }
}