using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestProject
{
   public class PolicyWiseBaseClass
    {
        public IWebDriver driver = null;

        [SetUp]
        public  void  OpenUrl()
        {
           var outpath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            // driver = new ChromeDriver(@"C:\Dhrumil\chromedriver_win32\");
            driver = new ChromeDriver(outpath);
            driver.Navigate().GoToUrl("http://policywisetest.ignite.systems/Login.aspx");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(3);
            Thread.Sleep(500);
            driver.Manage().Window.Maximize();

        }

        [TearDown]
        public void  CloseBrowser()
        {
             driver.Close();
        }

        internal void waitforlodingtodisapper(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromDays(1));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("loadingScreen_loading")));
        }
    }
}
