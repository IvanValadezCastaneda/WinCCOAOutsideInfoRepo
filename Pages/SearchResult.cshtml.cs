using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WinCCOAOutsideInfoRepo.Data; // Add this line to include the namespace

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

            foreach (var page in RazorPageData.Pages)
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
}
