using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Test.Core;

public class ElementExtensions
{
    protected static IWebDriver Driver = DriverManager.WebDriver;
    private static WebDriverWait Wait = new WebDriverWait(DriverManager.WebDriver, TimeSpan.FromSeconds(30));
    
    public static IWebElement WaitForElementToBeVisible(Element element)
    {
        
        return Wait.Until(ExpectedConditions.ElementIsVisible(element.By));
            
    }
    public static bool IsElementDisplayed(Element element)
    {
        return Wait.Until(ExpectedConditions.ElementIsVisible(element.By)).Displayed;
    }
    public static bool IsElementEnabled(Element element)
    {
        return Wait.Until(ExpectedConditions.ElementIsVisible(element.By)).Enabled;
    }
    public static IWebElement WaitForElementToBeClickEnable(Element element)
    {
        return Wait.Until(ExpectedConditions.ElementToBeClickable(element.By));
    }
    public void WaitForElementGotoUrl(string url)
    {
        Wait.Until(ExpectedConditions.UrlToBe(url));
    }
   

    public static void EnterText(Element locator , string text)
    {
        
        IWebElement element = WaitForElementToBeVisible(locator);
        element.Clear();
        element.SendKeys(text);
        
    }
    public static void ClickOnElement(Element element)
    {
       WaitForElementToBeClickEnable(element).Click();
    }

    public static void SubmitOnelement(Element element)
    {
        WaitForElementToBeClickEnable(element).Submit();
    }
    public static void SelectDropdownByValue(Element locator, string value)
    {
        IWebElement element = WaitForElementToBeVisible(locator);
        SelectElement selectElement = new SelectElement(element);
        selectElement.SelectByText(value);
    }
    public static string GetTextElement(Element element)
    {
        return WaitForElementToBeVisible(element).Text;
    }
    public static void SelectDateFromDatePicker(Element element, string date)
    {
        IWebElement elementDatePicker = WaitForElementToBeVisible(element);
        IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
        js.ExecuteScript("arguments[0].value = arguments[1]; arguments[0].dispatchEvent(new Event('change')); arguments[0].dispatchEvent(new Event('input'));", elementDatePicker, date);
    }

    public static string GetCurrentUrl()
    {
        string initialUrl = Driver.Url;
        Wait.Until(driver =>
        {
            string currentUrl = driver.Url;
            return !string.IsNullOrEmpty(currentUrl) && currentUrl != initialUrl;
        });
        return Driver.Url;
    }
    public static List<IWebElement> ConvertByToIWebElements(Element element)
    {
        var webElements = Driver.FindElements(element.By);
        return new List<IWebElement>(webElements);
    }
    
}