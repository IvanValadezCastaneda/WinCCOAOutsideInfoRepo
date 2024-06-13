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
    new RazorPageInfo
    {
        Title = "Dollar Parameter Validation Trick",
        Content = "Discover how to effectively manage dollar parameter validation.",
        Url = "/DollarParameterValidation",
        Excerpt = "Discover how to effectively manage dollar parameter validation."
    },
    new RazorPageInfo
    {
        Title = "Introduction to Structs in WinCC OA",
        Content = "A brief explainer of how to use Structs in WinCC OA and examples to use.",
        Url = "/StructInfo",
        Excerpt = "A brief explainer of how to use Structs in WinCC OA and examples to use."
    },
    new RazorPageInfo
    {
        Title = "Extended Function Parameters Info",
        Content = "Check what extra options can you use for Function Parameters",
        Url = "/FunctionParameters",
        Excerpt = "Check what extra options can you use for Function Parameters."
    },
    new RazorPageInfo
    {
        Title = "Get Redundant and Distributed System Status",
        Content = "Check the Status of Redundant and Distributed Systems Connected to your WinCC OA Project",
        Url = "/GetDistandReduSystems",
        Excerpt = "Check the Status of Redundant and Distributed Systems Connected to your WinCC OA Project."
    },
    new RazorPageInfo
    {
        Title = "Tips for OOP $-Parameters in Runtime",
        Content = "Tips that can Streamline OOP in WinCC OA using Dollar Parameters",
        Url = "/RuntimeTips",
        Excerpt = "Tips that can Streamline OOP in WinCC OA using Dollar Parameters."
    },
    new RazorPageInfo
    {
        Title = "Getters and Setters for Properties in Panels",
        Content = "Easy to use Getters and Setters for Properties set in the Graphical Elements",
        Url = "/GetterandSetterProperties",
        Excerpt = "Easy to use Getters and Setters for Properties set in the Graphical Elements."
    },
    new RazorPageInfo
    {
        Title = "Troubleshooting and Debugging",
        Content = "Adopt best practices for effective troubleshooting and debugging.",
        Url = "/Debugging",
        Excerpt = "Adopt best practices for effective troubleshooting and debugging."
    },
    new RazorPageInfo
    {
        Title = "Function that returns the Data Types Accordingly",
        Content = "Data Type Checking of variables in a better way",
        Url = "/isDataType",
        Excerpt = "Data Type Checking of variables in a better way."
    },
    new RazorPageInfo
    {
        Title = "SQL Query Construction",
        Content = "A basic Overview of how to introduce SQL Queries in WinCC OA",
        Url = "/SQLQueries",
        Excerpt = "A basic Overview of how to introduce SQL Queries in WinCC OA."
    },
    new RazorPageInfo
    {
        Title = "Conversion to Time from JSON",
        Content = "A quick script that you can use to convert a JSON back into time",
        Url = "/TimeConversionJSON",
        Excerpt = "A quick script that you can use to convert a JSON back into time."
    },
    new RazorPageInfo
    {
        Title = "UTC Time Conversion Trick",
        Content = "A snippet to transform a UTC time back to its original time for WinCC OA",
        Url = "/UTCTimeConversion",
        Excerpt = "A snippet to transform a UTC time back to its original time for WinCC OA."
    },
    new RazorPageInfo
    {
        Title = "Dialog Framework Maker",
        Content = "Auto Dialog Framework Maker Script Generation",
        Url = "/DialogFrameworkMaker",
        Excerpt = "Auto Dialog Framework Maker Script Generation."
    },
    new RazorPageInfo
    {
        Title = "On Return Functions in WinCC OA",
        Content = "Similar to Promises these Functions will help get values in return of processes",
        Url = "/PromisesWinCCOA",
        Excerpt = "Similar to Promises these Functions will help get values in return of processes."
    },
    new RazorPageInfo
    {
        Title = "Day Time Picker in WinCC OA",
        Content = "Day Picker included in WinCC OA and some extra options",
        Url = "/DayPicker",
        Excerpt = "Day Picker included in WinCC OA and some extra options."
    },
    new RazorPageInfo
    {
        Title = "Create and Populate Simple Tables",
        Content = "An Easy solution to create and populate Tables within Panels in Projects",
        Url = "/AutoTables",
        Excerpt = "An Easy solution to create and populate Tables within Panels in Projects."
    },
    new RazorPageInfo
    {
        Title = "Shared Pointers Intro",
        Content = "Introduction to Shared Pointers one of the best tools for object handling in WinCC OA",
        Url = "/SharedPointer",
        Excerpt = "Introduction to Shared Pointers one of the best tools for object handling in WinCC OA."
    },
    new RazorPageInfo
    {
        Title = "System Resources Monitoring",
        Content = "Check and Display the Internal Storage of the System in which the Application is Running",
        Url = "/SystemInternalStorage",
        Excerpt = "Check and Display the Internal Storage of the System in which the Application is Running."
    },
    new RazorPageInfo
    {
        Title = "Validate the Data Type of Input Objects",
        Content = "With this code you can check the Data Type of an Input and set parameters to characters",
        Url = "/InputTypeValidation",
        Excerpt = "With this code you can check the Data Type of an Input and set parameters to characters."
    },
    new RazorPageInfo
    {
        Title = "Get Changes based in a Time Period",
        Content = "Get Changes based on a time Period",
        Url = "/SPeriod",
        Excerpt = "Get Changes based on a time Period."
    },
    new RazorPageInfo
    {
        Title = "Understanding Casting and Conversion",
        Content = "Brief Introduction of Variable Casting in WinCC OA and Conversion Methods",
        Url = "/CastingVariables",
        Excerpt = "Brief Introduction of Variable Casting in WinCC OA and Conversion Methods."
    },
    new RazorPageInfo
    {
        Title = "Introduction to Enumerators in WinCC OA",
        Content = "Brief Introduction to Enumerators and useful features",
        Url = "/EnumIntro",
        Excerpt = "Brief Introduction to Enumerators and useful features."
    }
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
