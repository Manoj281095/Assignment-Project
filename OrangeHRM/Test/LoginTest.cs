using KPMG.OrangeHRM.Base;
using OpenQA.Selenium;
using OrangeHRM.Pages;
using OrangeHRM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.Test
{
    internal class LoginTest : AutomationWrapper
    {
        [Test]
        [TestCaseSource(typeof(DataSource), nameof(DataSource.ValidLoginData))]


        public void ValidLoginTest(string username, string password, string expectedTitle)
        {
            LoginPage LoginPage = new LoginPage(driver);

            LoginPage.EnterUsername(username);
            LoginPage.EnterPassword(password);
            LoginPage.ClickOnLogIn();

            MainPage mainPage = new MainPage(driver);
            String actualTitle = mainPage.GetMainPageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));




        }

        [Test]
        [TestCaseSource(typeof(DataSource), nameof(DataSource.InvalidloginData))]

        public void InvalidLogintest(string username, string password, string expectedError)
        {
            LoginPage LoginPage = new LoginPage(driver);
            LoginPage.EnterUsername(username);
            LoginPage.EnterPassword(password);
            LoginPage.ClickOnLogIn();

            string actualError = LoginPage.GetInvalidMessageError();
            Assert.That(actualError, Is.EqualTo(expectedError));

        }
    }
}
