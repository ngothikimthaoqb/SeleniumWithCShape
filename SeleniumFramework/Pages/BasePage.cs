using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumFramework.Providers;
using Nest;
using SeleniumFramework.Tests;

namespace SeleniumFramework.Pages
{
    public abstract class BasePage
    {
        public static IWebDriver Driver { get; private set; }
        protected WebDriverWait Wait { get; private set; }
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(ConfigurationProvider.WebDriver.DefaultTimeout));
            PageFactory.InitElements(driver, this);

        }


        public void InputField(IWebElement el, string value)
        {
            el.Clear();
            el.SendKeys(value);
        }
    }
}
