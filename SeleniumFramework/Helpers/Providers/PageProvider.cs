using SeleniumFramework.Pages;

namespace SeleniumFramework.Helpers.Providers
{
    public static class PageProvider
    {
        public static HomePage Home
        {
            get
            {
                var Home = new HomePage(WebDriverFactory.driver);
                return Home;
            }
        }

        public static LoginPage Login
        {
            get
            {
                var Login = new LoginPage(WebDriverFactory.driver);
                return Login;
            }
        }
      
    }
}
