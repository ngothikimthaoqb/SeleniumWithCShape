using NUnit.Framework.Internal;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using SeleniumFramework.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using SeleniumFramework.Models;
using SeleniumFramework.Helpers.WebDrivers;
using SeleniumFramework.Providers;

namespace SeleniumFramework.Helpers
{
    public class WebDriverFactory
    {
        public WebDriverListener GetWebDriver(WebDriverConfiguration driverConfig, Logger logger)
        {
            switch (driverConfig.BrowserName)
            {
                case BrowserName.Chrome:
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    var chromeDriver = new ChromeDriver(WebDriverSettings.ChromeOptions(driverConfig));

                    return new WebDriverListener(chromeDriver, logger);

                case BrowserName.Firefox:
                    new DriverManager().SetUpDriver(new FirefoxConfig());
                    var firefoxDriver = new FirefoxDriver(WebDriverSettings.FirefoxOptions(driverConfig));

                    return new WebDriverListener(firefoxDriver, logger);

                case BrowserName.IE:
                    new DriverManager().SetUpDriver(new InternetExplorerConfig());
                    var ieDriver = new InternetExplorerDriver(WebDriverSettings.InternetExplorerOptions());

                    return new WebDriverListener(ieDriver, logger);

                case BrowserName.Edge:
                    new DriverManager().SetUpDriver(new EdgeConfig());
                    var edgeDriver = new EdgeDriver(WebDriverSettings.EdgeOptions());

                    return new WebDriverListener(edgeDriver, logger);

                default:
                    throw new ArgumentOutOfRangeException(nameof(ConfigurationProvider.WebDriver.BrowserName),
                        ConfigurationProvider.WebDriver.BrowserName,
                        null);
            }
        }

    }
}
