using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using SeleniumFramework.Helpers.Providers;
using SeleniumFramework.Pages;

namespace SeleniumFramework.Tests
{
    [AllureSuite("HomePageTest")]
    public class HomePageTest: BaseTest
    {
        [Test]
        [AllureTag("Smoke")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureFeature("Core")]
        public void VerifyNavigationToLoginPage()
        {

            PageProvider.Home.NavigartionToLoginPage();
        }

        [Test]
        [AllureTag("Smoke")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureFeature("Core")]
        public void VerifyHomePageIsOpened()
        {

            Assert.AreEqual(true, PageProvider.Home.IsPageTitleCorrect()) ;
        }

    }
}
