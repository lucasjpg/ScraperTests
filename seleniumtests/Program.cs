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
dotnet add package TestProject.SDK
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
        static void Main(string[] args)
        {
            // Initialize a variable for methods using
            Program p = new Program();

            PropertiesCollection.driver = new ChromeDriver();

            // Automation Tests
            p.Initialize();
            p.ExecuteTest();
            p.CleanUp();

            //PropertiesCollection.driver = new ChromeDriver();
            //p.CleanUp();
        }

        public void Initialize()
        {
            // Navigate to executeautomation page
            PropertiesCollection.driver.Navigate().GoToUrl("https://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
        }

        public void ExecuteTest()
        {
            // Select drop down menu in Title (driver, element, value, elementtype)
            SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);

            // Enter text in LineText (driver, element, value, elementtype)
            SeleniumSetMethods.EnterText("Initial", "Luquinha", PropertyType.Name);
            // Get text in LineText (driver, element, elementtype)
            Console.WriteLine("Value in LineText is "
                + SeleniumGetMethods.GetTextFromDDL("TitleId", PropertyType.Id) + " "
                + SeleniumGetMethods.GetTextValue("Initial", PropertyType.Name));

            // Click on save Button (driver, element, elementtype)
            SeleniumSetMethods.Click("Save", PropertyType.Name);
        }
        public void CleanUp()
        {
            // Close browser
            Thread.Sleep(1000);
            PropertiesCollection.driver.Close();
        }
    }
}