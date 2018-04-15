using TechTalk.SpecFlow;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using NopCommerce.Infrastructure.Pages;

namespace ERMTestAutomation
{
    [Binding]
    public sealed class NopCommerceSteps
    {
        public IWebDriver driver;
        public RegistrationPage regPage;

        [BeforeScenario]
        public void Setup()
        {
            driver = NopCommerce.Infrastructure.WebDriver.Chrome.SetupDriver();
            regPage = new RegistrationPage(driver);
        }

        [Given(@"I browse to Nopcommerce registration page")]
        public void GivenIBrowseToNopcommerceRegistrationPage()
        {
            regPage.NavigateToRegPage();
        }

        [When(@"I enter all the relevant details")]
        public void WhenIEnterAllTheRelevantDetails()
        {
            regPage.FirstName.SendKeys("Stefano");
            regPage.LastName.SendKeys("Costa");
            regPage.Email.SendKeys("stefano.costa@generic.com");
            regPage.SelectCountry("Australia");
            regPage.SelectRole("Technical");
            regPage.Password.SendKeys("Password123!");
            regPage.ConfirmPassword.SendKeys("Password123!");         
        }

        [When(@"I apply for registration")]
        public void WhenIApplyForRegistration()
        {
            regPage.Submit.Click();
        }

        [Then(@"the registration to NopCommerce is successful")]
        public void ThenTheRegistrationToNopCommerceIsSuccessful()
        {
            Assert.IsTrue(regPage.GetText("Your registration completed").Displayed);
        }

        [Given(@"I am on the login page of nopCommerce")]
        public void GivenIAmOnTheLoginPageOfNopCommerce()
        {
            regPage.NavigateToLoginPage();
        }

        [When(@"I enter my username ""(.*)"" and my password ""(.*)""")]
        public void WhenIEnterMyUsernameAndMyPassword(string usr, string pwd)
        {
            driver.FindElement(By.XPath("//input[contains(@name,'UserName')]")).SendKeys(usr);
            driver.FindElement(By.XPath("//input[contains(@name,'Password')]")).SendKeys(pwd);
        }


        [AfterScenario]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
            driver = null; 
        }

    }
}
