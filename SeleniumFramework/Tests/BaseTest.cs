using NUnit.Framework.Internal;
using OpenQA.Selenium;
using SeleniumFramework.Helpers;
using SeleniumFramework.Helpers.Providers;
using SeleniumFramework.Providers;


namespace SeleniumFramework.Tests
{
    public abstract class BaseTest
    {
        private static IWebDriver driver;

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method InitBrowser.");
                return driver;
            }
            private set
            {
                driver = value;
            }
        }

        [SetUp]
        public void SetupBeforeEverySingleTest()
        {

            var driverConfig = ConfigurationProvider.WebDriver;
            var logger = new Logger("logger", InternalTraceLevel.Info, TextWriter.Null);
            driver = new WebDriverFactory().GetWebDriver(driverConfig, logger);

            PageProvider.Home.GoTo();
        }

        [TearDown]
        public void CleanUpAfterEverySingleTest()
        {
            driver.Quit();
        }
    }
}
