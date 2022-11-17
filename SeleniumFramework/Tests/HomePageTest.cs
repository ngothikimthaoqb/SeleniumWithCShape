using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using SeleniumFramework.Helpers.Providers;

namespace SeleniumFramework.Tests
{
    [AllureDisplayIgnored]
    [AllureSuite("HomePageTest")]
    [TestFixture]
    [AllureNUnit]
    public class HomePageTest: BaseTest
    {
        [Test]
        [AllureTag("Smoke")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureFeature("Core")]
        public void VerifyNavigationToLoginPage()
        {
            PageProvider.Home.NavigartionToLoginPage();
            Assert.AreEqual(true, PageProvider.Home.IsSignInPageTitleCorrect(), "You can not navigate to homepage");
        }

        [Test]
        [AllureTag("Smoke")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureFeature("Core")]
        public void VerifyHomePageIsOpened()
        {

            Assert.AreEqual(true, PageProvider.Home.IsPageTitleCorrect(), "The title is not correct") ;
        }

    }
}
