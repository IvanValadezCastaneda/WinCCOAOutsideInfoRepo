using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WinCCOAOutsideInfoRepo.Data;

namespace WinCCOAOutsideInfoRepo.Pages
{   
    public class SearchResultModel : PageModel
    {

        [BindProperty(SupportsGet = true)]
        public string Query { get; set; }

        
        public List<RazorPageInfo> SearchResults { get; set; }

        public void OnGet()
        {
            SearchResults = GetSearchResults(Query);
        }

        private List<RazorPageInfo> GetSearchResults(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                return new List<RazorPageInfo>();
            }

            var results = new List<RazorPageInfo>();

            foreach (var page in YourRazorPageCollection)
            {
                if (page.Content.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                    page.Title.Contains(query, StringComparison.OrdinalIgnoreCase))
                {
                    results.Add(page);
                }
            }

            return results;
        }
        
    }
    public class RazorPageInfo
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Url { get; set; }
        public string Excerpt { get; set; }
    }

}