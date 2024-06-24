namespace Test.Builder.CreateProjectParamater;

public interface IProjectDetails 
{
    IProjectBuilder SetProjectName(string name);
    IProjectBuilder SetProjectType(string projectType);
    IProjectBuilder SetProjectStatus(string projectStatus);
    IProjectBuilder SetSizeDay(string sizeDay);
    IProjectBuilder SetLocation(string location);
}
public interface IProjectTiming 
{
    IProjectBuilder SetStartDate(string startDate);
    IProjectBuilder SetEndDate(string endDate);
}
public interface IProjectDescription 
{
    IProjectBuilder SetShortDescription(string sortDescription);
    IProjectBuilder SetLongDescription(string longDescription);
}

public interface IProjectTechnologies 
{
    IProjectBuilder SetTechnologies(string technologies);
}
public interface IProjectManagement 
{
    IProjectBuilder SetProjectManager(string projectManager);
    IProjectBuilder SetDeliveryManager(string deliveryManager);
    IProjectBuilder SetEngagementManager(string engagementManager);
}
public interface IClientDetails 
{
    IProjectBuilder SetClientName(string clientName);
    IProjectBuilder SetClientIndustry(string clientIndustry);
    IProjectBuilder SetClientDescription(string clientDescription);
}
    
public interface IProjectBuilder : IProjectDetails, IProjectTiming,IProjectDescription,IProjectTechnologies,IProjectManagement,IClientDetails
{
    Project Build();
}