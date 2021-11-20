using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    class SeleniumGetMethods
    {
        // Enter text
        public static string GetText(string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                return PropertiesCollection.driver.FindElement(By.Id(element)).Text;
            if (elementtype == PropertyType.Name)
                return PropertiesCollection.driver.FindElement(By.Name(element)).Text;
            else
                return String.Empty;
        }
        public static string GetTextValue(string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementtype == PropertyType.Name)
                return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("value");
            else
                return String.Empty;
        }
        public static string GetTextFromDDL(string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementtype == PropertyType.Name)
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else
                return String.Empty;
        }
    }
}