using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium.Chrome;

namespace NopCommerce.Infrastructure.WebDriver
{
    public class Chrome
    {
        public static ChromeDriver SetupDriver()
        {
            var options = new ChromeOptions();

            // Set the location of the chrome binary from the resources folder
            options.BinaryLocation = Path.Combine(
                Environment.GetEnvironmentVariable("PROGRAMFILES(X86)"),
                @"Google\Chrome\Application\chrome.exe"
            );

            options.AddArgument("start-maximized");
            var chromeDriverPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(chromeDriverPath, options);
        }
    }
}
