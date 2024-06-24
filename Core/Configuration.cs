using Microsoft.Extensions.Configuration;
using System.IO;
using Test.Builder.CreateProjectParamater;

namespace Test.Core
{
    public class Configuration
    {

        public static IConfiguration Initialize(string path)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(path)
                .Build();
            return config;

        }

        public static string GetConfigurationByKey(IConfiguration config, string key)
        {
            var value = config[key];
            if (!string.IsNullOrEmpty(value)) return value;
            var message = "gh";
            throw new InvalidDataException(message);
        }

        public static List<Project> GetProjectsByKey(IConfiguration config, string key)
        {
            var projectsSection = config.GetSection(key);
            var listProjects = new List<Project>();

            if (projectsSection != null)
            {
                var projectIndex = 0; 

                foreach (var childSection in projectsSection.GetChildren())
                {
                    var project = new ProjectBuilder()
                        .SetProjectName(childSection["ProjectName"])
                        .SetProjectType(childSection["ProjectType"])
                        .SetProjectStatus(childSection["ProjectStatus"])
                        .SetSizeDay(childSection["SizeDay"])
                        .SetLocation(childSection["Location"])
                        .SetProjectManager(childSection["ProjectManager"])
                        .SetStartDate(childSection["StartDate"])
                        .SetEndDate(childSection["EndDate"])
                        .SetDeliveryManager(childSection["DeliveryManager"])
                        .SetEngagementManager(childSection["EngagementManager"])
                        .SetShortDescription(childSection["ShortDescription"])
                        .SetLongDescription(childSection["LongDescription"])
                        .SetTechnologies(childSection["Technology"])
                        .SetClientName(childSection["ClientName"])
                        .SetClientIndustry(childSection["ClientIndustry"])
                        .SetClientDescription(childSection["ClientDescription"])
                        .Build();
                    listProjects.Add(project);
                    projectIndex++; 
                }
            }

            return listProjects;
        }
        
        
        
    }
}