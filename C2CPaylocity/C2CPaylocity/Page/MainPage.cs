using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2CPaylocity.Page
{
    public class MainPage
    {
        // Set up the Chrome WebDriver
        IWebDriver driver = new ChromeDriver();
        // Declara variables 
        string pageURL = "https://wmxrwq14uc.execute-api.us-east-1.amazonaws.com/Prod/Account/Login";


        // *********** Xpath   ***************************************
        By user = By.Id("Username");
        By passwordPage = By.Id("Password");
        By loginbtn = By.XPath("//button[@type='submit']");
        public MainPage()
        {
            driver.Navigate().GoToUrl(pageURL);
        }
        public void LoginToDashboard(string username, string password)
        {
            
            WriteText(user, username);
            WriteText(passwordPage, password);
            ClickElement(loginbtn);


            driver.Quit();
        }
        public void WriteText(By element,string text)
        {
            driver.FindElement(element).SendKeys(text); ;
        }
        public void ClickElement(By element)
        {
            driver.FindElement(element).Click();
        }
    }
}
