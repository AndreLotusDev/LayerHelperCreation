namespace LayerHelperCreation
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabViews = new System.Windows.Forms.TabControl();
            this.tabView = new System.Windows.Forms.TabPage();
            this.ckdLstLayers = new System.Windows.Forms.CheckedListBox();
            this.tabForEachLayer = new System.Windows.Forms.TabControl();
            this.tabAppService = new System.Windows.Forms.TabPage();
            this.lblAppServiceFile = new System.Windows.Forms.Label();
            this.lblBaseAppServiceInterfacePath = new System.Windows.Forms.Label();
            this.lblBaseAppServicePath = new System.Windows.Forms.Label();
            this.txtAppServiceInterfacePath = new System.Windows.Forms.TextBox();
            this.btnBaseAppServiceInterfacePath = new System.Windows.Forms.Button();
            this.txtAppServiceFile = new System.Windows.Forms.TextBox();
            this.btnBusinessAppServiceFile = new System.Windows.Forms.Button();
            this.txtBaseAppServicePath = new System.Windows.Forms.TextBox();
            this.btnBaseAppServicePath = new System.Windows.Forms.Button();
            this.tabBusinessService = new System.Windows.Forms.TabPage();
            this.lblBusinessInjectionFile = new System.Windows.Forms.Label();
            this.lblBaseBusinessInterfacePath = new System.Windows.Forms.Label();
            this.lblBaseBusinessPath = new System.Windows.Forms.Label();
            this.txtBusinessBaseInterfacePath = new System.Windows.Forms.TextBox();
            this.btnSearchBusinessInterfaceBase = new System.Windows.Forms.Button();
            this.txtBusinessInjectionFile = new System.Windows.Forms.TextBox();
            this.btnSearchInjectionFile = new System.Windows.Forms.Button();
            this.txtBusinessBasePath = new System.Windows.Forms.TextBox();
            this.btnSearchBusinessBase = new System.Windows.Forms.Button();
            this.tabRepositoryService = new System.Windows.Forms.TabPage();
            this.lblRepositoryInjectionFile = new System.Windows.Forms.Label();
            this.lblBaseRepositoryInterfacePath = new System.Windows.Forms.Label();
            this.lblBaseRepositoryPath = new System.Windows.Forms.Label();
            this.txtPathRepositoryInterface = new System.Windows.Forms.TextBox();
            this.btnSearchRepositoryInterfacePath = new System.Windows.Forms.Button();
            this.txtPathRepositoryInjection = new System.Windows.Forms.TextBox();
            this.btnSearchRepositoryInjection = new System.Windows.Forms.Button();
            this.txtPathRepositoryBase = new System.Windows.Forms.TextBox();
            this.btnSearchRepositoryBase = new System.Windows.Forms.Button();
            this.tabUnitOfWorkService = new System.Windows.Forms.TabPage();
            this.txtUOFInterfacePath = new System.Windows.Forms.TextBox();
            this.btnInjectionLocation = new System.Windows.Forms.Button();
            this.txtUOFConcretePath = new System.Windows.Forms.TextBox();
            this.btnSearchFolderUOF = new System.Windows.Forms.Button();
            this.tabCreation = new System.Windows.Forms.TabPage();
            this.lblEntity = new System.Windows.Forms.Label();
            this.txtEntityName = new System.Windows.Forms.TextBox();
            this.btnCreateAutomaticLayers = new System.Windows.Forms.Button();
            this.tabViews.SuspendLayout();
            this.tabView.SuspendLayout();
            this.tabForEachLayer.SuspendLayout();
            this.tabAppService.SuspendLayout();
            this.tabBusinessService.SuspendLayout();
            this.tabRepositoryService.SuspendLayout();
            this.tabUnitOfWorkService.SuspendLayout();
            this.tabCreation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabViews
            // 
            this.tabViews.Controls.Add(this.tabView);
            this.tabViews.Controls.Add(this.tabCreation);
            this.tabViews.Location = new System.Drawing.Point(12, 12);
            this.tabViews.Name = "tabViews";
            this.tabViews.SelectedIndex = 0;
            this.tabViews.Size = new System.Drawing.Size(1880, 1017);
            this.tabViews.TabIndex = 0;
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.ckdLstLayers);
            this.tabView.Controls.Add(this.tabForEachLayer);
            this.tabView.Location = new System.Drawing.Point(4, 24);
            this.tabView.Name = "tabView";
            this.tabView.Padding = new System.Windows.Forms.Padding(3);
            this.tabView.Size = new System.Drawing.Size(1872, 989);
            this.tabView.TabIndex = 0;
            this.tabView.Text = "Configurations";
            this.tabView.UseVisualStyleBackColor = true;
            // 
            // ckdLstLayers
            // 
            this.ckdLstLayers.FormattingEnabled = true;
            this.ckdLstLayers.Items.AddRange(new object[] {
            "AppService",
            "BusinessService",
            "RepositoryService",
            "UnitOfWorkService"});
            this.ckdLstLayers.Location = new System.Drawing.Point(6, 6);
            this.ckdLstLayers.Name = "ckdLstLayers";
            this.ckdLstLayers.Size = new System.Drawing.Size(1856, 76);
            this.ckdLstLayers.TabIndex = 1;
            this.ckdLstLayers.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ckdLstLayers_ItemCheck);
            // 
            // tabForEachLayer
            // 
            this.tabForEachLayer.Controls.Add(this.tabAppService);
            this.tabForEachLayer.Controls.Add(this.tabBusinessService);
            this.tabForEachLayer.Controls.Add(this.tabRepositoryService);
            this.tabForEachLayer.Controls.Add(this.tabUnitOfWorkService);
            this.tabForEachLayer.Location = new System.Drawing.Point(6, 91);
            this.tabForEachLayer.Name = "tabForEachLayer";
            this.tabForEachLayer.SelectedIndex = 0;
            this.tabForEachLayer.Size = new System.Drawing.Size(1860, 892);
            this.tabForEachLayer.TabIndex = 0;
            this.tabForEachLayer.SelectedIndexChanged += new System.EventHandler(this.tabForEachLayer_SelectedIndexChanged);
            // 
            // tabAppService
            // 
            this.tabAppService.Controls.Add(this.lblAppServiceFile);
            this.tabAppService.Controls.Add(this.lblBaseAppServiceInterfacePath);
            this.tabAppService.Controls.Add(this.lblBaseAppServicePath);
            this.tabAppService.Controls.Add(this.txtAppServiceInterfacePath);
            this.tabAppService.Controls.Add(this.btnBaseAppServiceInterfacePath);
            this.tabAppService.Controls.Add(this.txtAppServiceFile);
            this.tabAppService.Controls.Add(this.btnBusinessAppServiceFile);
            this.tabAppService.Controls.Add(this.txtBaseAppServicePath);
            this.tabAppService.Controls.Add(this.btnBaseAppServicePath);
            this.tabAppService.Location = new System.Drawing.Point(4, 24);
            this.tabAppService.Name = "tabAppService";
            this.tabAppService.Size = new System.Drawing.Size(1852, 864);
            this.tabAppService.TabIndex = 4;
            this.tabAppService.Text = "App Service";
            this.tabAppService.UseVisualStyleBackColor = true;
            // 
            // lblAppServiceFile
            // 
            this.lblAppServiceFile.AutoSize = true;
            this.lblAppServiceFile.Location = new System.Drawing.Point(119, 97);
            this.lblAppServiceFile.Name = "lblAppServiceFile";
            this.lblAppServiceFile.Size = new System.Drawing.Size(88, 15);
            this.lblAppServiceFile.TabIndex = 30;
            this.lblAppServiceFile.Text = "App Service file";
            // 
            // lblBaseAppServiceInterfacePath
            // 
            this.lblBaseAppServiceInterfacePath.AutoSize = true;
            this.lblBaseAppServiceInterfacePath.Location = new System.Drawing.Point(119, 52);
            this.lblBaseAppServiceInterfacePath.Name = "lblBaseAppServiceInterfacePath";
            this.lblBaseAppServiceInterfacePath.Size = new System.Drawing.Size(172, 15);
            this.lblBaseAppServiceInterfacePath.TabIndex = 29;
            this.lblBaseAppServiceInterfacePath.Text = "Base App Service interface path";
            // 
            // lblBaseAppServicePath
            // 
            this.lblBaseAppServicePath.AutoSize = true;
            this.lblBaseAppServicePath.Location = new System.Drawing.Point(119, 8);
            this.lblBaseAppServicePath.Name = "lblBaseAppServicePath";
            this.lblBaseAppServicePath.Size = new System.Drawing.Size(123, 15);
            this.lblBaseAppServicePath.TabIndex = 28;
            this.lblBaseAppServicePath.Text = "Base App Service path";
            // 
            // txtAppServiceInterfacePath
            // 
            this.txtAppServiceInterfacePath.Location = new System.Drawing.Point(119, 70);
            this.txtAppServiceInterfacePath.Name = "txtAppServiceInterfacePath";
            this.txtAppServiceInterfacePath.Size = new System.Drawing.Size(1730, 23);
            this.txtAppServiceInterfacePath.TabIndex = 27;
            // 
            // btnBaseAppServiceInterfacePath
            // 
            this.btnBaseAppServiceInterfacePath.Location = new System.Drawing.Point(9, 70);
            this.btnBaseAppServiceInterfacePath.Name = "btnBaseAppServiceInterfacePath";
            this.btnBaseAppServiceInterfacePath.Size = new System.Drawing.Size(104, 23);
            this.btnBaseAppServiceInterfacePath.TabIndex = 26;
            this.btnBaseAppServiceInterfacePath.Text = "Search";
            this.btnBaseAppServiceInterfacePath.UseVisualStyleBackColor = true;
            // 
            // txtAppServiceFile
            // 
            this.txtAppServiceFile.Location = new System.Drawing.Point(119, 115);
            this.txtAppServiceFile.Name = "txtAppServiceFile";
            this.txtAppServiceFile.Size = new System.Drawing.Size(1730, 23);
            this.txtAppServiceFile.TabIndex = 25;
            // 
            // btnBusinessAppServiceFile
            // 
            this.btnBusinessAppServiceFile.Location = new System.Drawing.Point(9, 115);
            this.btnBusinessAppServiceFile.Name = "btnBusinessAppServiceFile";
            this.btnBusinessAppServiceFile.Size = new System.Drawing.Size(104, 23);
            this.btnBusinessAppServiceFile.TabIndex = 24;
            this.btnBusinessAppServiceFile.Text = "Search";
            this.btnBusinessAppServiceFile.UseVisualStyleBackColor = true;
            // 
            // txtBaseAppServicePath
            // 
            this.txtBaseAppServicePath.Location = new System.Drawing.Point(119, 27);
            this.txtBaseAppServicePath.Name = "txtBaseAppServicePath";
            this.txtBaseAppServicePath.Size = new System.Drawing.Size(1730, 23);
            this.txtBaseAppServicePath.TabIndex = 23;
            // 
            // btnBaseAppServicePath
            // 
            this.btnBaseAppServicePath.Location = new System.Drawing.Point(9, 27);
            this.btnBaseAppServicePath.Name = "btnBaseAppServicePath";
            this.btnBaseAppServicePath.Size = new System.Drawing.Size(104, 23);
            this.btnBaseAppServicePath.TabIndex = 22;
            this.btnBaseAppServicePath.Text = "Search";
            this.btnBaseAppServicePath.UseVisualStyleBackColor = true;
            // 
            // tabBusinessService
            // 
            this.tabBusinessService.Controls.Add(this.lblBusinessInjectionFile);
            this.tabBusinessService.Controls.Add(this.lblBaseBusinessInterfacePath);
            this.tabBusinessService.Controls.Add(this.lblBaseBusinessPath);
            this.tabBusinessService.Controls.Add(this.txtBusinessBaseInterfacePath);
            this.tabBusinessService.Controls.Add(this.btnSearchBusinessInterfaceBase);
            this.tabBusinessService.Controls.Add(this.txtBusinessInjectionFile);
            this.tabBusinessService.Controls.Add(this.btnSearchInjectionFile);
            this.tabBusinessService.Controls.Add(this.txtBusinessBasePath);
            this.tabBusinessService.Controls.Add(this.btnSearchBusinessBase);
            this.tabBusinessService.Location = new System.Drawing.Point(4, 24);
            this.tabBusinessService.Name = "tabBusinessService";
            this.tabBusinessService.Padding = new System.Windows.Forms.Padding(3);
            this.tabBusinessService.Size = new System.Drawing.Size(1852, 864);
            this.tabBusinessService.TabIndex = 1;
            this.tabBusinessService.Text = "Business Service";
            this.tabBusinessService.UseVisualStyleBackColor = true;
            // 
            // lblBusinessInjectionFile
            // 
            this.lblBusinessInjectionFile.AutoSize = true;
            this.lblBusinessInjectionFile.Location = new System.Drawing.Point(115, 100);
            this.lblBusinessInjectionFile.Name = "lblBusinessInjectionFile";
            this.lblBusinessInjectionFile.Size = new System.Drawing.Size(120, 15);
            this.lblBusinessInjectionFile.TabIndex = 21;
            this.lblBusinessInjectionFile.Text = "Business injection file";
            // 
            // lblBaseBusinessInterfacePath
            // 
            this.lblBaseBusinessInterfacePath.AutoSize = true;
            this.lblBaseBusinessInterfacePath.Location = new System.Drawing.Point(115, 55);
            this.lblBaseBusinessInterfacePath.Name = "lblBaseBusinessInterfacePath";
            this.lblBaseBusinessInterfacePath.Size = new System.Drawing.Size(155, 15);
            this.lblBaseBusinessInterfacePath.TabIndex = 20;
            this.lblBaseBusinessInterfacePath.Text = "Base business interface path";
            // 
            // lblBaseBusinessPath
            // 
            this.lblBaseBusinessPath.AutoSize = true;
            this.lblBaseBusinessPath.Location = new System.Drawing.Point(115, 11);
            this.lblBaseBusinessPath.Name = "lblBaseBusinessPath";
            this.lblBaseBusinessPath.Size = new System.Drawing.Size(106, 15);
            this.lblBaseBusinessPath.TabIndex = 19;
            this.lblBaseBusinessPath.Text = "Base business path";
            // 
            // txtBusinessBaseInterfacePath
            // 
            this.txtBusinessBaseInterfacePath.Location = new System.Drawing.Point(115, 73);
            this.txtBusinessBaseInterfacePath.Name = "txtBusinessBaseInterfacePath";
            this.txtBusinessBaseInterfacePath.Size = new System.Drawing.Size(1730, 23);
            this.txtBusinessBaseInterfacePath.TabIndex = 18;
            // 
            // btnSearchBusinessInterfaceBase
            // 
            this.btnSearchBusinessInterfaceBase.Location = new System.Drawing.Point(5, 73);
            this.btnSearchBusinessInterfaceBase.Name = "btnSearchBusinessInterfaceBase";
            this.btnSearchBusinessInterfaceBase.Size = new System.Drawing.Size(104, 23);
            this.btnSearchBusinessInterfaceBase.TabIndex = 17;
            this.btnSearchBusinessInterfaceBase.Text = "Search";
            this.btnSearchBusinessInterfaceBase.UseVisualStyleBackColor = true;
            this.btnSearchBusinessInterfaceBase.Click += new System.EventHandler(this.btnSearchBusinessInterfaceBase_Click);
            // 
            // txtBusinessInjectionFile
            // 
            this.txtBusinessInjectionFile.Location = new System.Drawing.Point(115, 118);
            this.txtBusinessInjectionFile.Name = "txtBusinessInjectionFile";
            this.txtBusinessInjectionFile.Size = new System.Drawing.Size(1730, 23);
            this.txtBusinessInjectionFile.TabIndex = 16;
            // 
            // btnSearchInjectionFile
            // 
            this.btnSearchInjectionFile.Location = new System.Drawing.Point(5, 118);
            this.btnSearchInjectionFile.Name = "btnSearchInjectionFile";
            this.btnSearchInjectionFile.Size = new System.Drawing.Size(104, 23);
            this.btnSearchInjectionFile.TabIndex = 15;
            this.btnSearchInjectionFile.Text = "Search";
            this.btnSearchInjectionFile.UseVisualStyleBackColor = true;
            this.btnSearchInjectionFile.Click += new System.EventHandler(this.btnSearchInjectionFile_Click);
            // 
            // txtBusinessBasePath
            // 
            this.txtBusinessBasePath.Location = new System.Drawing.Point(115, 30);
            this.txtBusinessBasePath.Name = "txtBusinessBasePath";
            this.txtBusinessBasePath.Size = new System.Drawing.Size(1730, 23);
            this.txtBusinessBasePath.TabIndex = 14;
            // 
            // btnSearchBusinessBase
            // 
            this.btnSearchBusinessBase.Location = new System.Drawing.Point(5, 30);
            this.btnSearchBusinessBase.Name = "btnSearchBusinessBase";
            this.btnSearchBusinessBase.Size = new System.Drawing.Size(104, 23);
            this.btnSearchBusinessBase.TabIndex = 13;
            this.btnSearchBusinessBase.Text = "Search";
            this.btnSearchBusinessBase.UseVisualStyleBackColor = true;
            this.btnSearchBusinessBase.Click += new System.EventHandler(this.btnSearchBusinessBase_Click);
            // 
            // tabRepositoryService
            // 
            this.tabRepositoryService.Controls.Add(this.lblRepositoryInjectionFile);
            this.tabRepositoryService.Controls.Add(this.lblBaseRepositoryInterfacePath);
            this.tabRepositoryService.Controls.Add(this.lblBaseRepositoryPath);
            this.tabRepositoryService.Controls.Add(this.txtPathRepositoryInterface);
            this.tabRepositoryService.Controls.Add(this.btnSearchRepositoryInterfacePath);
            this.tabRepositoryService.Controls.Add(this.txtPathRepositoryInjection);
            this.tabRepositoryService.Controls.Add(this.btnSearchRepositoryInjection);
            this.tabRepositoryService.Controls.Add(this.txtPathRepositoryBase);
            this.tabRepositoryService.Controls.Add(this.btnSearchRepositoryBase);
            this.tabRepositoryService.Location = new System.Drawing.Point(4, 24);
            this.tabRepositoryService.Name = "tabRepositoryService";
            this.tabRepositoryService.Padding = new System.Windows.Forms.Padding(3);
            this.tabRepositoryService.Size = new System.Drawing.Size(1852, 864);
            this.tabRepositoryService.TabIndex = 2;
            this.tabRepositoryService.Text = "Repository Service";
            this.tabRepositoryService.UseVisualStyleBackColor = true;
            // 
            // lblRepositoryInjectionFile
            // 
            this.lblRepositoryInjectionFile.AutoSize = true;
            this.lblRepositoryInjectionFile.Location = new System.Drawing.Point(116, 107);
            this.lblRepositoryInjectionFile.Name = "lblRepositoryInjectionFile";
            this.lblRepositoryInjectionFile.Size = new System.Drawing.Size(131, 15);
            this.lblRepositoryInjectionFile.TabIndex = 12;
            this.lblRepositoryInjectionFile.Text = "Repository injection file";
            // 
            // lblBaseRepositoryInterfacePath
            // 
            this.lblBaseRepositoryInterfacePath.AutoSize = true;
            this.lblBaseRepositoryInterfacePath.Location = new System.Drawing.Point(116, 62);
            this.lblBaseRepositoryInterfacePath.Name = "lblBaseRepositoryInterfacePath";
            this.lblBaseRepositoryInterfacePath.Size = new System.Drawing.Size(163, 15);
            this.lblBaseRepositoryInterfacePath.TabIndex = 11;
            this.lblBaseRepositoryInterfacePath.Text = "Base repository interface path";
            // 
            // lblBaseRepositoryPath
            // 
            this.lblBaseRepositoryPath.AutoSize = true;
            this.lblBaseRepositoryPath.Location = new System.Drawing.Point(116, 18);
            this.lblBaseRepositoryPath.Name = "lblBaseRepositoryPath";
            this.lblBaseRepositoryPath.Size = new System.Drawing.Size(114, 15);
            this.lblBaseRepositoryPath.TabIndex = 10;
            this.lblBaseRepositoryPath.Text = "Base repository path";
            // 
            // txtPathRepositoryInterface
            // 
            this.txtPathRepositoryInterface.Location = new System.Drawing.Point(116, 80);
            this.txtPathRepositoryInterface.Name = "txtPathRepositoryInterface";
            this.txtPathRepositoryInterface.Size = new System.Drawing.Size(1730, 23);
            this.txtPathRepositoryInterface.TabIndex = 9;
            // 
            // btnSearchRepositoryInterfacePath
            // 
            this.btnSearchRepositoryInterfacePath.Location = new System.Drawing.Point(6, 80);
            this.btnSearchRepositoryInterfacePath.Name = "btnSearchRepositoryInterfacePath";
            this.btnSearchRepositoryInterfacePath.Size = new System.Drawing.Size(104, 23);
            this.btnSearchRepositoryInterfacePath.TabIndex = 8;
            this.btnSearchRepositoryInterfacePath.Text = "Search";
            this.btnSearchRepositoryInterfacePath.UseVisualStyleBackColor = true;
            this.btnSearchRepositoryInterfacePath.Click += new System.EventHandler(this.btnSearchRepositoryInterfacePath_Click);
            // 
            // txtPathRepositoryInjection
            // 
            this.txtPathRepositoryInjection.Location = new System.Drawing.Point(116, 125);
            this.txtPathRepositoryInjection.Name = "txtPathRepositoryInjection";
            this.txtPathRepositoryInjection.Size = new System.Drawing.Size(1730, 23);
            this.txtPathRepositoryInjection.TabIndex = 7;
            // 
            // btnSearchRepositoryInjection
            // 
            this.btnSearchRepositoryInjection.Location = new System.Drawing.Point(6, 125);
            this.btnSearchRepositoryInjection.Name = "btnSearchRepositoryInjection";
            this.btnSearchRepositoryInjection.Size = new System.Drawing.Size(104, 23);
            this.btnSearchRepositoryInjection.TabIndex = 6;
            this.btnSearchRepositoryInjection.Text = "Search";
            this.btnSearchRepositoryInjection.UseVisualStyleBackColor = true;
            this.btnSearchRepositoryInjection.Click += new System.EventHandler(this.btnSearchRepositoryInjection_Click);
            // 
            // txtPathRepositoryBase
            // 
            this.txtPathRepositoryBase.Location = new System.Drawing.Point(116, 37);
            this.txtPathRepositoryBase.Name = "txtPathRepositoryBase";
            this.txtPathRepositoryBase.Size = new System.Drawing.Size(1730, 23);
            this.txtPathRepositoryBase.TabIndex = 5;
            // 
            // btnSearchRepositoryBase
            // 
            this.btnSearchRepositoryBase.Location = new System.Drawing.Point(6, 37);
            this.btnSearchRepositoryBase.Name = "btnSearchRepositoryBase";
            this.btnSearchRepositoryBase.Size = new System.Drawing.Size(104, 23);
            this.btnSearchRepositoryBase.TabIndex = 4;
            this.btnSearchRepositoryBase.Text = "Search";
            this.btnSearchRepositoryBase.UseVisualStyleBackColor = true;
            this.btnSearchRepositoryBase.Click += new System.EventHandler(this.btnSearchRepositoryBase_Click);
            // 
            // tabUnitOfWorkService
            // 
            this.tabUnitOfWorkService.Controls.Add(this.txtUOFInterfacePath);
            this.tabUnitOfWorkService.Controls.Add(this.btnInjectionLocation);
            this.tabUnitOfWorkService.Controls.Add(this.txtUOFConcretePath);
            this.tabUnitOfWorkService.Controls.Add(this.btnSearchFolderUOF);
            this.tabUnitOfWorkService.Location = new System.Drawing.Point(4, 24);
            this.tabUnitOfWorkService.Name = "tabUnitOfWorkService";
            this.tabUnitOfWorkService.Padding = new System.Windows.Forms.Padding(3);
            this.tabUnitOfWorkService.Size = new System.Drawing.Size(1852, 864);
            this.tabUnitOfWorkService.TabIndex = 3;
            this.tabUnitOfWorkService.Text = "Unit Of Work Service";
            this.tabUnitOfWorkService.UseVisualStyleBackColor = true;
            // 
            // txtUOFInterfacePath
            // 
            this.txtUOFInterfacePath.Location = new System.Drawing.Point(116, 35);
            this.txtUOFInterfacePath.Name = "txtUOFInterfacePath";
            this.txtUOFInterfacePath.Size = new System.Drawing.Size(1730, 23);
            this.txtUOFInterfacePath.TabIndex = 3;
            // 
            // btnInjectionLocation
            // 
            this.btnInjectionLocation.Location = new System.Drawing.Point(6, 35);
            this.btnInjectionLocation.Name = "btnInjectionLocation";
            this.btnInjectionLocation.Size = new System.Drawing.Size(104, 23);
            this.btnInjectionLocation.TabIndex = 2;
            this.btnInjectionLocation.Text = "Search";
            this.btnInjectionLocation.UseVisualStyleBackColor = true;
            this.btnInjectionLocation.Click += new System.EventHandler(this.btnInjectionLocation_Click);
            // 
            // txtUOFConcretePath
            // 
            this.txtUOFConcretePath.Location = new System.Drawing.Point(116, 6);
            this.txtUOFConcretePath.Name = "txtUOFConcretePath";
            this.txtUOFConcretePath.Size = new System.Drawing.Size(1730, 23);
            this.txtUOFConcretePath.TabIndex = 1;
            // 
            // btnSearchFolderUOF
            // 
            this.btnSearchFolderUOF.Location = new System.Drawing.Point(6, 6);
            this.btnSearchFolderUOF.Name = "btnSearchFolderUOF";
            this.btnSearchFolderUOF.Size = new System.Drawing.Size(104, 23);
            this.btnSearchFolderUOF.TabIndex = 0;
            this.btnSearchFolderUOF.Text = "Search";
            this.btnSearchFolderUOF.UseVisualStyleBackColor = true;
            this.btnSearchFolderUOF.Click += new System.EventHandler(this.btnSearchFolderUOF_Click);
            // 
            // tabCreation
            // 
            this.tabCreation.Controls.Add(this.lblEntity);
            this.tabCreation.Controls.Add(this.txtEntityName);
            this.tabCreation.Controls.Add(this.btnCreateAutomaticLayers);
            this.tabCreation.Location = new System.Drawing.Point(4, 24);
            this.tabCreation.Name = "tabCreation";
            this.tabCreation.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreation.Size = new System.Drawing.Size(1872, 989);
            this.tabCreation.TabIndex = 1;
            this.tabCreation.Text = "Creation";
            this.tabCreation.UseVisualStyleBackColor = true;
            // 
            // lblEntity
            // 
            this.lblEntity.AutoSize = true;
            this.lblEntity.Location = new System.Drawing.Point(908, 913);
            this.lblEntity.Name = "lblEntity";
            this.lblEntity.Size = new System.Drawing.Size(70, 15);
            this.lblEntity.TabIndex = 2;
            this.lblEntity.Text = "Entity name";
            // 
            // txtEntityName
            // 
            this.txtEntityName.Location = new System.Drawing.Point(6, 931);
            this.txtEntityName.Name = "txtEntityName";
            this.txtEntityName.Size = new System.Drawing.Size(1860, 23);
            this.txtEntityName.TabIndex = 1;
            // 
            // btnCreateAutomaticLayers
            // 
            this.btnCreateAutomaticLayers.Location = new System.Drawing.Point(6, 960);
            this.btnCreateAutomaticLayers.Name = "btnCreateAutomaticLayers";
            this.btnCreateAutomaticLayers.Size = new System.Drawing.Size(1860, 23);
            this.btnCreateAutomaticLayers.TabIndex = 0;
            this.btnCreateAutomaticLayers.Text = "Create";
            this.btnCreateAutomaticLayers.UseVisualStyleBackColor = true;
            this.btnCreateAutomaticLayers.Click += new System.EventHandler(this.btnCreateAutomaticLayers_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.tabViews);
            this.Name = "Main";
            this.Text = "Layer Creation";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabViews.ResumeLayout(false);
            this.tabView.ResumeLayout(false);
            this.tabForEachLayer.ResumeLayout(false);
            this.tabAppService.ResumeLayout(false);
            this.tabAppService.PerformLayout();
            this.tabBusinessService.ResumeLayout(false);
            this.tabBusinessService.PerformLayout();
            this.tabRepositoryService.ResumeLayout(false);
            this.tabRepositoryService.PerformLayout();
            this.tabUnitOfWorkService.ResumeLayout(false);
            this.tabUnitOfWorkService.PerformLayout();
            this.tabCreation.ResumeLayout(false);
            this.tabCreation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabViews;
        private TabPage tabView;
        private TabPage tabCreation;
        private TabControl tabForEachLayer;
        private CheckedListBox ckdLstLayers;
        private TabPage tabBusinessService;
        private TabPage tabRepositoryService;
        private TabPage tabUnitOfWorkService;
        private TextBox txtUOFConcretePath;
        private Button btnSearchFolderUOF;
        private TextBox txtUOFInterfacePath;
        private Button btnInjectionLocation;
        private TabPage tabAppService;
        private TextBox txtPathRepositoryInjection;
        private Button btnSearchRepositoryInjection;
        private TextBox txtPathRepositoryBase;
        private Button btnSearchRepositoryBase;
        private TextBox txtPathRepositoryInterface;
        private Button btnSearchRepositoryInterfacePath;
        private Button btnCreateAutomaticLayers;
        private Label lblEntity;
        private TextBox txtEntityName;
        private Label lblBaseRepositoryInterfacePath;
        private Label lblBaseRepositoryPath;
        private Label lblRepositoryInjectionFile;
        private Label lblBusinessInjectionFile;
        private Label lblBaseBusinessInterfacePath;
        private Label lblBaseBusinessPath;
        private TextBox txtBusinessBaseInterfacePath;
        private Button btnSearchBusinessInterfaceBase;
        private TextBox txtBusinessInjectionFile;
        private Button btnSearchInjectionFile;
        private TextBox txtBusinessBasePath;
        private Button btnSearchBusinessBase;
        private Label lblAppServiceFile;
        private Label lblBaseAppServiceInterfacePath;
        private Label lblBaseAppServicePath;
        private TextBox txtAppServiceInterfacePath;
        private Button btnBaseAppServiceInterfacePath;
        private TextBox txtAppServiceFile;
        private Button btnBusinessAppServiceFile;
        private TextBox txtBaseAppServicePath;
        private Button btnBaseAppServicePath;
    }
}