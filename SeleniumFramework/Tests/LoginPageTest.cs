using SeleniumFramework.Helpers.Providers;
using SeleniumFramework.Models;
using SeleniumFramework.Pages;


namespace SeleniumFramework.Tests
{
    public class LoginPageTest: BaseTest
    {
        [Test]
        public void LoginSuccessfullyWithValidUserNameAndPassWord()
        {
            User user = DataProvider.LoadJsonFile<User>("User");
            PageProvider.Home.NavigartionToLoginPage();
            PageProvider.Login.VerifyLoginSuccessfully(user);
        }
    }
}
