using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestProject.Pages
{
    class LoginPage
    {
        PolicyWiseBaseClass _PolicyWiseBaseClass = new PolicyWiseBaseClass();
        internal void OpenUrl(object driver)
        {
            throw new NotImplementedException();
        }

        internal void ClickonGetQuotelink(IWebDriver driver)
        {
            driver.FindElement(By.Id("masterContentPlaceholder_rptProducts_lnkGetQuote_1")).Click();
            _PolicyWiseBaseClass.waitforlodingtodisapper(driver);
            Thread.Sleep(1000);

        }
    }
}
