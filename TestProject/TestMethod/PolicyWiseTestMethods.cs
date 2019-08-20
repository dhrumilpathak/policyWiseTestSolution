using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestProject.Pages;

namespace TestProject.TestMethod
{
    [TestFixture]
    class PolicyWiseTestMethods :PolicyWiseBaseClass
    {
       #region this this the object created of the pages 
        LoginPage _LoginPage = new LoginPage();
        VehicleRegistrationPage _VehicleRegistrationPage = new VehicleRegistrationPage();
        #endregion



        /// <summary>
        /// This is test case i have tried to Use Data driven for few of the Field i have used it as data drivern where the Data can be multiple and the Test case remains same
        /// </summary>
        /// <param name="regnum"></param>
        /// <param name="vehicleColor"></param>
        /// <param name="noofseats"></param>
        /// <param name="mileage"></param>
        /// <param name="bussinessmilage"></param>
        /// <param name="purchaseprice"></param>
        /// <param name="Chasisnumber"></param>

        [Description("This test case about entering vehicle details of the User")]
        [Category("Smoke Testing")]
        [Author("Dhrumil Pathak")]

        [TestCase("FAK 3S","black","6","23","20","500000", "DDF2384")]
        [TestCase("F5 Ake", "Red", "4", "21", "22","100000","BDF2384")]
        public void Task1Test(string regnum,string vehicleColor,string noofseats, string mileage, string bussinessmilage, string purchaseprice,string Chasisnumber)
        {

            #region
            _LoginPage.ClickonGetQuotelink(driver);

           string vehicledetails  = driver.FindElement(By.ClassName("panel-title")).Text;

            Assert.That(vehicledetails, Does.Contain("Vehicle Details").IgnoreCase,"you are landed on a wrong page instead of Vehicle Page.");
           _VehicleRegistrationPage.EnterRegistrationnumber(driver,regnum);
            _VehicleRegistrationPage.SelectMake(driver);
            _VehicleRegistrationPage.SelectModel(driver);

            _VehicleRegistrationPage.EnterCubicCapacity(driver);
            _VehicleRegistrationPage.EnterVehiclePostcode(driver);

            _VehicleRegistrationPage.EnterHouseNumber(driver);
            _VehicleRegistrationPage.SelectOvernightParkLocation(driver);

            _VehicleRegistrationPage.EnterMakeofYear(driver);
            _VehicleRegistrationPage.EnterDatefirstRegistered(driver);

            _VehicleRegistrationPage.EnterPurchaseDate(driver);
           // _VehicleRegistrationPage.ClickonAddressfindButton(driver);

            _VehicleRegistrationPage.SelectVehicleType(driver);
            _VehicleRegistrationPage.SelectVehicleOwner(driver);

            _VehicleRegistrationPage.SelectRegisteredKeeper(driver);
            _VehicleRegistrationPage.SelectTypeofTransmission(driver);

            _VehicleRegistrationPage.EnterVehicleColor(driver,vehicleColor);
            _VehicleRegistrationPage.selectQplated(driver);

            _VehicleRegistrationPage.selectimportedYes(driver);
            _VehicleRegistrationPage.selectnumberofseats(driver, noofseats);

            _VehicleRegistrationPage.SelecrVehicleRighthanddriver(driver);
            _VehicleRegistrationPage.EnterestimateAnnaulMilage(driver, mileage);

            _VehicleRegistrationPage.Enterbusinessmilage(driver, bussinessmilage);
            _VehicleRegistrationPage.EnterCurrentVehicleMilage(driver);

            _VehicleRegistrationPage.EnterValue(driver);
            _VehicleRegistrationPage.Ismodified(driver);

            _VehicleRegistrationPage.EnterPurchasePrice(driver,purchaseprice);
            _VehicleRegistrationPage.EnterChasisNumber(driver, Chasisnumber);

            
        _VehicleRegistrationPage.SelectAlaramType(driver);
          //  _VehicleRegistrationPage.EnterAlaramMake(driver);

          //  _VehicleRegistrationPage.AlaramFittedBy(driver);

            _VehicleRegistrationPage.SelectFitterTracker(driver);
            _VehicleRegistrationPage.ClickonNextButton(driver);

            #endregion

        }

    }
}
