namespace WinCCOAOutsideInfoRepo.Data
{
    public static class RazorPageData
    {
        public static List<RazorPageInfo> Pages = new List<RazorPageInfo>
        {
            new RazorPageInfo
            {
                Title = "System Information",
                Content = "Explore tips and tricks for managing system information.",
                Url = "/SystemInfo",
                Excerpt = "Explore tips and tricks for managing system information."
            },
            new RazorPageInfo
            {
                Title = "Word Wrap Trick",
                Content = "Learn how to handle word wrap in your WinCC OA project.",
                Url = "/WordWrap",
                Excerpt = "Learn how to handle word wrap in your WinCC OA project."
            },
            // Add more pages here
        };
    }

    public class RazorPageInfo
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Url { get; set; }
        public string Excerpt { get; set; }
    }
}
