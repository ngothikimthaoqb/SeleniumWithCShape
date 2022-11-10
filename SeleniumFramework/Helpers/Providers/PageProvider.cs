using SeleniumExtras.PageObjects;
using SeleniumFramework.Pages;
using SeleniumFramework.Tests;

namespace SeleniumFramework.Helpers.Providers
{
    public static class PageProvider
    {
        public static HomePage Home= new HomePage(BaseTest.Driver);
        public static LoginPage Login = new LoginPage(BaseTest.Driver);
    }
}
