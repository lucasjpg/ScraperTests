/*
Para criar um projeto no vscode, no terminal CTRL+SHIFT+' na pasta do projeto:
dotnet new console -- force

Para instalar biblioteca Selenium, no terminal dentro da pasta:
dotnet add package Selenium.WebDriver              - 4.0.1
dotnet add package Selenium.Support                - 4.0.1
dotnet add package Selenium.WebDriver.ChromeDriver - 96.0.4664.4500
*/

using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace seleniumwhats
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //Console.WriteLine("Hello World!");
            PropertiesCollection.driver = new ChromeDriver();
            p.Initialize();
            Thread.Sleep(10000);
            p.Execute();
            p.CleanUp();
        }

        public void Execute()
        {
            // Panel Class _3uIPm WYyr1
            // TextBox Class _1UWac _1LbR4
            // TextBox Class _1UWac _1LbR4 focused
            // _13NKt copyable-text selectable-text
            // Button Class _4sWnG

            // _driver

            PropertiesCollection.driver.FindElement(By.XPath("//div[@class='_3uIPm WYyr1']")).Click();
            PropertiesCollection.driver.FindElement(By.XPath("//div[@class='_1UWac _1LbR4 focused']")).SendKeys("Hello");
            PropertiesCollection.driver.FindElement(By.XPath("//button[@class='_4sWnG']")).Click();
        }

        public void Initialize()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("https://web.whatsapp.com/");
        }

        public void CleanUp()
        {
            Thread.Sleep(1000);
            PropertiesCollection.driver.Close();
        }
    }
}
