using System.Text.Json;

namespace LayerHelperCreation.Shared
{
    public class UserConfig
    {
        public string BaseRepositoryPath { get; set; } = "";
        public string BaseRepositoryInterfacePath { get; set; } = "";
        public string FileRepositoryInjectionPath { get; set; } = "";

        public string BaseBusinessPath { get; set; } = "";
        public string BaseBusinessInterfacePath { get; set; } = "";
        public string FileBusinessInjectionPath { get; set; } = "";

        public string BaseAppServicePath { get; set; } = "";
        public string BaseAppServiceInterfacePath { get; set; } = "";
        public string FileAppServiceInjectionPath { get; set; } = "";

        public string UnitOfWorkConcretePath { get; set; } = "";
        public string UnitOfWorkInterfacePath { get; set; } = "";

        public UserConfig()
        {
            
        }

        public void Map()
        {
            _map();
        }

        public void _map()
        {
            var configLines = String.Join("", File.ReadLines("./Files/Config.json"));

            var configurations = JsonSerializer.Deserialize<UserConfig>(configLines, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (configurations == null)
                return;

            BaseRepositoryPath = configurations.BaseRepositoryPath;
            BaseRepositoryInterfacePath = configurations.BaseRepositoryInterfacePath;
            FileRepositoryInjectionPath = configurations.FileRepositoryInjectionPath;

            UnitOfWorkConcretePath = configurations.UnitOfWorkConcretePath;
            UnitOfWorkInterfacePath = configurations.UnitOfWorkInterfacePath;

            BaseBusinessPath = configurations.BaseBusinessPath;
            BaseBusinessInterfacePath = configurations.BaseBusinessInterfacePath;
            FileBusinessInjectionPath = configurations.FileBusinessInjectionPath;

            BaseAppServicePath = configurations.BaseAppServicePath;
            BaseAppServiceInterfacePath = configurations.BaseAppServiceInterfacePath;
            FileAppServiceInjectionPath = configurations.FileAppServiceInjectionPath;

        }
    }
}
