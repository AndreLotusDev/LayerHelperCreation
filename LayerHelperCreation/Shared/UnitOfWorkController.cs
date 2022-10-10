using System.Text;

namespace LayerHelperCreation.Shared
{
    public class UnitOfWorkController
    {
        private readonly UserConfig _uc;
        private readonly ProgramController _pc;

        public UnitOfWorkController(UserConfig uc, ProgramController pc)
        {
            _uc = uc;
            _pc = pc;

            unitOfWorkConcreteFilePath = _uc.UnitOfWorkConcretePath;
            unitOfWorkInterfaceFilePath = _uc.UnitOfWorkInterfacePath;
        }

        public string unitOfWorkConcreteFilePath = "";
        public string unitOfWorkInterfaceFilePath = "";

        public const string NEW_LINE_FOR_INTERFACE = @"[REPOSITORY_INTERFACE] [PROPERTY_REPOSITORY_CONCRETE] { get; }";

        public const string PRIVATE_FIELD_FOR_CONCRETE = @"private [REPOSITORY_INTERFACE] [PRIVATE_UNDERLINE_PROPERTY_REPOSITORY_CONCRETE] = null;";
        public const string PUBLIC_UOF_REPOSITORY_CONCRETE = @"public [REPOSITORY_INTERFACE] [PROPERTY_REPOSITORY_CONCRETE] => [PRIVATE_UNDERLINE_PROPERTY_REPOSITORY_CONCRETE] ?? new [REPOSITORY_CONCRETE] (Context);";

        public void AddNewEntityInUofInterfaceInjection()
        {
            var uofInterfaceFile = File.ReadAllLines(unitOfWorkInterfaceFilePath).ToList();
            var indexOfAutomaticAdding = uofInterfaceFile.Select(s => s.Trim()).ToList().IndexOf("//AUTOMATIC_REGISTER");
            if (indexOfAutomaticAdding == -1)
            {
                MessageBox.Show("Errow finding position");
            }
            else
            {
                indexOfAutomaticAdding++;
            }

            var toInject = NEW_LINE_FOR_INTERFACE.Replace("[REPOSITORY_INTERFACE]", "I" + _pc.entityName + "Repository").Replace("[PROPERTY_REPOSITORY_CONCRETE]", _pc.entityName + "Repository");

            var sb = new StringBuilder();
            sb.Append("\t").Append("\t").Append(toInject)
            .AppendLine();

            uofInterfaceFile.Insert(indexOfAutomaticAdding, sb.ToString());
            File.WriteAllLines(unitOfWorkInterfaceFilePath, uofInterfaceFile);
        }

        public void AddNewEntityInUofInjection()
        {
            var uocConcreteFile = File.ReadAllLines(unitOfWorkConcreteFilePath).ToList();
            var indexOfAutomaticAdding = uocConcreteFile.Select(s => s.Trim()).ToList().IndexOf("//AUTOMATIC_REGISTER");
            if (indexOfAutomaticAdding == -1)
            {
                MessageBox.Show("Errow finding position");
            }
            else
            {
                indexOfAutomaticAdding++;
            }

            var underlinePrivateField = "_" + _pc.entityName[0].ToString().ToLower() + _pc.entityName.Substring(1) + "Repository"; 

            var toInjectPrivate = PRIVATE_FIELD_FOR_CONCRETE
                .Replace("[REPOSITORY_INTERFACE]", "I" + _pc.entityName + "Repository")
                .Replace("[PRIVATE_UNDERLINE_PROPERTY_REPOSITORY_CONCRETE]", underlinePrivateField);

            var toInject = PUBLIC_UOF_REPOSITORY_CONCRETE
                .Replace("[REPOSITORY_INTERFACE]", "I" + _pc.entityName + "Repository")
                .Replace("[PROPERTY_REPOSITORY_CONCRETE]", _pc.entityName + "Repository")
                .Replace("[PRIVATE_UNDERLINE_PROPERTY_REPOSITORY_CONCRETE]", underlinePrivateField)
                .Replace("[REPOSITORY_CONCRETE]", _pc.entityName + "Repository");

            var sb = new StringBuilder();
            sb.Append("\t").Append("\t").Append(toInjectPrivate)
            .AppendLine()
            .Append("\t").Append("\t").Append(toInject)
            .AppendLine();

            uocConcreteFile.Insert(indexOfAutomaticAdding, sb.ToString());
            File.WriteAllLines(unitOfWorkConcreteFilePath, uocConcreteFile);
        }
    }
}
