using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Test.Core;

public class DriverManager
{
    public static IWebDriver WebDriver ;
        
    public static void InitializeBrowser(string browser)
    {
     
        if (browser == "chrome"){
            WebDriver = new ChromeDriver(ChromeDriverService.CreateDefaultService());
        }
        else if (browser == "firefox")
        {
            WebDriver = new FirefoxDriver();
        }
        
    }

    public static void CloseDriver()
    {
        WebDriver.Dispose();
        WebDriver.Quit();
        
    }
}