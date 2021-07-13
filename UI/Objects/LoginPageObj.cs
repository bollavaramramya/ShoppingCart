using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UI.Setup;

namespace UI.Objects
{
    [Binding]
   public class LoginPageObj : SetUpPage
    {

 
        public LoginPageObj()
        {
        }

        #region
        public IWebElement lnkLogin => driver.FindElement(By.XPath("//a[contains(text(),'Log In')]"));
        public IWebElement txtUserName => driver.FindElement(By.Id("Username"));
        public IWebElement txtPassword => driver.FindElement(By.Id("Password"));
        public IWebElement btnLogin => driver.FindElement(By.XPath("//button[contains(text(),'Log In')]"));
        public IWebElement WelcomeText => driver.FindElement(By.XPath("//h2[contains(text(),'Confirm Logon')]"));

        #endregion


        public void login(string username,string password)
        {
            Thread.Sleep(2000);
            txtUserName.SendKeys(username);
            txtPassword.SendKeys(password);

        }

        public void Submit() => btnLogin.Click();

        public bool IsWelcomeTextExist() => WelcomeText.Displayed;


    }
}
