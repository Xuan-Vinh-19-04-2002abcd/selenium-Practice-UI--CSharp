using OpenQA.Selenium;
using Test.Builder.CreateProjectParamater;
using Test.Core;

namespace Test.Pages;

public class SearchProject : BasePage
{
    private static SearchProject? _singtonInstance;
    private static readonly object _lockObject = new object();

    private SearchProject()
    {
        
    } 
    public static SearchProject GetInstance()
    {
        lock (_lockObject)
        {
            if (_singtonInstance == null)
            {
                _singtonInstance = new SearchProject();
            }
            return _singtonInstance;
        }
    }
    private Element _projectNameTextbox = new Element(By.XPath("//span[@id=\"searchProject\"]/search-project/div[2]/input"));
    private Element _btnSearch = new Element(By.XPath("//span[@id=\"searchProject\"]/search-project/div[1]/button[1]"));
    private Element _resultsProjectName = new Element(By.XPath("//table//a[contains(@href,'project')]"));
    private Element _btnNextPage = new Element(By.XPath("//a[text()='›']"));
    private Element? _linkDisable = new Element(By.XPath("//a[@ng-click='setCurrent(pagination.current + 1)']/ancestor::li[contains(@class,'disabled')]"));

    
    private List<string> GetProjectNamesFromCurrentPage()
    {
        List<string> projectNames = new List<string>();

        if (ElementExtensions.IsElementDisplayed(_resultsProjectName))
        {
            List<IWebElement> listProjectName = ElementExtensions.ConvertByToIWebElements(_resultsProjectName);
        
            foreach (var projectname in listProjectName)
            {
                projectNames.Add(projectname.Text);
            }
        }

        return projectNames;
    }
    public List<string> GetAllProjectNames()
    {
        List<string> projectNames = new List<string>();
        projectNames.AddRange(GetProjectNamesFromCurrentPage());
        do
        {
            ElementExtensions.ClickOnElement(_btnNextPage);
            projectNames.AddRange(GetProjectNamesFromCurrentPage());
  
            
        } while (_linkDisable == null);

        return projectNames;
    }

    public void SearchProjectWithProjectName(string projectName)
    {
        GotoSearchProject();
        ElementExtensions.EnterText(_projectNameTextbox,projectName);
        ElementExtensions.ClickOnElement(_btnSearch);
    }
    
}