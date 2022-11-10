using SeleniumFramework.Helpers.Providers;
using SeleniumFramework.Pages;

namespace SeleniumFramework.Tests
{
    public class HomePageTest: BaseTest
    {
        [Test]
        public void VerifyNavigationToLoginPage()
        {
            PageProvider.Home.NavigartionToLoginPage();
        }

        [Test]
        public void VerifyHomePageIsOpened()
        {
            PageProvider.Home.IsPageTitleCorrect();
        }

    }
}
