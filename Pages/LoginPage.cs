using OpenQA.Selenium;
using Test.Core;

namespace Test.Pages;

public class LoginPage
{
    private static LoginPage? _singtonInstance;
    private static readonly object _lockObject = new object();

    private LoginPage()
    {

    } 
    public static LoginPage GetInstance()
    {
        lock (_lockObject)
        {
            if (_singtonInstance == null)
            {
                _singtonInstance = new LoginPage();
            }
            return _singtonInstance;
        }
    }

    private Element _usernameTextBox = new Element(By.Id("username"));
    private Element _passwordTextBox = new Element(By.Id("password"));
    private Element _rememberCheckbox = new Element(By.Id("remember"));
    private Element _btnLogin = new Element(By.CssSelector("input[type='submit"));
    private Element _missingWarningMessage = new Element(By.XPath("//p[contains(text(),'This is')]"));
    private Element _incorrectValueWarningMessage = new Element(By.XPath("//div[contains(text(),'incorrect')]"));

    public void Login(string userName, string password)
    {
        ElementExtensions.EnterText(_usernameTextBox,userName);
        ElementExtensions.EnterText(_passwordTextBox,password);
        ElementExtensions.SubmitOnelement(_btnLogin);
    }

    public string GetWarningMissingMessaage()
    {
        return ElementExtensions.GetTextElement(_missingWarningMessage);
    }

    public string GetWarningIncorrectMessage()
    {
        return ElementExtensions.GetTextElement(_incorrectValueWarningMessage);
    }

    public string GetCurrenttUrl()
    {
        return ElementExtensions.GetCurrentUrl();
        
    }
    
    
    
    
}