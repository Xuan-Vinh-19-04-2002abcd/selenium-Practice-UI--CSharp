using Microsoft.Extensions.Configuration;
using Test.Constant;
using Test.Core;

namespace Test.Test;

public class BaseTest
{
    public BaseTest()
    {
        string browser = "chrome";
        DriverManager.InitializeBrowser(browser);   
    }
    
    [SetUp]
    public void Setup()
    {
        
        DriverManager.WebDriver.Navigate().GoToUrl(ConstantUrl.BaseURL);
        DriverManager.WebDriver.Manage().Window.Maximize();
    }

    [TearDown]
    public void TearDown()
    {
        DriverManager.CloseDriver();
    }

}