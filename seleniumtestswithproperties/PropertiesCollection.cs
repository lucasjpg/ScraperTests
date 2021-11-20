using OpenQA.Selenium;

namespace SeleniumTests
{
    // Strong typed values for not mistake
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }
    
    class PropertiesCollection
    {
        // Auto-implemented property
        public static IWebDriver driver {get; set;}
    }
}