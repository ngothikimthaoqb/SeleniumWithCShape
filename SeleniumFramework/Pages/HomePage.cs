using Nest;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumFramework.Providers;

namespace SeleniumFramework.Pages
{
    public class HomePage: BasePage
    {

        [FindsBy(How = How.Id, Using = "h-sign-in")]
        private IWebElement SignInLink { get; set; }

        private static string HomePageTitle = "Oxford Leaner's Dictionaries";
        private static string SignInPageTitle = "Sign in | Oxford University Press ";

        private static Uri HomePageUrl => new Uri(ConfigurationProvider.Environment.ApplicationUrl);

        public HomePage(IWebDriver driver) : base(driver)
        {

        }

 
        internal void GoTo()
        {
            Driver.Navigate().GoToUrl(HomePageUrl);
        }

        internal bool IsPageTitleCorrect() => Driver.Title.Equals(HomePageTitle + "jdnckdnk");
        internal bool IsSignInPageTitleCorrect() => Driver.Title.Equals(SignInPageTitle);


        internal void NavigartionToLoginPage()
        {
            SignInLink.Click();
            IsSignInPageTitleCorrect();
        }

    }
}
