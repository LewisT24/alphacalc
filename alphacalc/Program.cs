using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System;


namespace alpha
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Initialize Classes
            IWebDriver driver = new ChromeDriver();
            MortgageCostCalculator mcc = new MortgageCostCalculator();

            //All Tests
            driver.Navigate().GoToUrl("https://www.barclays.co.uk/mortgages/mortgage-calculator/cost-calculator/#/cost");

            //Reason for Mortgage Dropdown


            //WebDriverWait wait = new WebDriverWait(driver, 100);
            //element = wait.until(ExpectedConditions.elementToBeClickable(By.id("mCalc-Reason-ahdg"))); 
            //SelectElement se = new SelectElement(driver.FindElement(By.Id("mCalc-Reason-ahdg"))); //Locating select list
            //se.SelectByValue("HP");
            //


            driver.Quit();
        }
    }

    public class MortgageCostCalculator
    {
        public int Estimatedpropertyvalue;
        public int BorrowAmount;
    }
}
