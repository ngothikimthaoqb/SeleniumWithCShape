using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using SeleniumFramework.Models;


namespace SeleniumFramework.Helpers.WebDrivers
{
    public class WebDriverSettings
    {
        public static ChromeOptions ChromeOptions(WebDriverConfiguration config)
        {
            var options = new ChromeOptions();
            options.AddAdditionalCapability("useAutomationExtension", false);
            options.AddExcludedArgument("enable-automation");
            options.AddArgument("--disable-save-password-bubble");
            options.AddArgument("ignore-certificate-errors");
            options.AddArgument("start-maximized");
            options.AddArgument($"--lang={config.BrowserLanguage}");
            options.AddUserProfilePreference("intl.accept_languages", config.BrowserLanguage);

            return options;
        }

        public static FirefoxOptions FirefoxOptions(WebDriverConfiguration config)
        {
            var options = new FirefoxOptions { AcceptInsecureCertificates = true };
            options.SetPreference("intl.accept_languages", config.BrowserLanguage);

            return options;
        }

        public static InternetExplorerOptions InternetExplorerOptions()
        {
            return new InternetExplorerOptions
            {
                IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                IgnoreZoomLevel = true,
                EnsureCleanSession = true
            };
        }

        public static EdgeOptions EdgeOptions()
        {
            var options = new EdgeOptions();
            options.AddAdditionalCapability("useAutomationExtension", false);
            options.PageLoadStrategy = PageLoadStrategy.Normal;

            return options;
        }
    }
}
