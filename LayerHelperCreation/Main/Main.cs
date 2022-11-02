using LayerHelperCreation.Shared;

namespace LayerHelperCreation
{
    public partial class Main : InjectableForm
    {
        private RepositoryController rc;
        private UnitOfWorkController uc;
        private BusinessController bc;
        private AppServiceController ac;

        private ProgramController pc;

        public Main()
        {

            InitializeComponent();

            rc = Injectable.Resolve<RepositoryController>();
            uc = Injectable.Resolve<UnitOfWorkController>();
            bc = Injectable.Resolve<BusinessController>();
            ac = Injectable.Resolve<AppServiceController>();

            pc = Injectable.Resolve<ProgramController>();

            txtPathRepositoryBase.Text = rc.repositoryBasePath;
            txtPathRepositoryInterface.Text = rc.repositoryInterfacesBasePath;
            txtPathRepositoryInjection.Text = rc.repositoryInjectionFilePath;

            txtUOFInterfacePath.Text = uc.unitOfWorkInterfaceFilePath;
            txtUOFConcretePath.Text = uc.unitOfWorkConcreteFilePath;

            txtBusinessBaseInterfacePath.Text = bc.businessInterfacesBasePath;
            txtBusinessBasePath.Text = bc.businessBasePath;
            txtBusinessInjectionFile.Text = bc.businessInjectionFilePath;

            txtBaseAppServicePath.Text = ac.appServiceBasePath;
            txtAppServiceInterfacePath.Text = ac.appServiceInterfacesBasePath;
            txtAppServiceFile.Text = ac.appServiceInjectionFilePath;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ckdLstLayers.Items.Count; i++)
                ckdLstLayers.SetItemChecked(i, true);
        }

        private void ckdLstLayers_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke(() => checkingItemsChecked());
        }

        private void checkingItemsChecked()
        {
            return;

            var checkedBoxs = ckdLstLayers.CheckedItems.OfType<object>();

            if (checkedBoxs is null)
                return;

            var pages = tabForEachLayer.TabPages.OfType<TabPage>();

            foreach (var chkBox in checkedBoxs)
            {
                if (pages.Any(a => a.AccessibilityObject.Name.ToUpper() == chkBox.ToString().ToUpper()))
                    continue;

                tabForEachLayer.TabPages.Add(chkBox.ToString());
            }

            foreach (var page in pages)
            {
                var doesntExistAnymore = !checkedBoxs.Any(a => a.ToString().ToUpper() == page.AccessibilityObject.Name.ToUpper());

                if (doesntExistAnymore)
                {
                    tabForEachLayer.TabPages.Remove(page);
                }
            }
        }

        private void tabForEachLayer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private TabPage GetActiveTabPage() => tabForEachLayer.SelectedTab;

        private void btnSearchFolderUOF_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();

            var result = fileDialog.ShowDialog();

            if (!(result == DialogResult.OK))
                return;

            if (!FormatAccepteds.Formats.Any(a => fileDialog.FileName.ToLower().Contains(a.ToLower())))
            {
                MessageBox.Show("Invalid format");
                return;
            }

            txtUOFConcretePath.Text = fileDialog.FileName;
            uc.unitOfWorkConcreteFilePath = fileDialog.FileName;
        }

        private void btnInjectionLocation_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();

            var result = fileDialog.ShowDialog();

            if (!(result == DialogResult.OK))
                return;

            if (!FormatAccepteds.Formats.Any(a => fileDialog.FileName.ToLower().Contains(a.ToLower())))
            {
                MessageBox.Show("Invalid format");
                return;
            }

            txtUOFInterfacePath.Text = fileDialog.FileName;
            uc.unitOfWorkInterfaceFilePath = fileDialog.FileName;
        }

        private void btnSearchRepositoryBase_Click(object sender, EventArgs e)
        {
            var browserDialog = new FolderBrowserDialog();

            var result = browserDialog.ShowDialog();

            if (!(result == DialogResult.OK))
                return;

            txtPathRepositoryBase.Text = browserDialog.SelectedPath;
            rc.repositoryBasePath = browserDialog.SelectedPath;
        }

        private void btnSearchRepositoryInterfacePath_Click(object sender, EventArgs e)
        {
            var browserDialog = new FolderBrowserDialog();

            var result = browserDialog.ShowDialog();

            if (!(result == DialogResult.OK))
                return;

            txtPathRepositoryInterface.Text = browserDialog.SelectedPath;
            rc.repositoryInterfacesBasePath = browserDialog.SelectedPath;
        }

        private void btnSearchRepositoryInjection_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();

            var result = fileDialog.ShowDialog();

            if (!(result == DialogResult.OK))
                return;

            if (!FormatAccepteds.Formats.Any(a => fileDialog.FileName.ToLower().Contains(a.ToLower())))
            {
                MessageBox.Show("Invalid format");
                return;
            }

            txtPathRepositoryInjection.Text = fileDialog.FileName;
            rc.repositoryInjectionFilePath = fileDialog.FileName;
        }

        private void btnSearchBusinessBase_Click(object sender, EventArgs e)
        {
            var browserDialog = new FolderBrowserDialog();

            var result = browserDialog.ShowDialog();

            if (!(result == DialogResult.OK))
                return;

            txtBusinessBasePath.Text = browserDialog.SelectedPath;
            bc.businessBasePath = browserDialog.SelectedPath;
        }

        private void btnSearchBusinessInterfaceBase_Click(object sender, EventArgs e)
        {
            var browserDialog = new FolderBrowserDialog();

            var result = browserDialog.ShowDialog();

            if (!(result == DialogResult.OK))
                return;

            txtBusinessBaseInterfacePath.Text = browserDialog.SelectedPath;
            bc.businessInterfacesBasePath = browserDialog.SelectedPath;
        }

        private void btnSearchInjectionFile_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();

            var result = fileDialog.ShowDialog();

            if (!(result == DialogResult.OK))
                return;

            if (!FormatAccepteds.Formats.Any(a => fileDialog.FileName.ToLower().Contains(a.ToLower())))
            {
                MessageBox.Show("Invalid format");
                return;
            }

            txtBusinessInjectionFile.Text = fileDialog.FileName;
            bc.businessInjectionFilePath = fileDialog.FileName;
        }

        private void btnCreateAutomaticLayers_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtEntityName.Text))
                return;

            pc.entityName = txtEntityName.Text;

            var options = string.Join("", ckdLstLayers.CheckedItems.OfType<object>().Select(s => s.ToString().ToLower() + " | ").ToList());

            if(options.Contains("repository"))
            {
                rc.AddNewEntityInRepositoryInterface();
                rc.AddNewEntityInRepositoryConcrete();
                rc.AddNewEntityInRepositoryInjection();
            }

            if(options.Contains("business"))
            {
                bc.AddNewEntityInBusinessInterface();
                bc.AddNewEntityInBusinessConcrete();
                bc.AddNewEntityInBusinessInjection();
            }
            
            if(options.Contains("appservice"))
            {
                ac.AddNewEntityInAppServiceInterface();
                ac.AddNewEntityInAppServiceConcrete();
                ac.AddNewEntityInAppServiceInjection();
            }
            
            if(options.Contains("unitofwork"))
            {
                uc.AddNewEntityInUofInterfaceInjection();
                uc.AddNewEntityInUofInjection();
            }

            MessageBox.Show("Added with success!");
        } 
    }
}