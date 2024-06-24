using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Test.Core;

namespace Test.Pages
{
    public class BasePage
    {
        private Element _btnProject = new Element(By.XPath("//a[contains(text(), 'Projects')]"));
        private Element _btnCreateProject = new Element(By.LinkText("Create Project"));
        private Element _btnSearchProject = new Element(By.LinkText("Search Project"));
        private Element _btnCreateEmployee = new Element(By.CssSelector(".navbar-btn button"));
        public void GotoCreateProject()
        {
            ElementExtensions.ClickOnElement(_btnProject);
            ElementExtensions.ClickOnElement(_btnCreateProject);
        }

        public void GotoSearchProject()
        {
            ElementExtensions.ClickOnElement(_btnProject);
            ElementExtensions.ClickOnElement(_btnSearchProject);
        }

        public void GotoCreateEmployee()
        {
            ElementExtensions.ClickOnElement(_btnCreateEmployee);
        }

    }
}