using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowPages.Pages
{
    [Binding]
    public class Certification
    {
        public static IWebElement CertificationTabClick => Driver.driver.FindElement(By.XPath("//a[normalize-space()='Certifications']"));
        public static IWebElement AddNewCertificationBtn => Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][normalize-space()='Add New']"));
        private static IWebElement CertificateTextbox => Driver.driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));
        private static IWebElement CertifiedFrom => Driver.driver.FindElement(By.XPath("//input[@placeholder='Certified From (e.g. Adobe)']"));
        private static IWebElement AddYear => Driver.driver.FindElement(By.XPath("//select[@name='certificationYear']"));
        private static IWebElement AddCertificationBtn => Driver.driver.FindElement(By.XPath("//input[@value='Add']"));
        private static IWebElement EditCertificationBtn => Driver.driver.FindElement(By.XPath("//tbody/tr/td[4]/span[1]/i[1]"));
        private static IWebElement UpdateCertificationBtn => Driver.driver.FindElement(By.XPath("//input[@value='Update']"));
        private static IWebElement DeleteCertificationBtn => Driver.driver.FindElement(By.XPath("//tbody/tr/td[4]/span[2]/i[1]"));

        public static void AddCertification()
        {
            //wait for the page to load
            System.Threading.Thread.Sleep(5000);
            // click on certification tab
            CertificationTabClick.Click();



            AddNewCertificationBtn.Click();
            CertificateTextbox.Clear();
            CertificateTextbox.SendKeys(ExcelLibHelper.ReadData(2, "Certification"));
            CertifiedFrom.Clear();
            CertifiedFrom.SendKeys(ExcelLibHelper.ReadData(2, "CertificatedFrom"));
            AddYear.Click();
            Driver.driver.FindElement(By.XPath($"//option[@value='{ExcelLibHelper.ReadData(2, "Year")}']")).Click();
            AddCertificationBtn.Click();
            Driver.TurnOnWait();


            //  CommonMethods.test.Log(LogStatus.Info, "Added Certificate successfully");

        }


        public static void EditCertfications()
        {

            Driver.TurnOnWait();
            CertificationTabClick.Click();
            //add all the rows from excel file

            EditCertificationBtn.Click();
            CertificateTextbox.Clear();
            CertificateTextbox.SendKeys(ExcelLibHelper.ReadData(2, "EditCertification"));
            Driver.TurnOnWait();
            CertifiedFrom.Clear();
            CertifiedFrom.SendKeys(ExcelLibHelper.ReadData(2, "EditCertificatedFrom"));
            AddYear.Click();//option[@value='2020']
            Driver.driver.FindElement(By.XPath($"//option[@value='{ExcelLibHelper.ReadData(2, "EditYear")}']")).Click();
            UpdateCertificationBtn.Click();

        }

        public static void DeleteCertification()
        {
            System.Threading.Thread.Sleep(5000);
            CertificationTabClick.Click();
            DeleteCertificationBtn.Click();
        }

        public static void AddCertificate_Verify()
        {
            //string expected_Message = "ITIL has been added to your certification";
            var wait = new WebDriverWait(Driver.driver, new TimeSpan(0, 0, 10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("ns-box-inner")));
            IWebElement message = Driver.driver.FindElement(By.ClassName("ns-box-inner"));
            string ActualMessage = message.Text;
            Assert.That(ActualMessage == "ITIL has been added to your certification", "Certification hasnt been added");


        }
        public static void EditCertificate_Verify()
        {

            var wait = new WebDriverWait(Driver.driver, new TimeSpan(0, 0, 10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("ns-box-inner")));
            IWebElement message = Driver.driver.FindElement(By.ClassName("ns-box-inner"));
            string ActualMessage = message.Text;
            Assert.That(ActualMessage == "SQL has been updated to your certification", "Certification hasnt been updated");

        }
        public static void DeleteCertificate_Verify()
        {

            var wait = new WebDriverWait(Driver.driver, new TimeSpan(0, 0, 10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("ns-box-inner")));
            IWebElement message = Driver.driver.FindElement(By.ClassName("ns-box-inner"));
            string ActualMessage = message.Text;
            Assert.That(ActualMessage == "SQL has been deleted from your certification", "Certification hasnt been deleted");

        }
      

            
      

       

    }
}

