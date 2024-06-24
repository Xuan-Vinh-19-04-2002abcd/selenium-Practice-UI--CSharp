using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Test.Constant;
using Test.Core;
using Test.Pages;

namespace Test.Test;

public class LoginModuleTest : BaseTest
{
    private LoginPage _loginPage;

    public LoginModuleTest() : base()
    {
        _loginPage = LoginPage.GetInstance();
    }

    [Test]
    [TestCase("admin","admin")]
    public void LoginSuccessfully(string username,string password)
    {
        _loginPage.Login(username,password);
        Assert.That(_loginPage.GetCurrenttUrl(),Is.EqualTo(ConstantUrl.SearchURl));
        
    }
    
    [Test]
    [TestCase("admin","")]
    public void LoginWithMissingPassword(string username,string password)
    {
        _loginPage.Login(username,password);
        Console.WriteLine(_loginPage.GetWarningMissingMessaage());
        Assert.That(_loginPage.GetWarningMissingMessaage(),Is.EqualTo("This is a required field."));
     
    }
    [Test]
    [TestCase("","admin")]
    public void LoginWithMissingUsername(string username,string password)
    {
        _loginPage.Login(username,password);
        Assert.That(_loginPage.GetWarningMissingMessaage(),Is.EqualTo("This is a required field."));
     
    }
    [Test]
    [TestCase("dfssf","admin")]
    public void LoginWithIncorrectUserNameandPasssword(string username, string passsword)
    {
        _loginPage.Login(username,passsword);
        Assert.That(_loginPage.GetWarningIncorrectMessage(),Is.EqualTo("The Username or Password you entered is incorrect"));
    }   
    
}