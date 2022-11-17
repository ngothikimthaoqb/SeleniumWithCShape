
using NUnit.Allure.Core;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using SeleniumFramework.Helpers;
using SeleniumFramework.Helpers.Providers;
using SeleniumFramework.Providers;

namespace SeleniumFramework.Tests
{
    public class BaseTest
    {
        private IWebDriver driver;

        [SetUp]
        public void SetupBeforeEverySingleTest()
        {
            var driverConfig = ConfigurationProvider.WebDriver;
            var logger = new Logger("logger", InternalTraceLevel.Info, TextWriter.Null);
            WebDriverFactory.LaunchBrowser(driverConfig, logger);
            driver = WebDriverFactory.driver;

            PageProvider.Home.GoTo();
        }

        [TearDown]
        public void CleanUpAfterEverySingleTest()
        {
            if ( TestContext.CurrentContext.Result.Outcome.Status.ToString() != "Passed")
            {
                ScreenshotTaker scr = new ScreenshotTaker();
                scr.CaptureScreenshot(TestContext.CurrentContext.Test.Name, driver);
            }

            WebDriverFactory.Teardown();
        }
    }
}
