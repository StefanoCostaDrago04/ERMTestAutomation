using OpenQA.Selenium;

namespace NopCommerce.Infrastructure.Pages
{
    public class BasePage
    {
        public BasePage() { }
        protected  IWebDriver Driver { get; set; }

        public IWebElement GetText(string text)
        {
            return Driver.FindElement(By.XPath(".//*[text()='" + text + "']"));
        }
    }
}
