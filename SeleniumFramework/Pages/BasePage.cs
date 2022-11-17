using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumFramework.Providers;
using NUnit.Allure.Core;

namespace SeleniumFramework.Pages
{
    [TestFixture]
    [AllureNUnit]
    public abstract class BasePage
    {
        protected IWebDriver Driver { get; private set; }
        protected WebDriverWait Wait { get; private set; }
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(ConfigurationProvider.WebDriver.DefaultTimeout));
            PageFactory.InitElements(driver, this);

        }
        protected void WaitUntilElementEnabled(IWebElement el, int timeout)
        {
            try 
            {
                var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeout));
                wait.Until(ExpectedConditions.ElementToBeClickable(el));
            }
            catch (Exception e)
            {
                throw e;
            }
           
        }
      
    }
}
