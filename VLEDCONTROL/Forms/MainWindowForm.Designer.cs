namespace VLEDCONTROL
{
   partial class MainWindowForm
   {
      /// <summary>
      /// Erforderliche Designervariable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Verwendete Ressourcen bereinigen.
      /// </summary>
      /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Vom Windows Form-Designer generierter Code

      /// <summary>
      /// Erforderliche Methode für die Designerunterstützung.
      /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowForm));
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.loadProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.installExportScrriptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.removeExportScriptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.setLEDCOntrolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.tabMain = new System.Windows.Forms.TabControl();
         this.tabPageData = new System.Windows.Forms.TabPage();
         this.buttonCopyAircraftToClipboard = new System.Windows.Forms.Button();
         this.buttonRegisterFromProfile = new System.Windows.Forms.Button();
         this.checkBoxDataShowUnknown = new System.Windows.Forms.CheckBox();
         this.buttonRegisterRemove = new System.Windows.Forms.Button();
         this.buttonRegisterAdd = new System.Windows.Forms.Button();
         this.checkBoxDataShowUnregistered = new System.Windows.Forms.CheckBox();
         this.listViewRegistered = new System.Windows.Forms.ListView();
         this.columnRegisteredId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnRegisteredName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.labelDataRegistered = new System.Windows.Forms.Label();
         this.textBoxAircraft = new System.Windows.Forms.TextBox();
         this.labelDataCurrent = new System.Windows.Forms.Label();
         this.listViewData = new System.Windows.Forms.ListView();
         this.columnHeaderDataId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeaderDataName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeaderDataValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeaderLastChange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.tabPageProfile = new System.Windows.Forms.TabPage();
         this.buttonProfilesClear = new System.Windows.Forms.Button();
         this.label6 = new System.Windows.Forms.Label();
         this.panel3 = new System.Windows.Forms.Panel();
         this.radioButtonNewElementsAppend = new System.Windows.Forms.RadioButton();
         this.radioButtonNewElementsInsertAfter = new System.Windows.Forms.RadioButton();
         this.radioButtonNewElementsInsertBefore = new System.Windows.Forms.RadioButton();
         this.buttonProfileDuplicate = new System.Windows.Forms.Button();
         this.buttonProfileDown = new System.Windows.Forms.Button();
         this.buttonProfileUp = new System.Windows.Forms.Button();
         this.buttonProfileEdit = new System.Windows.Forms.Button();
         this.buttonProfileRemove = new System.Windows.Forms.Button();
         this.buttonProfileAdd = new System.Windows.Forms.Button();
         this.labelProfileName = new System.Windows.Forms.Label();
         this.textBoxProfileName = new System.Windows.Forms.TextBox();
         this.labelProfile = new System.Windows.Forms.Label();
         this.listViewProfileEvents = new System.Windows.Forms.ListView();
         this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeaderAircaft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeaderCondition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeaderDevice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeaderLed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeaderColorOn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeaderColorFlashing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeaderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.tabPageMapping = new System.Windows.Forms.TabPage();
         this.buttonMappingEdit = new System.Windows.Forms.Button();
         this.buttonMappingRemove = new System.Windows.Forms.Button();
         this.buttonMappingAdd = new System.Windows.Forms.Button();
         this.label5 = new System.Windows.Forms.Label();
         this.labelMappingProfileName = new System.Windows.Forms.Label();
         this.textBoxMappingProfileName = new System.Windows.Forms.TextBox();
         this.listViewMapping = new System.Windows.Forms.ListView();
         this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.tabPageSettings = new System.Windows.Forms.TabPage();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.comboBoxLogLevel = new System.Windows.Forms.ComboBox();
         this.labelLogLevel = new System.Windows.Forms.Label();
         this.checkBox3 = new System.Windows.Forms.CheckBox();
         this.checkBox2 = new System.Windows.Forms.CheckBox();
         this.checkBox1 = new System.Windows.Forms.CheckBox();
         this.checkBoxAutostart = new System.Windows.Forms.CheckBox();
         this.labelSettingsDescriptionFlashingCycles = new System.Windows.Forms.Label();
         this.textBoxSettingsFlashingCycles = new System.Windows.Forms.TextBox();
         this.labelSettings = new System.Windows.Forms.Label();
         this.buttonSettingsCancel = new System.Windows.Forms.Button();
         this.buttonSettingsSave = new System.Windows.Forms.Button();
         this.buttonSettingsEditDevice = new System.Windows.Forms.Button();
         this.buttonSettingsRemoveDevice = new System.Windows.Forms.Button();
         this.buttonSettingsAddDevice = new System.Windows.Forms.Button();
         this.labelSettingsDevices = new System.Windows.Forms.Label();
         this.listViewSettingsDevices = new System.Windows.Forms.ListView();
         this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnDevicesName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnDevicesVID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnDevicesPID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.labelSettingsDescriptionUpdateInterval = new System.Windows.Forms.Label();
         this.labelSettingsDescriptionDataInterval = new System.Windows.Forms.Label();
         this.textBoxSettingsDataInterval = new System.Windows.Forms.TextBox();
         this.labelSettingsDataInterval = new System.Windows.Forms.Label();
         this.textBoxSettingsUpdateInterval = new System.Windows.Forms.TextBox();
         this.labelSettingsUpdateInterval = new System.Windows.Forms.Label();
         this.buttonChooseDefaultProfile = new System.Windows.Forms.Button();
         this.textBoxSettingsDefaultProfile = new System.Windows.Forms.TextBox();
         this.labelSettingsDefaultProfile = new System.Windows.Forms.Label();
         this.buttonChooseVirpilLedControl = new System.Windows.Forms.Button();
         this.textBoxSettingsVirpilLedControl = new System.Windows.Forms.TextBox();
         this.labelSettingsVirpilLEDControl = new System.Windows.Forms.Label();
         this.buttonMainStart = new System.Windows.Forms.Button();
         this.buttonMainLoad = new System.Windows.Forms.Button();
         this.buttonMainSave = new System.Windows.Forms.Button();
         this.buttonMainSetLed = new System.Windows.Forms.Button();
         this.buttonDataQuery = new System.Windows.Forms.Button();
         this.radioButtonAll = new System.Windows.Forms.RadioButton();
         this.radioRegistered = new System.Windows.Forms.RadioButton();
         this.panelMode = new System.Windows.Forms.Panel();
         this.labelMode = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         this.radioButtonFull = new System.Windows.Forms.RadioButton();
         this.radioButtonChanges = new System.Windows.Forms.RadioButton();
         this.buttonRegister = new System.Windows.Forms.Button();
         this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
         this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
         this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
         this.progressBarEngineStatus = new System.Windows.Forms.ProgressBar();
         this.menuStrip1.SuspendLayout();
         this.tabMain.SuspendLayout();
         this.tabPageData.SuspendLayout();
         this.tabPageProfile.SuspendLayout();
         this.panel3.SuspendLayout();
         this.tabPageMapping.SuspendLayout();
         this.tabPageSettings.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.groupBox1.SuspendLayout();
         this.panelMode.SuspendLayout();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.aboutToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(1170, 24);
         this.menuStrip1.TabIndex = 0;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadProfileToolStripMenuItem,
            this.saveProfileToolStripMenuItem,
            this.exitToolStripMenuItem});
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
         this.fileToolStripMenuItem.Text = "File";
         // 
         // loadProfileToolStripMenuItem
         // 
         this.loadProfileToolStripMenuItem.Name = "loadProfileToolStripMenuItem";
         this.loadProfileToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
         this.loadProfileToolStripMenuItem.Text = "Load Profile";
         this.loadProfileToolStripMenuItem.Click += new System.EventHandler(this.MenuItemLoadProfile_Click);
         // 
         // saveProfileToolStripMenuItem
         // 
         this.saveProfileToolStripMenuItem.Name = "saveProfileToolStripMenuItem";
         this.saveProfileToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
         this.saveProfileToolStripMenuItem.Text = "Save Profile";
         this.saveProfileToolStripMenuItem.Click += new System.EventHandler(this.MenuItemSaveProfile_Click);
         // 
         // exitToolStripMenuItem
         // 
         this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
         this.exitToolStripMenuItem.Text = "Exit";
         this.exitToolStripMenuItem.Click += new System.EventHandler(this.MenuItemExit_Click);
         // 
         // setupToolStripMenuItem
         // 
         this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installExportScrriptsToolStripMenuItem,
            this.removeExportScriptsToolStripMenuItem,
            this.setLEDCOntrolToolStripMenuItem});
         this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
         this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
         this.setupToolStripMenuItem.Text = "Setup";
         // 
         // installExportScrriptsToolStripMenuItem
         // 
         this.installExportScrriptsToolStripMenuItem.Name = "installExportScrriptsToolStripMenuItem";
         this.installExportScrriptsToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
         this.installExportScrriptsToolStripMenuItem.Text = "Install Export Scrripts";
         this.installExportScrriptsToolStripMenuItem.Click += new System.EventHandler(this.installExportScrriptsToolStripMenuItem_Click);
         // 
         // removeExportScriptsToolStripMenuItem
         // 
         this.removeExportScriptsToolStripMenuItem.Name = "removeExportScriptsToolStripMenuItem";
         this.removeExportScriptsToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
         this.removeExportScriptsToolStripMenuItem.Text = "Remove Export Scripts";
         this.removeExportScriptsToolStripMenuItem.Click += new System.EventHandler(this.removeExportScriptsToolStripMenuItem_Click);
         // 
         // setLEDCOntrolToolStripMenuItem
         // 
         this.setLEDCOntrolToolStripMenuItem.Name = "setLEDCOntrolToolStripMenuItem";
         this.setLEDCOntrolToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
         this.setLEDCOntrolToolStripMenuItem.Text = "Set LED Control Command";
         this.setLEDCOntrolToolStripMenuItem.Click += new System.EventHandler(this.setLEDCOntrolToolStripMenuItem_Click);
         // 
         // aboutToolStripMenuItem
         // 
         this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
         this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
         this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
         this.aboutToolStripMenuItem.Text = "Help";
         this.aboutToolStripMenuItem.Click += new System.EventHandler(this.MenuItemAbout_Click);
         // 
         // aboutToolStripMenuItem1
         // 
         this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
         this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
         this.aboutToolStripMenuItem1.Text = "About";
         this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
         // 
         // contextMenuStrip1
         // 
         this.contextMenuStrip1.Name = "contextMenuStrip1";
         this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
         // 
         // tabMain
         // 
         this.tabMain.Controls.Add(this.tabPageData);
         this.tabMain.Controls.Add(this.tabPageProfile);
         this.tabMain.Controls.Add(this.tabPageMapping);
         this.tabMain.Controls.Add(this.tabPageSettings);
         this.tabMain.Location = new System.Drawing.Point(112, 28);
         this.tabMain.Name = "tabMain";
         this.tabMain.SelectedIndex = 0;
         this.tabMain.Size = new System.Drawing.Size(1001, 589);
         this.tabMain.TabIndex = 0;
         // 
         // tabPageData
         // 
         this.tabPageData.Controls.Add(this.buttonCopyAircraftToClipboard);
         this.tabPageData.Controls.Add(this.buttonRegisterFromProfile);
         this.tabPageData.Controls.Add(this.checkBoxDataShowUnknown);
         this.tabPageData.Controls.Add(this.buttonRegisterRemove);
         this.tabPageData.Controls.Add(this.buttonRegisterAdd);
         this.tabPageData.Controls.Add(this.checkBoxDataShowUnregistered);
         this.tabPageData.Controls.Add(this.listViewRegistered);
         this.tabPageData.Controls.Add(this.labelDataRegistered);
         this.tabPageData.Controls.Add(this.textBoxAircraft);
         this.tabPageData.Controls.Add(this.labelDataCurrent);
         this.tabPageData.Controls.Add(this.listViewData);
         this.tabPageData.Location = new System.Drawing.Point(4, 22);
         this.tabPageData.Name = "tabPageData";
         this.tabPageData.Padding = new System.Windows.Forms.Padding(3);
         this.tabPageData.Size = new System.Drawing.Size(993, 563);
         this.tabPageData.TabIndex = 0;
         this.tabPageData.Text = "Data";
         this.tabPageData.UseVisualStyleBackColor = true;
         // 
         // buttonCopyAircraftToClipboard
         // 
         this.buttonCopyAircraftToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopyAircraftToClipboard.Image")));
         this.buttonCopyAircraftToClipboard.Location = new System.Drawing.Point(158, 5);
         this.buttonCopyAircraftToClipboard.Name = "buttonCopyAircraftToClipboard";
         this.buttonCopyAircraftToClipboard.Size = new System.Drawing.Size(22, 22);
         this.buttonCopyAircraftToClipboard.TabIndex = 11;
         this.buttonCopyAircraftToClipboard.UseVisualStyleBackColor = true;
         this.buttonCopyAircraftToClipboard.Click += new System.EventHandler(this.buttonCopyAircraftToClipboard_Click);
         // 
         // buttonRegisterFromProfile
         // 
         this.buttonRegisterFromProfile.Location = new System.Drawing.Point(809, 110);
         this.buttonRegisterFromProfile.Name = "buttonRegisterFromProfile";
         this.buttonRegisterFromProfile.Size = new System.Drawing.Size(75, 23);
         this.buttonRegisterFromProfile.TabIndex = 10;
         this.buttonRegisterFromProfile.Text = "From Profile";
         this.buttonRegisterFromProfile.UseVisualStyleBackColor = true;
         this.buttonRegisterFromProfile.Visible = false;
         // 
         // checkBoxDataShowUnknown
         // 
         this.checkBoxDataShowUnknown.AutoSize = true;
         this.checkBoxDataShowUnknown.Checked = true;
         this.checkBoxDataShowUnknown.CheckState = System.Windows.Forms.CheckState.Checked;
         this.checkBoxDataShowUnknown.Enabled = false;
         this.checkBoxDataShowUnknown.Location = new System.Drawing.Point(142, 540);
         this.checkBoxDataShowUnknown.Name = "checkBoxDataShowUnknown";
         this.checkBoxDataShowUnknown.Size = new System.Drawing.Size(102, 17);
         this.checkBoxDataShowUnknown.TabIndex = 9;
         this.checkBoxDataShowUnknown.Text = "Show Unknown";
         this.checkBoxDataShowUnknown.UseVisualStyleBackColor = true;
         // 
         // buttonRegisterRemove
         // 
         this.buttonRegisterRemove.Location = new System.Drawing.Point(809, 81);
         this.buttonRegisterRemove.Name = "buttonRegisterRemove";
         this.buttonRegisterRemove.Size = new System.Drawing.Size(75, 23);
         this.buttonRegisterRemove.TabIndex = 8;
         this.buttonRegisterRemove.Text = "Remove";
         this.buttonRegisterRemove.UseVisualStyleBackColor = true;
         this.buttonRegisterRemove.Visible = false;
         // 
         // buttonRegisterAdd
         // 
         this.buttonRegisterAdd.Location = new System.Drawing.Point(809, 52);
         this.buttonRegisterAdd.Name = "buttonRegisterAdd";
         this.buttonRegisterAdd.Size = new System.Drawing.Size(75, 23);
         this.buttonRegisterAdd.TabIndex = 7;
         this.buttonRegisterAdd.Text = "Add";
         this.buttonRegisterAdd.UseVisualStyleBackColor = true;
         this.buttonRegisterAdd.Visible = false;
         this.buttonRegisterAdd.Click += new System.EventHandler(this.button1_Click_1);
         // 
         // checkBoxDataShowUnregistered
         // 
         this.checkBoxDataShowUnregistered.AutoSize = true;
         this.checkBoxDataShowUnregistered.Checked = true;
         this.checkBoxDataShowUnregistered.CheckState = System.Windows.Forms.CheckState.Checked;
         this.checkBoxDataShowUnregistered.Enabled = false;
         this.checkBoxDataShowUnregistered.Location = new System.Drawing.Point(9, 540);
         this.checkBoxDataShowUnregistered.Name = "checkBoxDataShowUnregistered";
         this.checkBoxDataShowUnregistered.Size = new System.Drawing.Size(116, 17);
         this.checkBoxDataShowUnregistered.TabIndex = 6;
         this.checkBoxDataShowUnregistered.Text = "Show Unregistered";
         this.checkBoxDataShowUnregistered.UseVisualStyleBackColor = true;
         // 
         // listViewRegistered
         // 
         this.listViewRegistered.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnRegisteredId,
            this.columnRegisteredName});
         this.listViewRegistered.FullRowSelect = true;
         this.listViewRegistered.GridLines = true;
         this.listViewRegistered.HideSelection = false;
         this.listViewRegistered.Location = new System.Drawing.Point(530, 52);
         this.listViewRegistered.Name = "listViewRegistered";
         this.listViewRegistered.Size = new System.Drawing.Size(273, 482);
         this.listViewRegistered.Sorting = System.Windows.Forms.SortOrder.Ascending;
         this.listViewRegistered.TabIndex = 5;
         this.listViewRegistered.UseCompatibleStateImageBehavior = false;
         this.listViewRegistered.View = System.Windows.Forms.View.Details;
         this.listViewRegistered.Visible = false;
         // 
         // columnRegisteredId
         // 
         this.columnRegisteredId.Text = "ID";
         // 
         // columnRegisteredName
         // 
         this.columnRegisteredName.Text = "Name";
         this.columnRegisteredName.Width = 198;
         // 
         // labelDataRegistered
         // 
         this.labelDataRegistered.AutoSize = true;
         this.labelDataRegistered.Location = new System.Drawing.Point(527, 36);
         this.labelDataRegistered.Name = "labelDataRegistered";
         this.labelDataRegistered.Size = new System.Drawing.Size(58, 13);
         this.labelDataRegistered.TabIndex = 4;
         this.labelDataRegistered.Text = "Registered";
         this.labelDataRegistered.Visible = false;
         this.labelDataRegistered.Click += new System.EventHandler(this.label1_Click_5);
         // 
         // textBoxAircraft
         // 
         this.textBoxAircraft.BackColor = System.Drawing.SystemColors.InactiveBorder;
         this.textBoxAircraft.Enabled = false;
         this.textBoxAircraft.Location = new System.Drawing.Point(6, 6);
         this.textBoxAircraft.Name = "textBoxAircraft";
         this.textBoxAircraft.ReadOnly = true;
         this.textBoxAircraft.Size = new System.Drawing.Size(151, 20);
         this.textBoxAircraft.TabIndex = 3;
         this.textBoxAircraft.TextChanged += new System.EventHandler(this.textBoxAircraft_TextChanged);
         // 
         // labelDataCurrent
         // 
         this.labelDataCurrent.AutoSize = true;
         this.labelDataCurrent.Location = new System.Drawing.Point(6, 36);
         this.labelDataCurrent.Name = "labelDataCurrent";
         this.labelDataCurrent.Size = new System.Drawing.Size(41, 13);
         this.labelDataCurrent.TabIndex = 1;
         this.labelDataCurrent.Text = "Current";
         this.labelDataCurrent.Click += new System.EventHandler(this.label1_Click_1);
         // 
         // listViewData
         // 
         this.listViewData.Activation = System.Windows.Forms.ItemActivation.OneClick;
         this.listViewData.BackColor = System.Drawing.SystemColors.Window;
         this.listViewData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDataId,
            this.columnHeaderDataName,
            this.columnHeaderDataValue,
            this.columnHeaderLastChange});
         this.listViewData.FullRowSelect = true;
         this.listViewData.GridLines = true;
         this.listViewData.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
         this.listViewData.HideSelection = false;
         this.listViewData.HoverSelection = true;
         this.listViewData.Location = new System.Drawing.Point(9, 52);
         this.listViewData.Name = "listViewData";
         this.listViewData.Size = new System.Drawing.Size(494, 482);
         this.listViewData.Sorting = System.Windows.Forms.SortOrder.Ascending;
         this.listViewData.TabIndex = 0;
         this.listViewData.UseCompatibleStateImageBehavior = false;
         this.listViewData.View = System.Windows.Forms.View.Details;
         this.listViewData.SelectedIndexChanged += new System.EventHandler(this.listViewData_SelectedIndexChanged);
         // 
         // columnHeaderDataId
         // 
         this.columnHeaderDataId.Text = "ID";
         this.columnHeaderDataId.Width = 44;
         // 
         // columnHeaderDataName
         // 
         this.columnHeaderDataName.Text = "Name";
         this.columnHeaderDataName.Width = 167;
         // 
         // columnHeaderDataValue
         // 
         this.columnHeaderDataValue.Text = "Value";
         this.columnHeaderDataValue.Width = 160;
         // 
         // columnHeaderLastChange
         // 
         this.columnHeaderLastChange.Text = "Last Change";
         this.columnHeaderLastChange.Width = 111;
         // 
         // tabPageProfile
         // 
         this.tabPageProfile.Controls.Add(this.buttonProfilesClear);
         this.tabPageProfile.Controls.Add(this.label6);
         this.tabPageProfile.Controls.Add(this.panel3);
         this.tabPageProfile.Controls.Add(this.buttonProfileDuplicate);
         this.tabPageProfile.Controls.Add(this.buttonProfileDown);
         this.tabPageProfile.Controls.Add(this.buttonProfileUp);
         this.tabPageProfile.Controls.Add(this.buttonProfileEdit);
         this.tabPageProfile.Controls.Add(this.buttonProfileRemove);
         this.tabPageProfile.Controls.Add(this.buttonProfileAdd);
         this.tabPageProfile.Controls.Add(this.labelProfileName);
         this.tabPageProfile.Controls.Add(this.textBoxProfileName);
         this.tabPageProfile.Controls.Add(this.labelProfile);
         this.tabPageProfile.Controls.Add(this.listViewProfileEvents);
         this.tabPageProfile.Location = new System.Drawing.Point(4, 22);
         this.tabPageProfile.Name = "tabPageProfile";
         this.tabPageProfile.Padding = new System.Windows.Forms.Padding(3);
         this.tabPageProfile.Size = new System.Drawing.Size(993, 563);
         this.tabPageProfile.TabIndex = 1;
         this.tabPageProfile.Text = "Profile";
         this.tabPageProfile.UseVisualStyleBackColor = true;
         // 
         // buttonProfilesClear
         // 
         this.buttonProfilesClear.ForeColor = System.Drawing.Color.Maroon;
         this.buttonProfilesClear.Location = new System.Drawing.Point(902, 256);
         this.buttonProfilesClear.Name = "buttonProfilesClear";
         this.buttonProfilesClear.Size = new System.Drawing.Size(75, 23);
         this.buttonProfilesClear.TabIndex = 14;
         this.buttonProfilesClear.Text = "Clear";
         this.buttonProfilesClear.UseVisualStyleBackColor = true;
         this.buttonProfilesClear.Click += new System.EventHandler(this.buttonProfilesClear_Click);
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(901, 293);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(65, 13);
         this.label6.TabIndex = 13;
         this.label6.Text = "New Events";
         // 
         // panel3
         // 
         this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.panel3.Controls.Add(this.radioButtonNewElementsAppend);
         this.panel3.Controls.Add(this.radioButtonNewElementsInsertAfter);
         this.panel3.Controls.Add(this.radioButtonNewElementsInsertBefore);
         this.panel3.Location = new System.Drawing.Point(902, 309);
         this.panel3.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
         this.panel3.Name = "panel3";
         this.panel3.Size = new System.Drawing.Size(75, 75);
         this.panel3.TabIndex = 12;
         // 
         // radioButtonNewElementsAppend
         // 
         this.radioButtonNewElementsAppend.AutoSize = true;
         this.radioButtonNewElementsAppend.Checked = true;
         this.radioButtonNewElementsAppend.Location = new System.Drawing.Point(3, 49);
         this.radioButtonNewElementsAppend.Name = "radioButtonNewElementsAppend";
         this.radioButtonNewElementsAppend.Size = new System.Drawing.Size(62, 17);
         this.radioButtonNewElementsAppend.TabIndex = 9;
         this.radioButtonNewElementsAppend.TabStop = true;
         this.radioButtonNewElementsAppend.Text = "Append";
         this.radioButtonNewElementsAppend.UseVisualStyleBackColor = true;
         // 
         // radioButtonNewElementsInsertAfter
         // 
         this.radioButtonNewElementsInsertAfter.AutoSize = true;
         this.radioButtonNewElementsInsertAfter.Location = new System.Drawing.Point(3, 26);
         this.radioButtonNewElementsInsertAfter.Name = "radioButtonNewElementsInsertAfter";
         this.radioButtonNewElementsInsertAfter.Size = new System.Drawing.Size(47, 17);
         this.radioButtonNewElementsInsertAfter.TabIndex = 8;
         this.radioButtonNewElementsInsertAfter.Text = "After";
         this.radioButtonNewElementsInsertAfter.UseVisualStyleBackColor = true;
         // 
         // radioButtonNewElementsInsertBefore
         // 
         this.radioButtonNewElementsInsertBefore.AutoSize = true;
         this.radioButtonNewElementsInsertBefore.Location = new System.Drawing.Point(3, 3);
         this.radioButtonNewElementsInsertBefore.Name = "radioButtonNewElementsInsertBefore";
         this.radioButtonNewElementsInsertBefore.Size = new System.Drawing.Size(56, 17);
         this.radioButtonNewElementsInsertBefore.TabIndex = 7;
         this.radioButtonNewElementsInsertBefore.Text = "Before";
         this.radioButtonNewElementsInsertBefore.UseVisualStyleBackColor = true;
         // 
         // buttonProfileDuplicate
         // 
         this.buttonProfileDuplicate.Enabled = false;
         this.buttonProfileDuplicate.Location = new System.Drawing.Point(902, 83);
         this.buttonProfileDuplicate.Name = "buttonProfileDuplicate";
         this.buttonProfileDuplicate.Size = new System.Drawing.Size(75, 23);
         this.buttonProfileDuplicate.TabIndex = 11;
         this.buttonProfileDuplicate.Text = "Duplicate";
         this.buttonProfileDuplicate.UseVisualStyleBackColor = true;
         this.buttonProfileDuplicate.Click += new System.EventHandler(this.buttonProfileDuplicate_Click);
         // 
         // buttonProfileDown
         // 
         this.buttonProfileDown.Enabled = false;
         this.buttonProfileDown.Location = new System.Drawing.Point(902, 213);
         this.buttonProfileDown.Name = "buttonProfileDown";
         this.buttonProfileDown.Size = new System.Drawing.Size(75, 23);
         this.buttonProfileDown.TabIndex = 10;
         this.buttonProfileDown.Text = "Down";
         this.buttonProfileDown.UseVisualStyleBackColor = true;
         this.buttonProfileDown.Click += new System.EventHandler(this.buttonProfileDown_Click);
         // 
         // buttonProfileUp
         // 
         this.buttonProfileUp.Enabled = false;
         this.buttonProfileUp.Location = new System.Drawing.Point(902, 184);
         this.buttonProfileUp.Name = "buttonProfileUp";
         this.buttonProfileUp.Size = new System.Drawing.Size(75, 23);
         this.buttonProfileUp.TabIndex = 9;
         this.buttonProfileUp.Text = "Up";
         this.buttonProfileUp.UseVisualStyleBackColor = true;
         this.buttonProfileUp.Click += new System.EventHandler(this.buttonProfileUp_Click);
         // 
         // buttonProfileEdit
         // 
         this.buttonProfileEdit.Enabled = false;
         this.buttonProfileEdit.Location = new System.Drawing.Point(902, 141);
         this.buttonProfileEdit.Name = "buttonProfileEdit";
         this.buttonProfileEdit.Size = new System.Drawing.Size(75, 23);
         this.buttonProfileEdit.TabIndex = 8;
         this.buttonProfileEdit.Text = "Edit";
         this.buttonProfileEdit.UseVisualStyleBackColor = true;
         this.buttonProfileEdit.Click += new System.EventHandler(this.buttonProfileEdit_Click);
         // 
         // buttonProfileRemove
         // 
         this.buttonProfileRemove.Enabled = false;
         this.buttonProfileRemove.Location = new System.Drawing.Point(902, 112);
         this.buttonProfileRemove.Name = "buttonProfileRemove";
         this.buttonProfileRemove.Size = new System.Drawing.Size(75, 23);
         this.buttonProfileRemove.TabIndex = 7;
         this.buttonProfileRemove.Text = "Remove";
         this.buttonProfileRemove.UseVisualStyleBackColor = true;
         this.buttonProfileRemove.Click += new System.EventHandler(this.buttonProfileRemove_Click);
         // 
         // buttonProfileAdd
         // 
         this.buttonProfileAdd.Location = new System.Drawing.Point(902, 54);
         this.buttonProfileAdd.Name = "buttonProfileAdd";
         this.buttonProfileAdd.Size = new System.Drawing.Size(75, 23);
         this.buttonProfileAdd.TabIndex = 6;
         this.buttonProfileAdd.Text = "Add";
         this.buttonProfileAdd.UseVisualStyleBackColor = true;
         this.buttonProfileAdd.Click += new System.EventHandler(this.buttonProfileAdd_Click);
         // 
         // labelProfileName
         // 
         this.labelProfileName.AutoSize = true;
         this.labelProfileName.Location = new System.Drawing.Point(3, 10);
         this.labelProfileName.Name = "labelProfileName";
         this.labelProfileName.Size = new System.Drawing.Size(39, 13);
         this.labelProfileName.TabIndex = 5;
         this.labelProfileName.Text = "Profile:";
         this.labelProfileName.Click += new System.EventHandler(this.label1_Click_4);
         // 
         // textBoxProfileName
         // 
         this.textBoxProfileName.BackColor = System.Drawing.SystemColors.InactiveBorder;
         this.textBoxProfileName.Enabled = false;
         this.textBoxProfileName.Location = new System.Drawing.Point(48, 7);
         this.textBoxProfileName.Name = "textBoxProfileName";
         this.textBoxProfileName.ReadOnly = true;
         this.textBoxProfileName.Size = new System.Drawing.Size(343, 20);
         this.textBoxProfileName.TabIndex = 4;
         this.textBoxProfileName.Text = "no Profile";
         this.textBoxProfileName.TextChanged += new System.EventHandler(this.TextBoxProfileName_TextChanged);
         // 
         // labelProfile
         // 
         this.labelProfile.AutoSize = true;
         this.labelProfile.Location = new System.Drawing.Point(6, 36);
         this.labelProfile.Name = "labelProfile";
         this.labelProfile.Size = new System.Drawing.Size(40, 13);
         this.labelProfile.TabIndex = 1;
         this.labelProfile.Text = "Events";
         this.labelProfile.Click += new System.EventHandler(this.label1_Click);
         // 
         // listViewProfileEvents
         // 
         this.listViewProfileEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderAircaft,
            this.columnHeaderName,
            this.columnHeaderCondition,
            this.columnHeaderDevice,
            this.columnHeaderLed,
            this.columnHeaderColorOn,
            this.columnHeaderColorFlashing,
            this.columnHeaderDescription});
         this.listViewProfileEvents.FullRowSelect = true;
         this.listViewProfileEvents.GridLines = true;
         this.listViewProfileEvents.HideSelection = false;
         this.listViewProfileEvents.Location = new System.Drawing.Point(9, 52);
         this.listViewProfileEvents.MultiSelect = false;
         this.listViewProfileEvents.Name = "listViewProfileEvents";
         this.listViewProfileEvents.Size = new System.Drawing.Size(886, 505);
         this.listViewProfileEvents.TabIndex = 0;
         this.listViewProfileEvents.UseCompatibleStateImageBehavior = false;
         this.listViewProfileEvents.View = System.Windows.Forms.View.Details;
         this.listViewProfileEvents.SelectedIndexChanged += new System.EventHandler(this.listViewProfileEvents_SelectedIndexChanged);
         // 
         // columnHeaderId
         // 
         this.columnHeaderId.Text = "ID";
         this.columnHeaderId.Width = 43;
         // 
         // columnHeaderAircaft
         // 
         this.columnHeaderAircaft.Text = "Aircraft";
         this.columnHeaderAircaft.Width = 90;
         // 
         // columnHeaderName
         // 
         this.columnHeaderName.Text = "Name";
         this.columnHeaderName.Width = 180;
         // 
         // columnHeaderCondition
         // 
         this.columnHeaderCondition.Text = "Condition";
         this.columnHeaderCondition.Width = 125;
         // 
         // columnHeaderDevice
         // 
         this.columnHeaderDevice.Text = "Device";
         this.columnHeaderDevice.Width = 50;
         // 
         // columnHeaderLed
         // 
         this.columnHeaderLed.Text = "LED";
         this.columnHeaderLed.Width = 40;
         // 
         // columnHeaderColorOn
         // 
         this.columnHeaderColorOn.Text = "Color On";
         this.columnHeaderColorOn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         this.columnHeaderColorOn.Width = 70;
         // 
         // columnHeaderColorFlashing
         // 
         this.columnHeaderColorFlashing.Text = "Color Flash";
         this.columnHeaderColorFlashing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         this.columnHeaderColorFlashing.Width = 70;
         // 
         // columnHeaderDescription
         // 
         this.columnHeaderDescription.Text = "Description";
         this.columnHeaderDescription.Width = 311;
         // 
         // tabPageMapping
         // 
         this.tabPageMapping.Controls.Add(this.buttonMappingEdit);
         this.tabPageMapping.Controls.Add(this.buttonMappingRemove);
         this.tabPageMapping.Controls.Add(this.buttonMappingAdd);
         this.tabPageMapping.Controls.Add(this.label5);
         this.tabPageMapping.Controls.Add(this.labelMappingProfileName);
         this.tabPageMapping.Controls.Add(this.textBoxMappingProfileName);
         this.tabPageMapping.Controls.Add(this.listViewMapping);
         this.tabPageMapping.Location = new System.Drawing.Point(4, 22);
         this.tabPageMapping.Name = "tabPageMapping";
         this.tabPageMapping.Padding = new System.Windows.Forms.Padding(3);
         this.tabPageMapping.Size = new System.Drawing.Size(993, 563);
         this.tabPageMapping.TabIndex = 3;
         this.tabPageMapping.Text = "Mapping";
         this.tabPageMapping.UseVisualStyleBackColor = true;
         // 
         // buttonMappingEdit
         // 
         this.buttonMappingEdit.Enabled = false;
         this.buttonMappingEdit.Location = new System.Drawing.Point(494, 110);
         this.buttonMappingEdit.Name = "buttonMappingEdit";
         this.buttonMappingEdit.Size = new System.Drawing.Size(75, 23);
         this.buttonMappingEdit.TabIndex = 11;
         this.buttonMappingEdit.Text = "Edit";
         this.buttonMappingEdit.UseVisualStyleBackColor = true;
         this.buttonMappingEdit.Click += new System.EventHandler(this.buttonMappingEdit_Click);
         // 
         // buttonMappingRemove
         // 
         this.buttonMappingRemove.Enabled = false;
         this.buttonMappingRemove.Location = new System.Drawing.Point(494, 81);
         this.buttonMappingRemove.Name = "buttonMappingRemove";
         this.buttonMappingRemove.Size = new System.Drawing.Size(75, 23);
         this.buttonMappingRemove.TabIndex = 10;
         this.buttonMappingRemove.Text = "Remove";
         this.buttonMappingRemove.UseVisualStyleBackColor = true;
         this.buttonMappingRemove.Click += new System.EventHandler(this.buttonMappingRemove_Click);
         // 
         // buttonMappingAdd
         // 
         this.buttonMappingAdd.Location = new System.Drawing.Point(494, 52);
         this.buttonMappingAdd.Name = "buttonMappingAdd";
         this.buttonMappingAdd.Size = new System.Drawing.Size(75, 23);
         this.buttonMappingAdd.TabIndex = 9;
         this.buttonMappingAdd.Text = "Add";
         this.buttonMappingAdd.UseVisualStyleBackColor = true;
         this.buttonMappingAdd.Click += new System.EventHandler(this.buttonMappingAdd_Click);
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(6, 36);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(90, 13);
         this.label5.TabIndex = 8;
         this.label5.Text = "Map of Event IDs";
         // 
         // labelMappingProfileName
         // 
         this.labelMappingProfileName.AutoSize = true;
         this.labelMappingProfileName.Location = new System.Drawing.Point(3, 10);
         this.labelMappingProfileName.Name = "labelMappingProfileName";
         this.labelMappingProfileName.Size = new System.Drawing.Size(39, 13);
         this.labelMappingProfileName.TabIndex = 7;
         this.labelMappingProfileName.Text = "Profile:";
         // 
         // textBoxMappingProfileName
         // 
         this.textBoxMappingProfileName.BackColor = System.Drawing.SystemColors.InactiveBorder;
         this.textBoxMappingProfileName.Enabled = false;
         this.textBoxMappingProfileName.Location = new System.Drawing.Point(48, 7);
         this.textBoxMappingProfileName.Name = "textBoxMappingProfileName";
         this.textBoxMappingProfileName.ReadOnly = true;
         this.textBoxMappingProfileName.Size = new System.Drawing.Size(343, 20);
         this.textBoxMappingProfileName.TabIndex = 6;
         this.textBoxMappingProfileName.Text = "no Profile";
         // 
         // listViewMapping
         // 
         this.listViewMapping.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader2});
         this.listViewMapping.FullRowSelect = true;
         this.listViewMapping.GridLines = true;
         this.listViewMapping.HideSelection = false;
         this.listViewMapping.Location = new System.Drawing.Point(9, 52);
         this.listViewMapping.MultiSelect = false;
         this.listViewMapping.Name = "listViewMapping";
         this.listViewMapping.Size = new System.Drawing.Size(479, 505);
         this.listViewMapping.Sorting = System.Windows.Forms.SortOrder.Ascending;
         this.listViewMapping.TabIndex = 1;
         this.listViewMapping.UseCompatibleStateImageBehavior = false;
         this.listViewMapping.View = System.Windows.Forms.View.Details;
         this.listViewMapping.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
         // 
         // columnHeader1
         // 
         this.columnHeader1.Text = "ID";
         this.columnHeader1.Width = 43;
         // 
         // columnHeader4
         // 
         this.columnHeader4.Text = "Aircraft";
         this.columnHeader4.Width = 110;
         // 
         // columnHeader2
         // 
         this.columnHeader2.Text = "Name";
         this.columnHeader2.Width = 212;
         // 
         // tabPageSettings
         // 
         this.tabPageSettings.Controls.Add(this.groupBox2);
         this.tabPageSettings.Controls.Add(this.groupBox1);
         this.tabPageSettings.Controls.Add(this.labelSettingsDescriptionFlashingCycles);
         this.tabPageSettings.Controls.Add(this.textBoxSettingsFlashingCycles);
         this.tabPageSettings.Controls.Add(this.labelSettings);
         this.tabPageSettings.Controls.Add(this.buttonSettingsCancel);
         this.tabPageSettings.Controls.Add(this.buttonSettingsSave);
         this.tabPageSettings.Controls.Add(this.buttonSettingsEditDevice);
         this.tabPageSettings.Controls.Add(this.buttonSettingsRemoveDevice);
         this.tabPageSettings.Controls.Add(this.buttonSettingsAddDevice);
         this.tabPageSettings.Controls.Add(this.labelSettingsDevices);
         this.tabPageSettings.Controls.Add(this.listViewSettingsDevices);
         this.tabPageSettings.Controls.Add(this.labelSettingsDescriptionUpdateInterval);
         this.tabPageSettings.Controls.Add(this.labelSettingsDescriptionDataInterval);
         this.tabPageSettings.Controls.Add(this.textBoxSettingsDataInterval);
         this.tabPageSettings.Controls.Add(this.labelSettingsDataInterval);
         this.tabPageSettings.Controls.Add(this.textBoxSettingsUpdateInterval);
         this.tabPageSettings.Controls.Add(this.labelSettingsUpdateInterval);
         this.tabPageSettings.Controls.Add(this.buttonChooseDefaultProfile);
         this.tabPageSettings.Controls.Add(this.textBoxSettingsDefaultProfile);
         this.tabPageSettings.Controls.Add(this.labelSettingsDefaultProfile);
         this.tabPageSettings.Controls.Add(this.buttonChooseVirpilLedControl);
         this.tabPageSettings.Controls.Add(this.textBoxSettingsVirpilLedControl);
         this.tabPageSettings.Controls.Add(this.labelSettingsVirpilLEDControl);
         this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
         this.tabPageSettings.Name = "tabPageSettings";
         this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
         this.tabPageSettings.Size = new System.Drawing.Size(993, 563);
         this.tabPageSettings.TabIndex = 2;
         this.tabPageSettings.Text = "Settings";
         this.tabPageSettings.UseVisualStyleBackColor = true;
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.label4);
         this.groupBox2.Controls.Add(this.label3);
         this.groupBox2.Controls.Add(this.label2);
         this.groupBox2.Controls.Add(this.label1);
         this.groupBox2.Location = new System.Drawing.Point(563, 407);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(414, 92);
         this.groupBox2.TabIndex = 24;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Information";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(68, 20);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(51, 13);
         this.label4.TabIndex = 3;
         this.label4.Text = "unknown";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(6, 20);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(45, 13);
         this.label3.TabIndex = 2;
         this.label3.Text = "Version:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(68, 42);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(51, 13);
         this.label2.TabIndex = 1;
         this.label2.Text = "unknown";
         this.label2.Click += new System.EventHandler(this.label2_Click_1);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(6, 42);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(56, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "BuildDate:";
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.comboBoxLogLevel);
         this.groupBox1.Controls.Add(this.labelLogLevel);
         this.groupBox1.Controls.Add(this.checkBox3);
         this.groupBox1.Controls.Add(this.checkBox2);
         this.groupBox1.Controls.Add(this.checkBox1);
         this.groupBox1.Controls.Add(this.checkBoxAutostart);
         this.groupBox1.Location = new System.Drawing.Point(563, 36);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(414, 365);
         this.groupBox1.TabIndex = 23;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "System";
         // 
         // comboBoxLogLevel
         // 
         this.comboBoxLogLevel.Items.AddRange(new object[] {
            "OFF",
            "ERROR",
            "WARNING",
            "INFO",
            "DEBUG",
            "TRACE"});
         this.comboBoxLogLevel.Location = new System.Drawing.Point(12, 147);
         this.comboBoxLogLevel.Name = "comboBoxLogLevel";
         this.comboBoxLogLevel.Size = new System.Drawing.Size(121, 21);
         this.comboBoxLogLevel.TabIndex = 27;
         this.comboBoxLogLevel.Text = "INFO";
         this.comboBoxLogLevel.SelectedIndexChanged += new System.EventHandler(this.comboBoxLogLevel_SelectedIndexChanged);
         // 
         // labelLogLevel
         // 
         this.labelLogLevel.AutoSize = true;
         this.labelLogLevel.Location = new System.Drawing.Point(9, 127);
         this.labelLogLevel.Name = "labelLogLevel";
         this.labelLogLevel.Size = new System.Drawing.Size(57, 13);
         this.labelLogLevel.TabIndex = 26;
         this.labelLogLevel.Text = "Log Level:";
         // 
         // checkBox3
         // 
         this.checkBox3.AutoSize = true;
         this.checkBox3.Enabled = false;
         this.checkBox3.Location = new System.Drawing.Point(6, 65);
         this.checkBox3.Name = "checkBox3";
         this.checkBox3.Size = new System.Drawing.Size(187, 17);
         this.checkBox3.TabIndex = 25;
         this.checkBox3.Text = "Start as Service (not implemented)";
         this.checkBox3.UseVisualStyleBackColor = true;
         // 
         // checkBox2
         // 
         this.checkBox2.AutoSize = true;
         this.checkBox2.Enabled = false;
         this.checkBox2.Location = new System.Drawing.Point(6, 88);
         this.checkBox2.Name = "checkBox2";
         this.checkBox2.Size = new System.Drawing.Size(204, 17);
         this.checkBox2.TabIndex = 24;
         this.checkBox2.Text = "Check For Updates (not implemented)";
         this.checkBox2.UseVisualStyleBackColor = true;
         this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
         // 
         // checkBox1
         // 
         this.checkBox1.AutoSize = true;
         this.checkBox1.Enabled = false;
         this.checkBox1.Location = new System.Drawing.Point(6, 42);
         this.checkBox1.Name = "checkBox1";
         this.checkBox1.Size = new System.Drawing.Size(94, 17);
         this.checkBox1.TabIndex = 23;
         this.checkBox1.Text = "Query on Start";
         this.checkBox1.UseVisualStyleBackColor = true;
         // 
         // checkBoxAutostart
         // 
         this.checkBoxAutostart.AutoSize = true;
         this.checkBoxAutostart.Checked = true;
         this.checkBoxAutostart.CheckState = System.Windows.Forms.CheckState.Checked;
         this.checkBoxAutostart.Enabled = false;
         this.checkBoxAutostart.Location = new System.Drawing.Point(6, 19);
         this.checkBoxAutostart.Name = "checkBoxAutostart";
         this.checkBoxAutostart.Size = new System.Drawing.Size(113, 17);
         this.checkBoxAutostart.TabIndex = 22;
         this.checkBoxAutostart.Text = "Start Automatically";
         this.checkBoxAutostart.UseVisualStyleBackColor = true;
         this.checkBoxAutostart.CheckedChanged += new System.EventHandler(this.checkBoxAutostart_CheckedChanged);
         // 
         // labelSettingsDescriptionFlashingCycles
         // 
         this.labelSettingsDescriptionFlashingCycles.AutoSize = true;
         this.labelSettingsDescriptionFlashingCycles.ForeColor = System.Drawing.Color.DimGray;
         this.labelSettingsDescriptionFlashingCycles.Location = new System.Drawing.Point(173, 147);
         this.labelSettingsDescriptionFlashingCycles.Name = "labelSettingsDescriptionFlashingCycles";
         this.labelSettingsDescriptionFlashingCycles.Size = new System.Drawing.Size(162, 13);
         this.labelSettingsDescriptionFlashingCycles.TabIndex = 21;
         this.labelSettingsDescriptionFlashingCycles.Text = "Update Cycles betweed flashing ";
         // 
         // textBoxSettingsFlashingCycles
         // 
         this.textBoxSettingsFlashingCycles.Location = new System.Drawing.Point(114, 144);
         this.textBoxSettingsFlashingCycles.Name = "textBoxSettingsFlashingCycles";
         this.textBoxSettingsFlashingCycles.Size = new System.Drawing.Size(52, 20);
         this.textBoxSettingsFlashingCycles.TabIndex = 20;
         this.textBoxSettingsFlashingCycles.TextChanged += new System.EventHandler(this.textBoxSettingsFlashingCycles_TextChanged);
         // 
         // labelSettings
         // 
         this.labelSettings.Location = new System.Drawing.Point(8, 147);
         this.labelSettings.Name = "labelSettings";
         this.labelSettings.Size = new System.Drawing.Size(100, 13);
         this.labelSettings.TabIndex = 19;
         this.labelSettings.Text = "Flashing Cycles:";
         // 
         // buttonSettingsCancel
         // 
         this.buttonSettingsCancel.Enabled = false;
         this.buttonSettingsCancel.Location = new System.Drawing.Point(902, 524);
         this.buttonSettingsCancel.Name = "buttonSettingsCancel";
         this.buttonSettingsCancel.Size = new System.Drawing.Size(75, 23);
         this.buttonSettingsCancel.TabIndex = 18;
         this.buttonSettingsCancel.Text = "Cancel";
         this.buttonSettingsCancel.UseVisualStyleBackColor = true;
         this.buttonSettingsCancel.Click += new System.EventHandler(this.buttonSettingsCancel_Click);
         // 
         // buttonSettingsSave
         // 
         this.buttonSettingsSave.Enabled = false;
         this.buttonSettingsSave.Location = new System.Drawing.Point(821, 524);
         this.buttonSettingsSave.Name = "buttonSettingsSave";
         this.buttonSettingsSave.Size = new System.Drawing.Size(75, 23);
         this.buttonSettingsSave.TabIndex = 17;
         this.buttonSettingsSave.Text = "Save";
         this.buttonSettingsSave.UseVisualStyleBackColor = true;
         this.buttonSettingsSave.Click += new System.EventHandler(this.buttonSettingsSave_Click);
         // 
         // buttonSettingsEditDevice
         // 
         this.buttonSettingsEditDevice.Enabled = false;
         this.buttonSettingsEditDevice.Location = new System.Drawing.Point(418, 275);
         this.buttonSettingsEditDevice.Name = "buttonSettingsEditDevice";
         this.buttonSettingsEditDevice.Size = new System.Drawing.Size(94, 23);
         this.buttonSettingsEditDevice.TabIndex = 16;
         this.buttonSettingsEditDevice.Text = "Edit Device";
         this.buttonSettingsEditDevice.UseVisualStyleBackColor = true;
         this.buttonSettingsEditDevice.Click += new System.EventHandler(this.buttonSettingsEditDevice_Click);
         // 
         // buttonSettingsRemoveDevice
         // 
         this.buttonSettingsRemoveDevice.Enabled = false;
         this.buttonSettingsRemoveDevice.Location = new System.Drawing.Point(418, 246);
         this.buttonSettingsRemoveDevice.Name = "buttonSettingsRemoveDevice";
         this.buttonSettingsRemoveDevice.Size = new System.Drawing.Size(94, 23);
         this.buttonSettingsRemoveDevice.TabIndex = 15;
         this.buttonSettingsRemoveDevice.Text = "Remove Device";
         this.buttonSettingsRemoveDevice.UseVisualStyleBackColor = true;
         this.buttonSettingsRemoveDevice.Click += new System.EventHandler(this.buttonSettingsRemoveDevice_Click);
         // 
         // buttonSettingsAddDevice
         // 
         this.buttonSettingsAddDevice.Location = new System.Drawing.Point(418, 217);
         this.buttonSettingsAddDevice.Name = "buttonSettingsAddDevice";
         this.buttonSettingsAddDevice.Size = new System.Drawing.Size(94, 23);
         this.buttonSettingsAddDevice.TabIndex = 14;
         this.buttonSettingsAddDevice.Text = "Add Device";
         this.buttonSettingsAddDevice.UseVisualStyleBackColor = true;
         this.buttonSettingsAddDevice.Click += new System.EventHandler(this.buttonSettingsAddDevice_Click);
         // 
         // labelSettingsDevices
         // 
         this.labelSettingsDevices.Location = new System.Drawing.Point(8, 217);
         this.labelSettingsDevices.Name = "labelSettingsDevices";
         this.labelSettingsDevices.Size = new System.Drawing.Size(100, 13);
         this.labelSettingsDevices.TabIndex = 13;
         this.labelSettingsDevices.Text = "Virpil Devices:";
         // 
         // listViewSettingsDevices
         // 
         this.listViewSettingsDevices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnDevicesName,
            this.columnDevicesVID,
            this.columnDevicesPID});
         this.listViewSettingsDevices.FullRowSelect = true;
         this.listViewSettingsDevices.GridLines = true;
         this.listViewSettingsDevices.HideSelection = false;
         this.listViewSettingsDevices.Location = new System.Drawing.Point(114, 217);
         this.listViewSettingsDevices.MultiSelect = false;
         this.listViewSettingsDevices.Name = "listViewSettingsDevices";
         this.listViewSettingsDevices.Size = new System.Drawing.Size(298, 282);
         this.listViewSettingsDevices.TabIndex = 12;
         this.listViewSettingsDevices.UseCompatibleStateImageBehavior = false;
         this.listViewSettingsDevices.View = System.Windows.Forms.View.Details;
         this.listViewSettingsDevices.SelectedIndexChanged += new System.EventHandler(this.listViewSettingsDevices_SelectedIndexChanged);
         // 
         // columnId
         // 
         this.columnId.Text = "ID";
         this.columnId.Width = 33;
         // 
         // columnDevicesName
         // 
         this.columnDevicesName.Text = "Name";
         this.columnDevicesName.Width = 146;
         // 
         // columnDevicesVID
         // 
         this.columnDevicesVID.Text = "VID";
         // 
         // columnDevicesPID
         // 
         this.columnDevicesPID.Text = "PID";
         this.columnDevicesPID.Width = 53;
         // 
         // labelSettingsDescriptionUpdateInterval
         // 
         this.labelSettingsDescriptionUpdateInterval.AutoSize = true;
         this.labelSettingsDescriptionUpdateInterval.ForeColor = System.Drawing.Color.DimGray;
         this.labelSettingsDescriptionUpdateInterval.Location = new System.Drawing.Point(173, 113);
         this.labelSettingsDescriptionUpdateInterval.Name = "labelSettingsDescriptionUpdateInterval";
         this.labelSettingsDescriptionUpdateInterval.Size = new System.Drawing.Size(184, 13);
         this.labelSettingsDescriptionUpdateInterval.TabIndex = 11;
         this.labelSettingsDescriptionUpdateInterval.Text = "Interval in seconds for updating LEDs";
         this.labelSettingsDescriptionUpdateInterval.Click += new System.EventHandler(this.label2_Click);
         // 
         // labelSettingsDescriptionDataInterval
         // 
         this.labelSettingsDescriptionDataInterval.AutoSize = true;
         this.labelSettingsDescriptionDataInterval.ForeColor = System.Drawing.Color.DimGray;
         this.labelSettingsDescriptionDataInterval.Location = new System.Drawing.Point(173, 181);
         this.labelSettingsDescriptionDataInterval.Name = "labelSettingsDescriptionDataInterval";
         this.labelSettingsDescriptionDataInterval.Size = new System.Drawing.Size(181, 13);
         this.labelSettingsDescriptionDataInterval.TabIndex = 10;
         this.labelSettingsDescriptionDataInterval.Text = "Interval in seconds for receiving data";
         // 
         // textBoxSettingsDataInterval
         // 
         this.textBoxSettingsDataInterval.Enabled = false;
         this.textBoxSettingsDataInterval.Location = new System.Drawing.Point(114, 178);
         this.textBoxSettingsDataInterval.Name = "textBoxSettingsDataInterval";
         this.textBoxSettingsDataInterval.Size = new System.Drawing.Size(52, 20);
         this.textBoxSettingsDataInterval.TabIndex = 9;
         this.textBoxSettingsDataInterval.TextChanged += new System.EventHandler(this.textBoxSettingsDataInterval_TextChanged);
         // 
         // labelSettingsDataInterval
         // 
         this.labelSettingsDataInterval.Location = new System.Drawing.Point(8, 181);
         this.labelSettingsDataInterval.Name = "labelSettingsDataInterval";
         this.labelSettingsDataInterval.Size = new System.Drawing.Size(100, 13);
         this.labelSettingsDataInterval.TabIndex = 8;
         this.labelSettingsDataInterval.Text = "Data Interval:";
         // 
         // textBoxSettingsUpdateInterval
         // 
         this.textBoxSettingsUpdateInterval.Location = new System.Drawing.Point(114, 110);
         this.textBoxSettingsUpdateInterval.Name = "textBoxSettingsUpdateInterval";
         this.textBoxSettingsUpdateInterval.Size = new System.Drawing.Size(52, 20);
         this.textBoxSettingsUpdateInterval.TabIndex = 7;
         this.textBoxSettingsUpdateInterval.TextChanged += new System.EventHandler(this.textBoxSettingsUpdatenterval_TextChanged);
         // 
         // labelSettingsUpdateInterval
         // 
         this.labelSettingsUpdateInterval.Location = new System.Drawing.Point(8, 113);
         this.labelSettingsUpdateInterval.Name = "labelSettingsUpdateInterval";
         this.labelSettingsUpdateInterval.Size = new System.Drawing.Size(100, 13);
         this.labelSettingsUpdateInterval.TabIndex = 6;
         this.labelSettingsUpdateInterval.Text = "Update Interval:";
         this.labelSettingsUpdateInterval.Click += new System.EventHandler(this.label1_Click_6);
         // 
         // buttonChooseDefaultProfile
         // 
         this.buttonChooseDefaultProfile.Location = new System.Drawing.Point(481, 73);
         this.buttonChooseDefaultProfile.Name = "buttonChooseDefaultProfile";
         this.buttonChooseDefaultProfile.Size = new System.Drawing.Size(31, 22);
         this.buttonChooseDefaultProfile.TabIndex = 5;
         this.buttonChooseDefaultProfile.Text = "...";
         this.buttonChooseDefaultProfile.UseVisualStyleBackColor = true;
         this.buttonChooseDefaultProfile.Click += new System.EventHandler(this.buttonChooseDefaultProfile_Click);
         // 
         // textBoxSettingsDefaultProfile
         // 
         this.textBoxSettingsDefaultProfile.Location = new System.Drawing.Point(114, 74);
         this.textBoxSettingsDefaultProfile.Name = "textBoxSettingsDefaultProfile";
         this.textBoxSettingsDefaultProfile.ReadOnly = true;
         this.textBoxSettingsDefaultProfile.Size = new System.Drawing.Size(361, 20);
         this.textBoxSettingsDefaultProfile.TabIndex = 4;
         // 
         // labelSettingsDefaultProfile
         // 
         this.labelSettingsDefaultProfile.Location = new System.Drawing.Point(8, 77);
         this.labelSettingsDefaultProfile.Name = "labelSettingsDefaultProfile";
         this.labelSettingsDefaultProfile.Size = new System.Drawing.Size(100, 13);
         this.labelSettingsDefaultProfile.TabIndex = 3;
         this.labelSettingsDefaultProfile.Text = "Default Profile:";
         // 
         // buttonChooseVirpilLedControl
         // 
         this.buttonChooseVirpilLedControl.Location = new System.Drawing.Point(481, 36);
         this.buttonChooseVirpilLedControl.Name = "buttonChooseVirpilLedControl";
         this.buttonChooseVirpilLedControl.Size = new System.Drawing.Size(31, 22);
         this.buttonChooseVirpilLedControl.TabIndex = 2;
         this.buttonChooseVirpilLedControl.Text = "...";
         this.buttonChooseVirpilLedControl.UseVisualStyleBackColor = true;
         this.buttonChooseVirpilLedControl.Click += new System.EventHandler(this.buttonChooseVirpilLedControl_Click);
         // 
         // textBoxSettingsVirpilLedControl
         // 
         this.textBoxSettingsVirpilLedControl.Location = new System.Drawing.Point(114, 37);
         this.textBoxSettingsVirpilLedControl.Name = "textBoxSettingsVirpilLedControl";
         this.textBoxSettingsVirpilLedControl.ReadOnly = true;
         this.textBoxSettingsVirpilLedControl.Size = new System.Drawing.Size(361, 20);
         this.textBoxSettingsVirpilLedControl.TabIndex = 1;
         // 
         // labelSettingsVirpilLEDControl
         // 
         this.labelSettingsVirpilLEDControl.Location = new System.Drawing.Point(8, 41);
         this.labelSettingsVirpilLEDControl.Name = "labelSettingsVirpilLEDControl";
         this.labelSettingsVirpilLEDControl.Size = new System.Drawing.Size(100, 13);
         this.labelSettingsVirpilLEDControl.TabIndex = 0;
         this.labelSettingsVirpilLEDControl.Text = "Virpil LED Control:";
         // 
         // buttonMainStart
         // 
         this.buttonMainStart.AccessibleName = "buttonMainStart";
         this.buttonMainStart.Location = new System.Drawing.Point(12, 28);
         this.buttonMainStart.Name = "buttonMainStart";
         this.buttonMainStart.Size = new System.Drawing.Size(81, 23);
         this.buttonMainStart.TabIndex = 2;
         this.buttonMainStart.Text = "START";
         this.buttonMainStart.UseVisualStyleBackColor = true;
         this.buttonMainStart.Click += new System.EventHandler(this.buttonMainStart_Click);
         // 
         // buttonMainLoad
         // 
         this.buttonMainLoad.Location = new System.Drawing.Point(12, 57);
         this.buttonMainLoad.Name = "buttonMainLoad";
         this.buttonMainLoad.Size = new System.Drawing.Size(81, 23);
         this.buttonMainLoad.TabIndex = 3;
         this.buttonMainLoad.Text = "Load Profile";
         this.buttonMainLoad.UseVisualStyleBackColor = true;
         this.buttonMainLoad.Click += new System.EventHandler(this.buttonMainLoadProfile_Click);
         // 
         // buttonMainSave
         // 
         this.buttonMainSave.Location = new System.Drawing.Point(12, 88);
         this.buttonMainSave.Name = "buttonMainSave";
         this.buttonMainSave.Size = new System.Drawing.Size(81, 23);
         this.buttonMainSave.TabIndex = 4;
         this.buttonMainSave.Text = "Save Profile";
         this.buttonMainSave.UseVisualStyleBackColor = true;
         this.buttonMainSave.Click += new System.EventHandler(this.buttonMainSaveProfile_Click);
         // 
         // buttonMainSetLed
         // 
         this.buttonMainSetLed.Enabled = false;
         this.buttonMainSetLed.Location = new System.Drawing.Point(12, 117);
         this.buttonMainSetLed.Name = "buttonMainSetLed";
         this.buttonMainSetLed.Size = new System.Drawing.Size(81, 23);
         this.buttonMainSetLed.TabIndex = 5;
         this.buttonMainSetLed.Text = "Set LED";
         this.buttonMainSetLed.UseVisualStyleBackColor = true;
         this.buttonMainSetLed.Click += new System.EventHandler(this.buttonMainSetLed_Click);
         // 
         // buttonDataQuery
         // 
         this.buttonDataQuery.Enabled = false;
         this.buttonDataQuery.Location = new System.Drawing.Point(12, 146);
         this.buttonDataQuery.Name = "buttonDataQuery";
         this.buttonDataQuery.Size = new System.Drawing.Size(81, 23);
         this.buttonDataQuery.TabIndex = 6;
         this.buttonDataQuery.Text = "Query";
         this.buttonDataQuery.UseVisualStyleBackColor = true;
         this.buttonDataQuery.Click += new System.EventHandler(this.button1_Click_2);
         // 
         // radioButtonAll
         // 
         this.radioButtonAll.AutoSize = true;
         this.radioButtonAll.Location = new System.Drawing.Point(3, 26);
         this.radioButtonAll.Name = "radioButtonAll";
         this.radioButtonAll.Size = new System.Drawing.Size(36, 17);
         this.radioButtonAll.TabIndex = 7;
         this.radioButtonAll.Text = "All";
         this.radioButtonAll.UseVisualStyleBackColor = true;
         // 
         // radioRegistered
         // 
         this.radioRegistered.AutoSize = true;
         this.radioRegistered.Checked = true;
         this.radioRegistered.Location = new System.Drawing.Point(3, 3);
         this.radioRegistered.Name = "radioRegistered";
         this.radioRegistered.Size = new System.Drawing.Size(76, 17);
         this.radioRegistered.TabIndex = 8;
         this.radioRegistered.TabStop = true;
         this.radioRegistered.Text = "Registered";
         this.radioRegistered.UseVisualStyleBackColor = true;
         // 
         // panelMode
         // 
         this.panelMode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.panelMode.Controls.Add(this.radioRegistered);
         this.panelMode.Controls.Add(this.radioButtonAll);
         this.panelMode.Location = new System.Drawing.Point(12, 291);
         this.panelMode.Name = "panelMode";
         this.panelMode.Size = new System.Drawing.Size(83, 56);
         this.panelMode.TabIndex = 9;
         this.panelMode.Visible = false;
         // 
         // labelMode
         // 
         this.labelMode.AutoSize = true;
         this.labelMode.Location = new System.Drawing.Point(12, 213);
         this.labelMode.Name = "labelMode";
         this.labelMode.Size = new System.Drawing.Size(37, 13);
         this.labelMode.TabIndex = 9;
         this.labelMode.Text = "Mode:";
         this.labelMode.Visible = false;
         // 
         // panel1
         // 
         this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.panel1.Controls.Add(this.radioButtonFull);
         this.panel1.Controls.Add(this.radioButtonChanges);
         this.panel1.Location = new System.Drawing.Point(12, 229);
         this.panel1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(83, 56);
         this.panel1.TabIndex = 10;
         this.panel1.Visible = false;
         // 
         // radioButtonFull
         // 
         this.radioButtonFull.AutoSize = true;
         this.radioButtonFull.Location = new System.Drawing.Point(3, 26);
         this.radioButtonFull.Name = "radioButtonFull";
         this.radioButtonFull.Size = new System.Drawing.Size(41, 17);
         this.radioButtonFull.TabIndex = 8;
         this.radioButtonFull.TabStop = true;
         this.radioButtonFull.Text = "Full";
         this.radioButtonFull.UseVisualStyleBackColor = true;
         // 
         // radioButtonChanges
         // 
         this.radioButtonChanges.AutoSize = true;
         this.radioButtonChanges.Checked = true;
         this.radioButtonChanges.Location = new System.Drawing.Point(3, 3);
         this.radioButtonChanges.Name = "radioButtonChanges";
         this.radioButtonChanges.Size = new System.Drawing.Size(67, 17);
         this.radioButtonChanges.TabIndex = 7;
         this.radioButtonChanges.TabStop = true;
         this.radioButtonChanges.Text = "Changes";
         this.radioButtonChanges.UseVisualStyleBackColor = true;
         this.radioButtonChanges.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
         // 
         // buttonRegister
         // 
         this.buttonRegister.Location = new System.Drawing.Point(12, 175);
         this.buttonRegister.Name = "buttonRegister";
         this.buttonRegister.Size = new System.Drawing.Size(81, 23);
         this.buttonRegister.TabIndex = 11;
         this.buttonRegister.Text = "Register";
         this.buttonRegister.UseVisualStyleBackColor = true;
         this.buttonRegister.Visible = false;
         this.buttonRegister.Click += new System.EventHandler(this.button1_Click);
         // 
         // openFileDialog1
         // 
         this.openFileDialog1.FileName = "openFileDialog1";
         // 
         // openFileDialog2
         // 
         this.openFileDialog2.FileName = "openFileDialog2";
         // 
         // openFileDialog3
         // 
         this.openFileDialog3.FileName = "openFileDialog3";
         // 
         // progressBarEngineStatus
         // 
         this.progressBarEngineStatus.Location = new System.Drawing.Point(17, 601);
         this.progressBarEngineStatus.MarqueeAnimationSpeed = 0;
         this.progressBarEngineStatus.Maximum = 20;
         this.progressBarEngineStatus.Name = "progressBarEngineStatus";
         this.progressBarEngineStatus.Size = new System.Drawing.Size(83, 16);
         this.progressBarEngineStatus.Step = 2;
         this.progressBarEngineStatus.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
         this.progressBarEngineStatus.TabIndex = 12;
         // 
         // MainWindowForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.ControlLightLight;
         this.ClientSize = new System.Drawing.Size(1170, 629);
         this.Controls.Add(this.progressBarEngineStatus);
         this.Controls.Add(this.buttonRegister);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.labelMode);
         this.Controls.Add(this.panelMode);
         this.Controls.Add(this.buttonMainSetLed);
         this.Controls.Add(this.buttonDataQuery);
         this.Controls.Add(this.buttonMainSave);
         this.Controls.Add(this.buttonMainLoad);
         this.Controls.Add(this.buttonMainStart);
         this.Controls.Add(this.tabMain);
         this.Controls.Add(this.menuStrip1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "MainWindowForm";
         this.ShowIcon = false;
         this.Text = "VLEDCONTROL";
         this.Load += new System.EventHandler(this.MainWindowForm_Load);
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.tabMain.ResumeLayout(false);
         this.tabPageData.ResumeLayout(false);
         this.tabPageData.PerformLayout();
         this.tabPageProfile.ResumeLayout(false);
         this.tabPageProfile.PerformLayout();
         this.panel3.ResumeLayout(false);
         this.panel3.PerformLayout();
         this.tabPageMapping.ResumeLayout(false);
         this.tabPageMapping.PerformLayout();
         this.tabPageSettings.ResumeLayout(false);
         this.tabPageSettings.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.panelMode.ResumeLayout(false);
         this.panelMode.PerformLayout();
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
      private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
      private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
      private System.Windows.Forms.ToolStripMenuItem loadProfileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem saveProfileToolStripMenuItem;
      private System.Windows.Forms.TabControl tabMain;
      private System.Windows.Forms.TabPage tabPageData;
      private System.Windows.Forms.TabPage tabPageProfile;
      private System.Windows.Forms.Label labelProfile;
      private System.Windows.Forms.Label labelDataCurrent;
      public System.Windows.Forms.ListView listViewData;
      private System.Windows.Forms.ColumnHeader columnHeaderId;
      private System.Windows.Forms.ColumnHeader columnHeaderCondition;
      private System.Windows.Forms.ColumnHeader columnHeaderAircaft;
      private System.Windows.Forms.ColumnHeader columnHeaderColorOn;
      private System.Windows.Forms.ColumnHeader columnHeaderDescription;
      private System.Windows.Forms.ColumnHeader columnHeaderDataId;
      private System.Windows.Forms.ColumnHeader columnHeaderDataValue;
      private System.Windows.Forms.ColumnHeader columnHeaderName;
      private System.Windows.Forms.ColumnHeader columnHeaderDataName;
      private System.Windows.Forms.Button buttonMainLoad;
      private System.Windows.Forms.Button buttonMainSave;
      private System.Windows.Forms.Button buttonMainSetLed;
      private System.Windows.Forms.Button buttonDataQuery;
      private System.Windows.Forms.RadioButton radioRegistered;
      private System.Windows.Forms.RadioButton radioButtonAll;
      private System.Windows.Forms.Panel panelMode;
      private System.Windows.Forms.Label labelMode;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.RadioButton radioButtonFull;
      private System.Windows.Forms.RadioButton radioButtonChanges;
      private System.Windows.Forms.Label labelProfileName;
      public System.Windows.Forms.TextBox textBoxAircraft;
      private System.Windows.Forms.Label labelDataRegistered;
      private System.Windows.Forms.CheckBox checkBoxDataShowUnregistered;
      private System.Windows.Forms.ListView listViewRegistered;
      private System.Windows.Forms.ColumnHeader columnRegisteredId;
      private System.Windows.Forms.ColumnHeader columnRegisteredName;
      private System.Windows.Forms.Button buttonRegister;
      private System.Windows.Forms.TabPage tabPageSettings;
      private System.Windows.Forms.ColumnHeader columnHeaderLastChange;
      private System.Windows.Forms.Label labelSettingsUpdateInterval;
      private System.Windows.Forms.Label labelSettingsDefaultProfile;
      private System.Windows.Forms.Label labelSettingsVirpilLEDControl;
      private System.Windows.Forms.Label labelSettingsDescriptionUpdateInterval;
      private System.Windows.Forms.Label labelSettingsDescriptionDataInterval;
      private System.Windows.Forms.Label labelSettingsDataInterval;
      private System.Windows.Forms.Button buttonRegisterAdd;
      private System.Windows.Forms.Button buttonRegisterRemove;
      private System.Windows.Forms.CheckBox checkBoxDataShowUnknown;
      private System.Windows.Forms.Label labelSettingsDevices;
      private System.Windows.Forms.Button buttonSettingsRemoveDevice;
      private System.Windows.Forms.Button buttonSettingsAddDevice;
      private System.Windows.Forms.ColumnHeader columnDevicesName;
      private System.Windows.Forms.ColumnHeader columnDevicesVID;
      private System.Windows.Forms.ColumnHeader columnDevicesPID;
      private System.Windows.Forms.Button buttonSettingsEditDevice;
      private System.Windows.Forms.ColumnHeader columnId;
      private System.Windows.Forms.Label labelSettingsDescriptionFlashingCycles;
      private System.Windows.Forms.Label labelSettings;
      public System.Windows.Forms.Button buttonChooseVirpilLedControl;
      public System.Windows.Forms.TextBox textBoxSettingsVirpilLedControl;
      public System.Windows.Forms.Button buttonChooseDefaultProfile;
      public System.Windows.Forms.TextBox textBoxSettingsDefaultProfile;
      public System.Windows.Forms.Button buttonSettingsCancel;
      public System.Windows.Forms.Button buttonSettingsSave;
      public System.Windows.Forms.TextBox textBoxSettingsDataInterval;
      public System.Windows.Forms.TextBox textBoxSettingsUpdateInterval;
      public System.Windows.Forms.TextBox textBoxSettingsFlashingCycles;
      internal System.Windows.Forms.ListView listViewSettingsDevices;
      private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem installExportScrriptsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem setLEDCOntrolToolStripMenuItem;
      private System.Windows.Forms.Button buttonProfileDown;
      private System.Windows.Forms.Button buttonProfileUp;
      private System.Windows.Forms.Button buttonProfileEdit;
      private System.Windows.Forms.Button buttonProfileRemove;
      private System.Windows.Forms.Button buttonProfileAdd;
      private System.Windows.Forms.TabPage tabPageMapping;
      private System.Windows.Forms.ColumnHeader columnHeader1;
      private System.Windows.Forms.ColumnHeader columnHeader4;
      private System.Windows.Forms.ColumnHeader columnHeader2;
      private System.Windows.Forms.ColumnHeader columnHeaderDevice;
      private System.Windows.Forms.ColumnHeader columnHeaderColorFlashing;
      internal System.Windows.Forms.ListView listViewProfileEvents;
      internal System.Windows.Forms.TextBox textBoxProfileName;
      private System.Windows.Forms.GroupBox groupBox1;
      internal System.Windows.Forms.CheckBox checkBoxAutostart;
      private System.Windows.Forms.OpenFileDialog openFileDialog1;
      private System.Windows.Forms.OpenFileDialog openFileDialog2;
      private System.Windows.Forms.OpenFileDialog openFileDialog3;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      internal System.Windows.Forms.CheckBox checkBox2;
      internal System.Windows.Forms.CheckBox checkBox1;
      private System.Windows.Forms.Label labelMappingProfileName;
      internal System.Windows.Forms.TextBox textBoxMappingProfileName;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Panel panel3;
      private System.Windows.Forms.Button buttonProfileDuplicate;
      internal System.Windows.Forms.CheckBox checkBox3;
      private System.Windows.Forms.Label labelLogLevel;
      internal System.Windows.Forms.ComboBox comboBoxLogLevel;
      private System.Windows.Forms.Button buttonMappingEdit;
      private System.Windows.Forms.Button buttonMappingRemove;
      private System.Windows.Forms.Button buttonMappingAdd;
      internal System.Windows.Forms.ListView listViewMapping;
      internal System.Windows.Forms.Button buttonMainStart;
      private System.Windows.Forms.Button buttonRegisterFromProfile;
      internal System.Windows.Forms.ProgressBar progressBarEngineStatus;
      internal System.Windows.Forms.RadioButton radioButtonNewElementsAppend;
      internal System.Windows.Forms.RadioButton radioButtonNewElementsInsertAfter;
      internal System.Windows.Forms.RadioButton radioButtonNewElementsInsertBefore;
      private System.Windows.Forms.ColumnHeader columnHeaderLed;
      private System.Windows.Forms.ToolStripMenuItem removeExportScriptsToolStripMenuItem;
      private System.Windows.Forms.Button buttonProfilesClear;
      private System.Windows.Forms.Button buttonCopyAircraftToClipboard;
   }
}

