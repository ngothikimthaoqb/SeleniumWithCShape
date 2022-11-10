using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumFramework.Models;

namespace SeleniumFramework.Pages
{
    public class LoginPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "teach_email")]
        public IWebElement UserNameField { get; set; }

        [FindsBy(How = How.Id, Using = "teach_password")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.Id, Using = "teach_btn-login")]
        public IWebElement SignInButton { get; set; }

        [FindsBy(How = How.Id, Using = "header-account")]
        public IWebElement ProfileName { get; set; }

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }


        public void Login(User user)
        {
            InputField(UserNameField, user.Email);
            InputField(PasswordField, user.Password);
            SignInButton.Click();
        }

        public void VerifyLoginSuccessfully(User user)
        {
            string userNameActual = ProfileName.Text;
            Assert.AreEqual(user.UserName, userNameActual);
        }
    }
}
