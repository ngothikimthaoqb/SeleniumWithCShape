using NUnit.Framework.Internal;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium;


namespace SeleniumFramework.Helpers.WebDrivers
{
    public class WebDriverListener : EventFiringWebDriver
    {
        private readonly IWebDriver driver;

        private readonly NUnit.Framework.Internal.Logger logger;

        public WebDriverListener(IWebDriver parentDriver, NUnit.Framework.Internal.Logger logger) : base(parentDriver)
        {
            driver = parentDriver;
            this.logger = logger;
        }

        public void LogMessage(string text)
        {
            logger.Info(text);
        }

    }
}
