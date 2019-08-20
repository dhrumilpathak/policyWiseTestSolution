using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace TestProject.Pages
{
    class VehicleRegistrationPage
    {
        internal void EnterRegistrationnumber(IWebDriver driver,string regnum)
        {
            driver.FindElement(By.Id("ctl00_masterContentPlaceholder_carRegistrationLookup_txtCarRegistrationNumber_txtBox")).SendKeys(regnum);
        }

        internal void SelectMake(IWebDriver driver)
        {
            Actions movetodropdown = new Actions(driver);
            movetodropdown.Click(driver.FindElement(By.Id("ctl00_masterContentPlaceholder_ddlMake_ddlList_Input"))).Click().Build().Perform();

            Thread.Sleep(500);

            driver.FindElement(By.XPath(".//*[@id='ctl00_masterContentPlaceholder_ddlMake_ddlList_DropDown']//*[@class='rcbList']//li[3]")).Click();

        }

        internal void SelectModel(IWebDriver driver)
        {
            Thread.Sleep(500);
            Actions movetodropdown = new Actions(driver);
            movetodropdown.Click(driver.FindElement(By.Id("ctl00_masterContentPlaceholder_ddlModel_ddlList_Input"))).Click().Build().Perform();

            Thread.Sleep(500);
            driver.FindElement(By.XPath(".//*[@id='ctl00_masterContentPlaceholder_ddlModel_ddlList_DropDown']//*[@class='rcbList']//li[3]")).Click();

        }

        internal void EnterDatefirstRegistered(IWebDriver driver)
        {
           string regdate =  DateTime.Now.ToString("dd/MM/yyyy");
            Thread.Sleep(500);
            driver.FindElement(By.Id("ctl00_masterContentPlaceholder_dtDateFirstRegistered_dtPicker_dateInput")).SendKeys(regdate);
        }

        internal void SelectRegisteredKeeper(IWebDriver driver)
        {
            Thread.Sleep(500);
            //Actions movetodropdown = new Actions(driver);
            //movetodropdown.Click(driver.FindElement(By.Id("ctl00_masterContentPlaceholder_ddlRegisteredKeeper_ddlList_Input"))).Click().Build().Perform();
            driver.FindElement(By.Id("ctl00_masterContentPlaceholder_ddlRegisteredKeeper_ddlList_Arrow")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath(".//*[@id='ctl00_masterContentPlaceholder_ddlRegisteredKeeper_ddlList_DropDown']//*[@class='rcbList']//li[3]")).Click();
        }

        internal void ClickonAddressfindButton(IWebDriver driver)
        {
            Thread.Sleep(800);

            driver.FindElement(By.Id("ctl00_masterContentPlaceholder_ucAddress_ctl00_btnFindMyAddress_btn_input")).Click();
            Thread.Sleep(800);
        }

        internal void EnterestimateAnnaulMilage(IWebDriver driver, string mileage) =>  driver.FindElement(By.Id("ctl00_masterContentPlaceholder_txtEstimatedMileage_txtBox")).SendKeys(mileage);
        

        internal void SelecrVehicleRighthanddriver(IWebDriver driver)
        {
            Thread.Sleep(800);
            driver.FindElement(By.XPath(".//*[@id='masterContentPlaceholder_boolRightHandDrive_rbtnList']//input[@value='Yes']")).Click();
        }

        internal void EnterPurchasePrice(IWebDriver driver, string purchaseprice)
        {
            Thread.Sleep(800);
            driver.FindElement(By.Id("ctl00_masterContentPlaceholder_txtPurchasePrice_txtBox")).SendKeys(purchaseprice);
            Thread.Sleep(800);
        }

        internal void EnterValue(IWebDriver driver)
        {
            Thread.Sleep(300);
            driver.FindElement(By.Id("ctl00_masterContentPlaceholder_txtValue_txtBox")).SendKeys("80000");
        }

        internal void SelectAlaramType(IWebDriver driver)
        {
            Thread.Sleep(300);
            driver.FindElement(By.XPath(".//a[@id='ctl00_masterContentPlaceholder_ddlModernCarAlarmType_ddlList_Arrow']")).Click();
            Thread.Sleep(300);
            driver.FindElement(By.XPath(".//*[@id='ctl00_masterContentPlaceholder_ddlModernCarAlarmType_ddlList_DropDown']//*[@class='rcbList']//li[2]")).Click();
        }

        internal void ClickonNextButton(IWebDriver driver)
        {
            driver.FindElement(By.Id("ctl00_masterContentPlaceholder_btnNext_btn_input")).Click();
            Thread.Sleep(1000);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromDays(1));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("loadingScreen_loading")));

        }

        internal void SelectFitterTracker(IWebDriver driver)
        {
            Thread.Sleep(300);
            driver.FindElement(By.Id("ctl00_masterContentPlaceholder_ddlTrackerType_ddlList_Arrow")).Click();
            driver.FindElement(By.XPath(".//*[@id='ctl00_masterContentPlaceholder_ddlTrackerType_ddlList_DropDown']//*[@class='rcbList']//li[3]")).Click();
        }

        internal void AlaramFittedBy(IWebDriver driver)
        {
            Thread.Sleep(500);
            driver.FindElement(By.Id("ctl00_masterContentPlaceholder_ddlAlarmFittedBy_ddlList_Arrow")).Click();

            driver.FindElement(By.XPath(".//*[@id='ctl00_masterContentPlaceholder_ddlAlarmFittedBy_ddlList_DropDown']//*[@class='rcbList']//li[9]")).Click();
        }

        internal void EnterAlaramMake(IWebDriver driver)
        {
            driver.FindElement(By.Id("ctl00_masterContentPlaceholder_ddlAlarmModel_ddlList_Input")).Click();
            driver.FindElement(By.Id("ctl00_masterContentPlaceholder_ddlAlarmModel_ddlList_Input")).SendKeys("AA Immobiliser"+Keys.Tab);
          //  driver.FindElement(By.XPath(".//*[@id='ctl00_masterContentPlaceholder_ddlAlarmModel_ddlList_DropDown']//*[contains(text(),'AA Immobiliser')]")).Click();
            Thread.Sleep(100);
             
        }

        internal void EnterChasisNumber(IWebDriver driver, string Chasisnumber)
        {
            Thread.Sleep(500);
            driver.FindElement(By.Id("ctl00_masterContentPlaceholder_txtChassisNumber_txtBox")).SendKeys(Chasisnumber);
        }

        internal void Ismodified(IWebDriver driver)
        {
            driver.FindElement(By.XPath(".//*[@id='masterContentPlaceholder_boolVehicleIsModified_rbtnList']//*[@value='No']")).Click();
        }

        internal void EnterCurrentVehicleMilage(IWebDriver driver)
        {
            Thread.Sleep(500);
            driver.FindElement(By.Id("ctl00_masterContentPlaceholder_txtCurrentMileage_txtBox")).SendKeys("18");
        }

        internal void Enterbusinessmilage(IWebDriver driver, string bussinessmilage)
        {
            driver.FindElement(By.Id("ctl00_masterContentPlaceholder_txtBusinessMileage_txtBox")).SendKeys(bussinessmilage);
        }

        internal void selectnumberofseats(IWebDriver driver,string noofseats)
        {
            Thread.Sleep(300);
            driver.FindElement(By.XPath(".//a[@id='ctl00_masterContentPlaceholder_ddlNumberOfSeats_ddlList_Arrow']")).Click();
            Thread.Sleep(200);
            driver.FindElement(By.XPath(".//*[@id='ctl00_masterContentPlaceholder_ddlNumberOfSeats_ddlList_DropDown']//*[@class='rcbList']//li["+ noofseats+"]")).Click();

        }

        internal void selectimportedYes(IWebDriver driver)
        {
            driver.FindElement(By.XPath(".//*[@id='masterContentPlaceholder_boolImported_rbtnList']//input[@value='Yes']")).Click();
            Thread.Sleep(400);
        }


        internal void selectQplated(IWebDriver driver)
        {
            Thread.Sleep(500);
            driver.FindElement(By.XPath(".//*[@id='masterContentPlaceholder_boolQPlated_rbtnList']//input[@value='No']")).Click();
        }

        internal void EnterVehicleColor(IWebDriver driver,string vehicleColor)
        {
            Thread.Sleep(500);
            driver.FindElement(By.Id("ctl00_masterContentPlaceholder_txtVehicleColour_txtBox")).SendKeys(vehicleColor);
        }

        internal void SelectTypeofTransmission(IWebDriver driver)
        {
            Thread.Sleep(500);
            Actions movetodropdown = new Actions(driver);
            movetodropdown.Click(driver.FindElement(By.Id("ctl00_masterContentPlaceholder_ddlTransmission_ddlList_Input"))).Click().Build().Perform();

            Thread.Sleep(500);
            driver.FindElement(By.XPath(".//*[@id='ctl00_masterContentPlaceholder_ddlTransmission_ddlList_DropDown']//*[@class='rcbList']//li[3]")).Click();
        }

        internal void SelectVehicleOwner(IWebDriver driver)
        {
            Thread.Sleep(500);
            Actions movetodropdown = new Actions(driver);
            movetodropdown.Click(driver.FindElement(By.Id("ctl00_masterContentPlaceholder_ddlRegisteredOwner_ddlList_Input"))).Click().Build().Perform();

            Thread.Sleep(800);
            driver.FindElement(By.XPath(".//*[@id='ctl00_masterContentPlaceholder_ddlRegisteredOwner_ddlList_DropDown']//*[@class='rcbList']//li[3]")).Click();
        }

    

        internal void SelectVehicleType(IWebDriver driver)
        {
            Thread.Sleep(1000);
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromMinutes(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("ctl00_masterContentPlaceholder_ddlNonClassicVehicleType_ddlList_Arrow")));

            //Actions movetodropdown = new Actions(driver);
            // movetodropdown.Click(driver.FindElement(By.Id("ctl00_masterContentPlaceholder_ddlNonClassicVehicleType_ddlList_Input"))).Click().Build().Perform();
            driver.FindElement(By.Id("ctl00_masterContentPlaceholder_ddlNonClassicVehicleType_ddlList_Arrow")).Click();
            Thread.Sleep(300);
            driver.FindElement(By.XPath(".//*[@id='ctl00_masterContentPlaceholder_ddlNonClassicVehicleType_ddlList_DropDown']//*[@class='rcbList']//li[3]")).Click();
        }

        internal void EnterPurchaseDate(IWebDriver driver)
        {
            Thread.Sleep(500);
            string regdate = DateTime.Now.ToString("dd/MM/yyyy");
            driver.FindElement(By.Id("ctl00_masterContentPlaceholder_dtPurchaseDate_dtPicker_dateInput")).SendKeys(regdate);

            Thread.Sleep(300);

        }

        internal void EnterMakeofYear(IWebDriver driver)
        {
            driver.FindElement(By.Id("ctl00_masterContentPlaceholder_txtYearOfMake_txtBox")).Clear();
            Thread.Sleep(300);
           // string regdate = DateTime.Now.ToString("yyyy");
            driver.FindElement(By.Id("ctl00_masterContentPlaceholder_txtYearOfMake_txtBox")).SendKeys(1938 + Keys.Tab);
            Thread.Sleep(300);
        }

        internal void SelectOvernightParkLocation(IWebDriver driver)
        {
            Thread.Sleep(500);
            Actions movetodropdown = new Actions(driver);
            movetodropdown.Click(driver.FindElement(By.Id("ctl00_masterContentPlaceholder_ddlOvernightParkLocation_ddlList_Input"))).Click().Build().Perform();

            Thread.Sleep(500);
            driver.FindElement(By.XPath(".//*[@id='ctl00_masterContentPlaceholder_ddlOvernightParkLocation_ddlList_DropDown']//*[@class='rcbList']//li[3]")).Click();
        }

        internal void EnterHouseNumber(IWebDriver driver)
        {
            Thread.Sleep(1000);
            driver.FindElement(By.Id("ctl00_masterContentPlaceholder_ucAddress_ctl00_txtHouseFlatNumber_txtBox")).SendKeys("103  Scrimshire Lane");
            driver.FindElement(By.Id("ctl00_masterContentPlaceholder_ucAddress_ctl00_btnFindMyAddress_btn_input")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.Id("ctl00_masterContentPlaceholder_ucAddress_ctl00_txtAddress1_txtBox")).SendKeys("HR1 8PA");
            driver.FindElement(By.Id("ctl00_masterContentPlaceholder_ucAddress_ctl00_txtTownOrCity_txtBox")).SendKeys("CHECKLEY");
        }

        internal void EnterVehiclePostcode(IWebDriver driver)
        {
            Thread.Sleep(1000);
            driver.FindElement(By.Id("ctl00_masterContentPlaceholder_ucAddress_ctl00_txtPostCode_txtBox")).SendKeys("MK16 4ZZ");
        }

        internal void EnterCubicCapacity(IWebDriver driver)
        {
            driver.FindElement(By.Id("ctl00_masterContentPlaceholder_txtCubicCapacity_txtBox")).SendKeys("23342");
            Thread.Sleep(300);
        }
    }
}
