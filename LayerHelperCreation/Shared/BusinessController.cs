using System.Text;

namespace LayerHelperCreation.Shared
{
    public class BusinessController
    {
        private readonly UserConfig _uc;
        private readonly ProgramController _pc;
        public BusinessController(UserConfig uc, ProgramController pc)
        {
            _uc = uc;
            _pc = pc;

            MapPreConfiguredValues();
        }

        private void MapPreConfiguredValues()
        {
            businessBasePath = _uc.BaseBusinessPath;
            businessInterfacesBasePath = _uc.BaseBusinessInterfacePath;
            businessInjectionFilePath = _uc.FileBusinessInjectionPath;
        }

        public string businessBasePath = "";
        public string businessInterfacesBasePath = "";

        public string businessInjectionFilePath = "";

        public string formatBusinessServiceInjectionForRepository = "services.AddTransient<INTERFACE, CONCRETE>();";

        public void AddNewEntityInBusinessInjection()
        {
            var tempInjection = formatBusinessServiceInjectionForRepository;
            tempInjection = tempInjection.Replace("INTERFACE", "I" + _pc.entityName + "Business");
            tempInjection = tempInjection.Replace("CONCRETE", _pc.entityName + "Business");

            var fileBusinessTxt = File.ReadAllLines(businessInjectionFilePath).ToList();
            var indexOfAutomaticAdding = fileBusinessTxt.Select(s => s.Trim()).ToList().IndexOf("//AUTOMATIC_REGISTER");
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

            fileBusinessTxt.Insert(indexOfAutomaticAdding, sb.ToString());
            File.WriteAllLines(businessInjectionFilePath, fileBusinessTxt);
        }

        public void AddNewEntityInBusinessInterface()
        {
            var fileBusiness = File.ReadAllLines("./Files/business_interface.txt").ToList();
            var indexOfToReplace = fileBusiness.Select(s => s.Trim()).ToList().IndexOf("public interface [ENTITY_INTERFACE_BUSINESS]");
            if (indexOfToReplace == -1)
            {
                return;
            }

            fileBusiness[indexOfToReplace] = fileBusiness[indexOfToReplace]
                .Replace("[ENTITY_INTERFACE_BUSINESS]", "I" + _pc.entityName + "Business");

            var fullPathName = businessInterfacesBasePath + @"\" + $"I{_pc.entityName}Business.cs";
            var created = File.Create(fullPathName);
            created.Dispose();
            File.WriteAllLines(fullPathName, fileBusiness);
        }

        public void AddNewEntityInBusinessConcrete()
        {
            var fileBusiness = File.ReadAllLines("./Files/business_concrete_class.txt").ToList();
            var trimmedLines = fileBusiness.Select(s => s.Trim()).ToList();

            var indexOfToReplace = trimmedLines.IndexOf("public class [ENTITY_BUSINESS] : BaseBusiness, [ENTITY_INTERFACE_BUSINESS]");
            if (indexOfToReplace == -1)
            {
                return;
            }

            var indexOfConstructor = -1;
            var actualIndex = 0;

            foreach (var lineToCheck in trimmedLines)
            {
                if (lineToCheck.Contains(" [ENTITY_BUSINESS] "))
                    indexOfConstructor = actualIndex;

                actualIndex++;
            }

            if (indexOfConstructor == -1)
            {
                return;
            }

            fileBusiness[indexOfConstructor] = fileBusiness[indexOfConstructor].Replace(" [ENTITY_BUSINESS] ", " " + _pc.entityName + "Business");

            fileBusiness[indexOfToReplace] = fileBusiness[indexOfToReplace]
                .Replace("[ENTITY_BUSINESS]", _pc.entityName + "Business")
                .Replace("[ENTITY_INTERFACE_BUSINESS]", "I" + _pc.entityName + "Business");

            var fullPathName = businessBasePath + @"\" + $"{_pc.entityName}Business.cs";
            var created = File.Create(fullPathName);
            created.Dispose();
            File.WriteAllLines(fullPathName, fileBusiness);
        }
    }
}
