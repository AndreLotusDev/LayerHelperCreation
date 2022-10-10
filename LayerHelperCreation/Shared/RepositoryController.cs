using System.Text;

namespace LayerHelperCreation.Shared
{
    public class RepositoryController
    {
        private readonly UserConfig _uc;
        private readonly ProgramController _pc;

        public RepositoryController(UserConfig uc, ProgramController pc)
        {
            _uc = uc;
            _pc = pc;

            MapPreConfiguredValues();
        }

        private void MapPreConfiguredValues()
        {
            repositoryBasePath = _uc.BaseRepositoryPath;
            repositoryInterfacesBasePath = _uc.BaseRepositoryInterfacePath;          
            repositoryInjectionFilePath = _uc.FileRepositoryInjectionPath;
        }

        public string repositoryBasePath = "";
        public string repositoryInterfacesBasePath = "";

        public string repositoryInjectionFilePath = "";
        public string formatServiceInjectionForRepository = "services.AddTransient<INTERFACE, CONCRETE>();";

        public void AddNewEntityInRepositoryInjection()
        {
            var tempInjection = formatServiceInjectionForRepository;
            tempInjection = tempInjection.Replace("INTERFACE", "I" + _pc.entityName + "Repository");
            tempInjection = tempInjection.Replace("CONCRETE", _pc.entityName + "Repository");

            var fileRepositoryTxt = File.ReadAllLines(repositoryInjectionFilePath).ToList();
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
            File.WriteAllLines(repositoryInjectionFilePath, fileRepositoryTxt);
        }

        public void AddNewEntityInRepositoryInterface()
        {
            var fileRepositoryTxt = File.ReadAllLines("./Files/repository_interface.txt").ToList();
            var indexOfToReplace = fileRepositoryTxt.Select(s => s.Trim()).ToList().IndexOf("public interface [NAME_CHANGE_REPOSITORY_INTERFACE] : IGenericAsyncRepository<[NAME_CHANGE_BASE_ENTITY]>");
            if (indexOfToReplace == -1)
            {
                return;
            }

            fileRepositoryTxt[indexOfToReplace] = fileRepositoryTxt[indexOfToReplace]
                .Replace("[NAME_CHANGE_REPOSITORY_INTERFACE]", "I" + _pc.entityName + "Repository")
                .Replace("[NAME_CHANGE_BASE_ENTITY]", _pc.entityName);;

            var fullPathName = repositoryInterfacesBasePath + @"\" + $"I{_pc.entityName}Repository.cs";
            var created = File.Create(fullPathName);
            created.Dispose();
            File.WriteAllLines(fullPathName, fileRepositoryTxt);
        }

        public void AddNewEntityInRepositoryConcrete()
        {
            var fileRepositoryTxt = File.ReadAllLines("./Files/repository_concrete_class.txt").ToList();
            var trimmedLines = fileRepositoryTxt.Select(s => s.Trim()).ToList();

            var indexOfToReplace = trimmedLines.IndexOf("public class [NAME_CHANGE_REPOSITORY] : GenericAsyncRepository<[NAME_CHANGE_BASE_ENTITY]>, [INTERFACE_REPOSITORY_GENERATED]");
            if (indexOfToReplace == -1)
            {
                return;
            }

            var indexOfConstructor = -1;
            var actualIndex = 0;

            foreach (var lineToCheck in trimmedLines)
            {
                if (lineToCheck.Contains(" [NAME_CHANGE_REPOSITORY] "))
                    indexOfConstructor = actualIndex;

                actualIndex++;
            }

            if (indexOfConstructor == -1)
            {
                return;
            }

            fileRepositoryTxt[indexOfConstructor] = fileRepositoryTxt[indexOfConstructor].Replace(" [NAME_CHANGE_REPOSITORY] ", " " + _pc.entityName + "Repository");

            fileRepositoryTxt[indexOfToReplace] = fileRepositoryTxt[indexOfToReplace]
                .Replace("[NAME_CHANGE_REPOSITORY]", _pc.entityName + "Repository")
                .Replace("[NAME_CHANGE_BASE_ENTITY]", _pc.entityName)
                .Replace("[INTERFACE_REPOSITORY_GENERATED]", "I" + _pc.entityName + "Repository");

            var fullPathName = repositoryBasePath + @"\" + $"{_pc.entityName}Repository.cs";
            var created = File.Create(fullPathName);
            created.Dispose();
            File.WriteAllLines(fullPathName, fileRepositoryTxt);
        }
    }
}
