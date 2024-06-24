using OpenQA.Selenium;
using Test.Core;

namespace Test.Pages;

public class ProjectInformationPage
{
    private static ProjectInformationPage? _singtonInstance;
    private static readonly object _lockObject = new object();

    private ProjectInformationPage()
    {

    } 
    public static ProjectInformationPage GetInstance()
    {
        lock (_lockObject)
        {
            if (_singtonInstance == null)
            {
                _singtonInstance = new ProjectInformationPage();
            }
            return _singtonInstance;
        }
    }

    private Element _projectname = new Element(By.XPath("//label[text()='Project Name : ']/following-sibling::p"));
    private Element _projecttype = new Element(By.XPath("//label[text()='Project Type : ']/following-sibling::p"));
    private Element _projectstatus = new Element(By.XPath("//label[text()='Project Status : ']/following-sibling::p"));
    private Element _startdate = new Element(By.XPath("//label[text()='Start Date : ']/following-sibling::p"));
    private Element _enddate = new Element(By.XPath("//label[text()='End Date : ']/following-sibling::p"));
    private Element _sizeday = new Element(By.XPath("//label[text()='Size (days) : ']/following-sibling::p"));
    private Element _location = new Element(By.XPath("//label[text()='Location : ']/following-sibling::p"));
    private Element _projectmanager = new Element(By.XPath("//label[text()='Project Manager : ']/following-sibling::p"));
    private Element _deliverymanager = new Element(By.XPath("//label[text()='Delivery / Program Manager : ']/following-sibling::p"));
    private Element _engagementmanager = new Element(By.XPath("//label[text()='Engagement Manager : ']/following-sibling::p"));
    private Element _shortdescription = new Element(By.XPath("//label[@for='shortDescription']/following-sibling::p"));
    private Element _longdescription = new Element(By.XPath("//label[@for='longDescription']/following-sibling::p"));
    private Element _technologies = new Element(By.XPath("//label[@for='technologies']/following-sibling::p"));
    private Element _clientname = new Element(By.XPath("//label[@for='clientName']/following-sibling::p"));
    private Element _clientindustry = new Element(By.XPath("//label[@for='clientindustry']/following-sibling::p"));
    private Element _clientdescription = new Element(By.XPath("//label[@for='clientdescription']/following-sibling::p"));

    public List<string> GetProjectInformation()
    {
        List<string> projectInformation = new List<string>();
    
        projectInformation.Add(ElementExtensions.GetTextElement(_projectname));
        projectInformation.Add(ElementExtensions.GetTextElement(_projecttype));
        projectInformation.Add(ElementExtensions.GetTextElement(_projectstatus));
        projectInformation.Add(ElementExtensions.GetTextElement(_startdate));
        projectInformation.Add(ElementExtensions.GetTextElement(_enddate));
        projectInformation.Add(ElementExtensions.GetTextElement(_sizeday));
        projectInformation.Add(ElementExtensions.GetTextElement(_location));
        projectInformation.Add(ElementExtensions.GetTextElement(_projectmanager));
        projectInformation.Add(ElementExtensions.GetTextElement(_deliverymanager));
        projectInformation.Add(ElementExtensions.GetTextElement(_engagementmanager));
        projectInformation.Add(ElementExtensions.GetTextElement(_shortdescription));
        projectInformation.Add(ElementExtensions.GetTextElement(_longdescription));
        projectInformation.Add(ElementExtensions.GetTextElement(_technologies));
        projectInformation.Add(ElementExtensions.GetTextElement(_clientname));
        projectInformation.Add(ElementExtensions.GetTextElement(_clientindustry));
        projectInformation.Add(ElementExtensions.GetTextElement(_clientdescription));
    
        return projectInformation;
    }
  
    
}