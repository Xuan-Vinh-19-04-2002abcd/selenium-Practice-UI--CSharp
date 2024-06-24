namespace Test.Builder.CreateProjectParamater;

public class ProjectBuilder : IProjectBuilder {
    private string _projectName;
    private string _projectType;
    private string _startDate;
    private string _projectStatus;
    private string _endDate;
    private string _sizeDay;
    private string _location;
    private string _projectManager;
    private string _deliveryManager;
    private string _engagementManager;
    private string _shortDescription;
    private string _longDescription;
    private string _technology;
    private string _clientName;
    private string _clientDescription;
    private string _clientIndustry;

    public IProjectBuilder SetProjectName(string name)
    {
        _projectName = name;
        return this;
    }

    public IProjectBuilder SetProjectType(string projectType)
    {
        _projectType = projectType;
        return this;
    }

    public IProjectBuilder SetProjectStatus(string projectStatus)
    {
        _projectStatus = projectStatus;
        return this;
    }

    public IProjectBuilder SetSizeDay(string sizeDay)
    {
        _sizeDay = sizeDay;
        return this;
    }

    public IProjectBuilder SetLocation(string location)
    {
        _location = location;
        return this;
    }

    public IProjectBuilder SetStartDate(string startDate)
    {
        _startDate = startDate;
        return this;
    }

    public IProjectBuilder SetEndDate(string endDate)
    {
        _endDate = endDate;
        return this;
    }

    public IProjectBuilder SetProjectManager(string projectManager)
    {
        _projectManager = projectManager;
        return this;
    }

    public IProjectBuilder SetDeliveryManager(string deliveryManager)
    {
        _deliveryManager = deliveryManager;
        return this;
    }

    public IProjectBuilder SetEngagementManager(string engagementManager)
    {
        _engagementManager = engagementManager;
        return this;
    }

    public IProjectBuilder SetTechnologies(string technologies)
    {
        _technology = technologies;
        return this;
    }

    public IProjectBuilder SetShortDescription(string sortDescription)
    {
        _shortDescription = sortDescription;
        return this;
    }

    public IProjectBuilder SetLongDescription(string longDescription)
    {
        _longDescription = longDescription;
        return this;
    }

    public IProjectBuilder SetClientName(string clientName)
    {
        _clientName = clientName;
        return this;
    }

    public IProjectBuilder SetClientIndustry(string clientIndustry)
    {
        _clientIndustry = clientIndustry;
        return this;
    }

    public IProjectBuilder SetClientDescription(string clientDescription)
    {
        _clientDescription = clientDescription;
        return this;
    }

    public Project Build()
    {
        return new Project(_projectName, _projectType, _startDate, _projectStatus, _endDate, _sizeDay,_location,_projectManager,_deliveryManager,_engagementManager,_shortDescription,_longDescription,_technology,_clientName,_clientDescription,_clientIndustry);
    }
}