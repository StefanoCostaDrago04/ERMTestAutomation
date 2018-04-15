using OpenQA.Selenium;

namespace NopCommerce.Infrastructure.Pages
{
    public class RegistrationPage : BasePage
    {
        public RegistrationPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void NavigateToRegPage()
        {
            Driver.Navigate().GoToUrl(GlobalSettings.RegistrationUrl);
        }

        public void NavigateToLoginPage()
        {
            Driver.Navigate().GoToUrl(GlobalSettings.LoginUrl);
        }

        public IWebElement FirstName => Driver.FindElement(By.XPath("//input[contains(@name,'FirstName')]"));
        public IWebElement LastName => Driver.FindElement(By.XPath("//input[contains(@name,'LastName')]"));
        public IWebElement Email => Driver.FindElement(By.XPath("//input[contains(@name,'Email')]"));
        public IWebElement UserName => Driver.FindElement(By.XPath("//input[contains(@name,'UserName')]"));
        public IWebElement Password => Driver.FindElement(By.XPath("//input[contains(@name,'Password')]"));
        public IWebElement ConfirmPassword => Driver.FindElement(By.XPath("//input[contains(@name,'ConfirmPassword')]"));
        public IWebElement Submit => Driver.FindElement(By.XPath(".//*[@type='submit']"));

        public IWebElement SelectCountry(string country)
        {
            return Driver.FindElement(By.XPath("//select[contains(@id,'Country')]/option[text()=" + country + "]"));
        }

        public IWebElement SelectRole(string role)
        {
            return Driver.FindElement(By.XPath("//select[contains(@id,'Role')]/option[contains(text()," + role + ")]"));
        }
    }
}
