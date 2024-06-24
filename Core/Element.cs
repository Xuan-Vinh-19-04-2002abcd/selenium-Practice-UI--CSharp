using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Test.Core;

public class Element
{
    public By By{get; set;}

    public Element(By by)
    {
        By = by;
    }
    
}