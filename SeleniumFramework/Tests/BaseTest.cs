using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using SeleniumFramework.Helpers;
using SeleniumFramework.Helpers.Providers;
using SeleniumFramework.Pages;
using SeleniumFramework.Providers;
using WebDriverManager.DriverConfigs;


namespace SeleniumFramework.Tests
{
    [TestFixture]
    [AllureNUnit]
    [AllureDisplayIgnored]
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
                ScreenShot scr= new ScreenShot();
                scr.CaptureScreenShot(TestContext.CurrentContext.Test.Name, driver);
            }

            WebDriverFactory.Teardown();
        }
    }
}
