using Nest;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using Allure.Commons;
using SeleniumFramework.Helpers.Providers;
using SeleniumFramework.Models;


namespace SeleniumFramework.Tests
{
    [TestFixture]
    [AllureNUnit]
    [AllureDisplayIgnored]
    [AllureSuite("LoginPageTest")]
    public class LoginPageTest: BaseTest
    {
        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureFeature("Core")]
        public void LoginSuccessfullyWithValidUserNameAndPassWord()
        {
            User user = DataProvider.LoadJsonFile<User>("User");
            PageProvider.Home.NavigartionToLoginPage();
            PageProvider.Login.Login(user);
            PageProvider.Login.VerifyLoginSuccessfully(user);
        }
    }
}
