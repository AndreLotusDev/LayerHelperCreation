using System.Text;

namespace LayerHelperCreation.Shared
{
    public class AppServiceController
    {
        private readonly UserConfig _uc;
        private readonly ProgramController _pc;
        public AppServiceController(UserConfig uc, ProgramController pc)
        {
            _uc = uc;
            _pc = pc;

            MapPreConfiguredValues();
        }

        private void MapPreConfiguredValues()
        {
            appServiceBasePath = _uc.BaseAppServicePath;
            appServiceInterfacesBasePath = _uc.BaseAppServiceInterfacePath;
            appServiceInjectionFilePath = _uc.FileAppServiceInjectionPath;
        }

        public string appServiceBasePath = "";
        public string appServiceInterfacesBasePath = "";

        public string appServiceInjectionFilePath = "";

        public string formatAppServiceInjectionForRepository = "services.AddTransient<INTERFACE, CONCRETE>();";

        public void AddNewEntityInAppServiceInjection()
        {
            var tempInjection = formatAppServiceInjectionForRepository;
            tempInjection = tempInjection.Replace("INTERFACE", "I" + _pc.entityName + "Service");
            tempInjection = tempInjection.Replace("CONCRETE", _pc.entityName + "Service");

            var fileRepositoryTxt = File.ReadAllLines(appServiceInjectionFilePath).ToList();
            var indexOfAutomaticAdding = fileRepositoryTxt.Select(s => s.Trim()).ToList().IndexOf("//AUTOMATIC_REGISTER");
            if (indexOfAutomaticAdding == -1)
            {
                MessageBox.Show("Errow finding position");
            }
            else
            {
                indexOfAutomaticAdding++;
            }

            var sb = new StringBuilder();
            sb.Append("\t").Append("\t").Append("\t").Append(tempInjection);

            fileRepositoryTxt.Insert(indexOfAutomaticAdding, sb.ToString());
            File.WriteAllLines(appServiceInjectionFilePath, fileRepositoryTxt);
        }

        public void AddNewEntityInAppServiceInterface()
        {
            var fileAppService = File.ReadAllLines("./Files/app_service_interface.txt").ToList();
            var indexOfToReplace = fileAppService.Select(s => s.Trim()).ToList().IndexOf("public interface [APP_SERVICE_INTERFACE_NAME]");
            if (indexOfToReplace == -1)
            {
                return;
            }

            fileAppService[indexOfToReplace] = fileAppService[indexOfToReplace]
                .Replace("[APP_SERVICE_INTERFACE_NAME]", "I" + _pc.entityName + "Service");

            var fullPathName = appServiceInterfacesBasePath + @"\" + $"I{_pc.entityName}Service.cs";
            var created = File.Create(fullPathName);
            created.Dispose();
            File.WriteAllLines(fullPathName, fileAppService);
        }

        public void AddNewEntityInAppServiceConcrete()
        {
            var fileAppService = File.ReadAllLines("./Files/app_service_concrete_class.txt").ToList();
            var trimmedLines = fileAppService.Select(s => s.Trim()).ToList();

            var indexOfToReplace = trimmedLines.IndexOf("public class [APP_SERVICE_CLASS] : [APP_INTERFACE_SERVICE_CLASS]");
            if (indexOfToReplace == -1)
            {
                return;
            }

            var indexOfConstructor = -1;
            var actualIndex = 0;

            foreach (var lineToCheck in trimmedLines)
            {
                if (lineToCheck.Contains(" [APP_SERVICE_CLASS] "))
                    indexOfConstructor = actualIndex;

                actualIndex++;
            }

            if (indexOfConstructor == -1)
            {
                return;
            }

            fileAppService[indexOfConstructor] = fileAppService[indexOfConstructor].Replace(" [APP_SERVICE_CLASS] ", " " + _pc.entityName + "Service");

            fileAppService[indexOfToReplace] = fileAppService[indexOfToReplace]
                .Replace("[APP_SERVICE_CLASS]", _pc.entityName + "Service")
                .Replace("[APP_INTERFACE_SERVICE_CLASS]", "I" + _pc.entityName + "Service");

            var fullPathName = appServiceBasePath + @"\" + $"{_pc.entityName}Service.cs";
            var created = File.Create(fullPathName);
            created.Dispose();
            File.WriteAllLines(fullPathName, fileAppService);
        }
    }
}
