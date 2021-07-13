
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Gherkin.Model;
using System;
using DocumentFormat.OpenXml.Drawing.ChartDrawing;

namespace UI.Setup
{
    /// <summary>
    /// Summary description for SetUpPage
    /// </summary>
    [Binding]

    public class SetUpPage
    {
        public static IWebDriver driver = new ChromeDriver();

        ////private static ExtentReports extent;

        ////private static ExtentHtmlReporter htmlReporter;

        ////private static ExtentTest Test;

        [BeforeFeature]
        public static void BeforeTestRun()

        {
            string url = System.Configuration.ConfigurationManager.AppSettings["testurl"];
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

        }

        [AfterFeature]
        public static void AfterTestRun()
        {
            driver.Close();
            driver.Quit();
        }

    }
}


       
