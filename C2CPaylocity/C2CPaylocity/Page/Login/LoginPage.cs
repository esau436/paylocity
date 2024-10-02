using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2CPaylocity.Page.Login
{
    public class LoginPage 
    {
        MainPage main = new MainPage();
        public void LoginToDashboard(string user, string password)
        {
            main.LoginToDashboard(user, password);
        }
    }
}
