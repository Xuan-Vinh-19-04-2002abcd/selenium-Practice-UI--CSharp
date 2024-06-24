using Microsoft.Extensions.Configuration;
using Test.Builder.CreateProjectParamater;
using Test.Core;
using Test.Pages;

namespace Test.Test;

public class CreateProjectTest : BaseTest
{
    public static IConfiguration config;
    private ProjectInformationPage _projectInformation;
    private CreateProjectPage _createProject;
    private LoginPage _loginPage;
    public CreateProjectTest(): base()
    {
        _createProject = CreateProjectPage.GetInstance();
        _loginPage = LoginPage.GetInstance();
        _projectInformation = ProjectInformationPage.GetInstance();
    }
    [SetUp]
    public void SetUp()
    {
        _loginPage.Login("admin","admin");
    }
    [Test]
    [TestCaseSource(nameof(GetAllProjectTypeJson))]
    public void CreateProjectWithAllField(
        string projectName, 
        string projectType, 
        string projectStatus, 
        string sizeDay, 
        string location, 
        string projectManager, 
        string startDate, 
        string endDate,
        string deliveryProject, 
        string engagementManager, 
        string shortDescription, 
        string longDescription, 
        string technologies, 
        string clientName, 
        string clientIndustry, 
        string clientDescription)
    {
        
        Project project = new ProjectBuilder()
            .SetProjectName(projectName)
            .SetProjectType(projectType)
            .SetProjectStatus(projectStatus)
            .SetSizeDay(sizeDay)
            .SetLocation(location)
            .SetProjectManager(projectManager)
            .SetStartDate(startDate)
            .SetEndDate(endDate)
            .SetDeliveryManager(deliveryProject)
            .SetEngagementManager(engagementManager)
            .SetShortDescription(shortDescription)
            .SetLongDescription(longDescription)
            .SetTechnologies(technologies)
            .SetClientName(clientName)
            .SetClientIndustry(clientIndustry)
            .SetClientDescription(clientDescription)
            .Build();
        _createProject.CreateProject(project);
        var projectInformation = _projectInformation.GetProjectInformation();
        bool isMatch = _createProject.AreProjectAttributesMatching(project, projectInformation);
        Assert.IsTrue(isMatch, "One or more project attributes do not match the project information.");
        
    }
    public static object[] GetAllProjectTypeJson()
    {
        const string AppSettingPath = "Configuration\\project.json";
        config = Configuration.Initialize(AppSettingPath);
        var listProjects = Configuration.GetProjectsByKey(config, "Projects");

        if (listProjects == null || !listProjects.Any()) 
        {
            return new object[0]; 
        }
        
        var projectTypeData = new object[listProjects.Count];
        
        for (int i = 0; i < listProjects.Count; i++)
        {
            projectTypeData[i] = new object[]
            {
                listProjects[i].ProjectName, listProjects[i].ProjectType, 
                listProjects[i].ProjectStatus, listProjects[i].SizeDay,
                listProjects[i].Location, listProjects[i].ProjectManager, 
                listProjects[i].StartDate,listProjects[i].EndDate,
                listProjects[i].DeliveryManager, listProjects[i].EngagementManager, 
                listProjects[i].ShortDescription, listProjects[i].LongDescription, 
                listProjects[i].Technology, listProjects[i].ClientName, 
                listProjects[i].ClientIndustry, listProjects[i].ClientDescription
            };
        }

        return projectTypeData;
    }

    
}