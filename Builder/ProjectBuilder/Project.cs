namespace Test.Builder.CreateProjectParamater;

public class Project
{
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
    public Project(string projectName, string projectType, string startDate,
        string projectStatus, string endDate, string sizeDay, string location,
        string projectManager, string deliveryManager,
        string engagementManager, string shortDescription, string longDescription,
        string technology, string clientName, string clientDescription,
        string clientIndustry)
    {
        _projectName = projectName;
        _projectType = projectType;
        _startDate = startDate;
        _projectStatus = projectStatus;
        _endDate = endDate;
        _sizeDay = sizeDay;
        _location = location;
        _projectManager = projectManager;
        _deliveryManager = deliveryManager;
        _engagementManager = engagementManager;
        _shortDescription = shortDescription;
        _longDescription = longDescription;
        _technology = technology;
        _clientName = clientName;
        _clientDescription = clientDescription;
        _clientIndustry = clientIndustry;
    }
    public string ProjectName { get => _projectName; set => _projectName = value; }
    public string ProjectType { get => _projectType; set => _projectType = value; }
    public string StartDate { get => _startDate; set => _startDate = value; }
    public string ProjectStatus { get => _projectStatus; set => _projectStatus = value; }
    public string EndDate { get => _endDate; set => _endDate = value; }
    public string SizeDay { get => _sizeDay; set => _sizeDay = value; }
    public string Location { get => _location; set => _location = value; }
    public string ProjectManager { get => _projectManager; set => _projectManager = value; }
    public string DeliveryManager { get => _deliveryManager; set => _deliveryManager = value; }
    public string EngagementManager { get => _engagementManager; set => _engagementManager = value; }
    public string ShortDescription { get => _shortDescription; set => _shortDescription = value; }
    public string LongDescription { get => _longDescription; set => _longDescription = value; }
    public string Technology { get => _technology; set => _technology = value; }
    public string ClientName { get => _clientName; set => _clientName = value; }
    public string ClientDescription { get => _clientDescription; set => _clientDescription = value; }
    public string ClientIndustry { get => _clientIndustry; set => _clientIndustry = value; }
    
}