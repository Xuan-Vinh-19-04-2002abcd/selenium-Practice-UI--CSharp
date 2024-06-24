using OpenQA.Selenium;
using Test.Builder.CreateProjectParamater;
using Test.Core;
using Test.Helper;

namespace Test.Pages;

public class CreateProjectPage : BasePage
{
    private static CreateProjectPage? _singtonInstance;
    private static readonly object _lockObject = new object();

    private CreateProjectPage()
    {

    } 
    public static CreateProjectPage GetInstance()
    {
        lock (_lockObject)
        {
            if (_singtonInstance == null)
            {
                _singtonInstance = new CreateProjectPage();
            }
            return _singtonInstance;
        }
    }
    
    private Element _projectnameTextbox = new Element(By.Id("name"));
    private Element _projecttypeDropdown = new Element(By.Id("projecttype"));
    private Element _projectstatusDropdown = new Element(By.Id("status"));
    private Element _startdatePicker = new Element(By.Name("sdate"));
    private Element _enddatePicker = new Element(By.Name("edate"));
    private Element _sizedayTextbox = new Element(By.Id("sizeday"));
    private Element _locationDropdown = new Element(By.Id("location"));
    private Element _projectmanagerDropdown = new Element(By.Id("projectManager"));
    private Element _deliverymanagerDropdown = new Element(By.Id("deliveryManager"));
    private Element _engagementmanagerDropdown = new Element(By.Id("engagementManager"));
    private Element _shortdescriptionTexbox = new Element(By.Id("shortDescription"));
    private Element _longdescriptionTextbox = new Element(By.Id("longDescription"));
    private Element _technologiesTextbox = new Element(By.Id("technologies"));
    private Element _clientnameTexbox = new Element(By.Id("clientName"));
    private Element _clientindustryDropdown = new Element(By.Id("clientindustry"));
    private Element _clientdescriptionTextbox = new Element(By.Id("clientdescription"));
    private Element _btnConfirm = new Element(By.Id("btnConfirm"));
    private Element _btnMoveRight = new Element(By.CssSelector("button[class$='uib-right']"));
    private Element _btnMoveLeft = new Element(By.CssSelector("button[class$='uib-left']"));
    private Element _btnDatePickerHeading = new Element(By.XPath("//table[@class='uib-daypicker']/descendant::button[2]"));
    
    public void CreateProject(Project project)
    {
        GotoCreateProject();
        FillInAllFields( project);
       
    }
    public void FillInAllFields (Project project)
    {
        ElementExtensions.EnterText(_projectnameTextbox,project.ProjectName);
        ElementExtensions.SelectDropdownByValue(_projecttypeDropdown,project.ProjectType);
        ElementExtensions.SelectDropdownByValue(_projectstatusDropdown,project.ProjectStatus);
        ElementExtensions.SelectDateFromDatePicker(_startdatePicker,project.StartDate);
        ElementExtensions.SelectDateFromDatePicker(_enddatePicker,project.EndDate);
        ElementExtensions.EnterText(_sizedayTextbox,project.SizeDay);
        ElementExtensions.SelectDropdownByValue(_locationDropdown,project.Location);
        ElementExtensions.SelectDropdownByValue(_projectmanagerDropdown,project.ProjectManager);
        ElementExtensions.SelectDropdownByValue(_deliverymanagerDropdown,project.DeliveryManager);
        ElementExtensions.SelectDropdownByValue(_engagementmanagerDropdown,project.EngagementManager);
        ElementExtensions.EnterText(_shortdescriptionTexbox,project.ShortDescription);
        ElementExtensions.EnterText(_longdescriptionTextbox,project.LongDescription);
        ElementExtensions.EnterText(_technologiesTextbox,project.Technology);
        ElementExtensions.EnterText(_clientnameTexbox,project.ClientName);
        ElementExtensions.SelectDropdownByValue(_clientindustryDropdown,project.ClientIndustry);
        ElementExtensions.EnterText(_clientdescriptionTextbox,project.ClientDescription);
        ElementExtensions.SubmitOnelement(_btnConfirm);
    }
    
    public bool AreProjectAttributesMatching(Project project, List<string> projectInformation)
    {
        
        List<string> projectAttributes = new List<string>();
        projectAttributes.Add(project.ProjectName);
        projectAttributes.Add(project.ProjectType);
        projectAttributes.Add(project.ProjectStatus);
        projectAttributes.Add(project.StartDate);
        projectAttributes.Add(project.EndDate);
        projectAttributes.Add(project.SizeDay);
        projectAttributes.Add(project.Location);
        AddProcessedAttribute(projectAttributes, project.ProjectManager);
        AddProcessedAttribute(projectAttributes, project.DeliveryManager);
        AddProcessedAttribute(projectAttributes, project.EngagementManager);
        projectAttributes.Add(project.ShortDescription);
        projectAttributes.Add(project.LongDescription);
        projectAttributes.Add(project.Technology);
        projectAttributes.Add(project.ClientName);
        projectAttributes.Add(project.ClientIndustry);
        projectAttributes.Add(project.ClientDescription);
        
        for (int i = 0; i < projectAttributes.Count; i++)
        {
            if (projectAttributes[i] != projectInformation[i])
            {
                return false;
            }
        }

        return true;
    }
    private void AddProcessedAttribute(List<string> list, string attribute)
    {
        list.Add(StringHelper.ProcessAttribute(attribute));
    }
    
}