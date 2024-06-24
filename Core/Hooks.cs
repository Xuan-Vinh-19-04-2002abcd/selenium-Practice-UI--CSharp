using Microsoft.Extensions.Configuration;

namespace Test.Core
{
    [SetUpFixture]
    public class Hooks
    {
        public static IConfiguration config;

        const string AppSettingPath = "Configuration\\appsetting.json";

        [OneTimeSetUp]
        public void MySetup()
        {
            TestContext.Progress.WriteLine("===> Global one time setup");

            config = Configuration.Initialize(AppSettingPath);
        }
    }
}
