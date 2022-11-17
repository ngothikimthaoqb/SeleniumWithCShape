using NUnit.Framework.Internal;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using SeleniumFramework.Enums;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using SeleniumFramework.Models;
using SeleniumFramework.Helpers.WebDrivers;
using SeleniumFramework.Providers;
using OpenQA.Selenium;
using System.Diagnostics;

namespace SeleniumFramework.Helpers
{
    public static class WebDriverFactory
    {
        public static IWebDriver driver;
        public static void LaunchBrowser(WebDriverConfiguration driverConfig, Logger logger)
        {
            switch (driverConfig.BrowserName)
            {
                case BrowserName.Chrome:
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    var chromeDriver = new ChromeDriver(WebDriverSettings.ChromeOptions(driverConfig));
                    driver = new WebDriverListener(chromeDriver, logger);
                    break;

                case BrowserName.Firefox:
                    new DriverManager().SetUpDriver(new FirefoxConfig());
                    var firefoxDriver = new FirefoxDriver(WebDriverSettings.FirefoxOptions(driverConfig));
                    driver = new WebDriverListener(firefoxDriver, logger);
                    break;

                case BrowserName.InternetExlorer:
                    new DriverManager().SetUpDriver(new InternetExplorerConfig());
                    var ieDriver = new InternetExplorerDriver(WebDriverSettings.InternetExplorerOptions());
                    driver = new WebDriverListener(ieDriver, logger);
                    break;

                case BrowserName.Edge:
                    new DriverManager().SetUpDriver(new EdgeConfig());
                    var edgeDriver = new EdgeDriver(WebDriverSettings.EdgeOptions());
                    driver =  new WebDriverListener(edgeDriver, logger);
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(ConfigurationProvider.WebDriver.BrowserName),
                        ConfigurationProvider.WebDriver.BrowserName,
                        null);
            }
        }
        static public void Teardown()
        {
            try
            {

                driver.Quit();
                //KillChromeSessions();
            }
            catch (Exception)
            {
                
            }
        }

        static public void KillChromeSessions()
        {

            try
            {
                Thread.Sleep(1000);

                foreach (Process proc in Process.GetProcessesByName("chrome"))
                {
                    proc.Kill();
                    Thread.Sleep(2000);
                }
            }
            catch (Exception ex)
            {
                
            }

        }
    }
}
