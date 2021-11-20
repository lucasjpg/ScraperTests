/*
Para criar um projeto no vscode, no terminal CTRL+SHIFT+' na pasta do projeto:
dotnet new console

Para instalar biblioteca Selenium, no terminal dentro da pasta:
dotnet add package Selenium.WebDriver              - 4.0.1
dotnet add package Selenium.Support                - 4.0.1
dotnet add package Selenium.WebDriver.ChromeDriver - 96.0.4664.4500

Para instalar bibliotecas de testes: (using NUnit.Framework;)
dotnet add package NUnit
dotnet add package NUnit.Runners
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    class Program
    {
        // Global variables
        // IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
            // Initialize a variable for methods using
            Program p = new Program();

            // Google Test
            IWebDriver driverGoogle = new ChromeDriver();
            p.InitializeGoogle(driverGoogle);
            p.ExecuteTestGoogle(driverGoogle);
            p.CleanUp(driverGoogle);

            // Automation Tests
            IWebDriver driverAutomation = new ChromeDriver();
            p.InitializeAutomation(driverAutomation);
            p.ExecuteTestAutomation(driverAutomation);
            p.CleanUp(driverAutomation);
        }

        public void InitializeAutomation(IWebDriver driver)
        {
            // Navigate to google page
            driver.Navigate().GoToUrl("https://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
        }

        public void ExecuteTestAutomation(IWebDriver driver)
        {
            // Select drop down menu in Title (driver, element, value, elementtype)
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");

            // Enter text in LineText (driver, element, value, elementtype)
            SeleniumSetMethods.EnterText(driver, "Initial", "Lucas", "Name");
            // Get text in LineText (driver, element, elementtype)
            Console.WriteLine("Value in LineText is "
                + SeleniumGetMethods.GetTextFromDDL(driver, "TitleId", "Id") + " "
                + SeleniumGetMethods.GetTextValue(driver, "Initial", "Name"));

            // Click on save Button (driver, element, elementtype)
            SeleniumSetMethods.Click(driver, "Save", "Name");
        }

        public void InitializeGoogle(IWebDriver driver)
        {
            // Navigate to google page
            driver.Navigate().GoToUrl("https://google.com");
        }

        public void ExecuteTestGoogle(IWebDriver driver)
        {
            // To EnterText(element, value, type)

            // Create webpage element (search text box)
            IWebElement element = driver.FindElement(By.Name("q"));

            // Search item on Google
            element.SendKeys("executeautomation");
            element.SendKeys(Keys.Enter);

            // Enter in item on Google
            driver.FindElement(By.XPath("//*[@id='rso']/div[1]/div/div/div/div[1]/a/h3")).Click();
        }

/*
        public void CreateDriver()
        {
            // Create reference for our browser
            IWebDriver driver = new ChromeDriver();
        }
*/

        public void CleanUp(IWebDriver driver)
        {
            // Close browser
            Thread.Sleep(1000);
            driver.Close();
        }
    }
}