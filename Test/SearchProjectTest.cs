using Test.Pages;

namespace Test.Test;

public class SearchProjectTest : BaseTest
{
    private SearchProject _searchProject;
    private LoginPage _loginPage;
    public SearchProjectTest(): base()
    {
        _searchProject = SearchProject.GetInstance();
        _loginPage = LoginPage.GetInstance();
    }
    [SetUp]
    public void SetUp()
    {
        _loginPage.Login("admin","admin");
    }
    

    [Test]
    [TestCase("TMS")]
    public void SearchProjectWithProjectNameSuccessfully(string projectName)
    {
        _searchProject.SearchProjectWithProjectName(projectName);
        bool allContainProjectName = _searchProject.GetAllProjectNames().All(projectName => projectName.Contains(projectName));
        Assert.IsTrue(allContainProjectName);
    }
    
}   