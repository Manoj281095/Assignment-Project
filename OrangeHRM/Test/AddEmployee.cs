using KPMG.OrangeHRM.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OrangeHRM.Pages;
using OrangeHRM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.Test
{
    internal class AddEmployee : AutomationWrapper
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

            driver.FindElement(By.XPath("(//span[@class='oxd-text oxd-text--span oxd-main-menu-item--name'])[2]")).Click();

            driver.FindElement(By.XPath("//i[@class='oxd-icon bi-plus oxd-button-icon']")).Click();

            driver.FindElement(By.Name("firstName")).SendKeys("John");

            driver.FindElement(By.Name("middleName")).SendKeys("W");
            driver.FindElement(By.Name("lastName")).SendKeys("Wick");

            driver.FindElement(By.XPath("//input[@type='checkbox']")).Click();
        }


            [Test]
            public void UploadTest()
            {
                IWebDriver driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

                driver.Url = "https://www.pexels.com/photo/green-and-blue-peacock-feather-674010/";

                driver.FindElement(By.XPath("//div[@class='oxd-file-div oxd-file-div--active']")).SendKeys("C:\\demo.img");
            }








        
    }
}
