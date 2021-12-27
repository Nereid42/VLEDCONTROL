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
         this.tabMain = new System.Windows.Forms.TabControl();
         this.tabPageData = new System.Windows.Forms.TabPage();
         this.panel2 = new System.Windows.Forms.Panel();
         this.checkBoxLiveDataEnabled = new System.Windows.Forms.CheckBox();
         this.buttonCopyAircraftToClipboard = new System.Windows.Forms.Button();
         this.buttonRegisterFromProfile = new System.Windows.Forms.Button();
         this.checkBoxDataShowUnknown = new System.Windows.Forms.CheckBox();
         this.buttonRegisterRemove = new System.Windows.Forms.Button();
         this.buttonRegisterAdd = new System.Windows.Forms.Button();
         this.checkBoxData10Only = new System.Windows.Forms.CheckBox();
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
         this.buttonProfileEnable = new System.Windows.Forms.Button();
         this.checkBoxHighlightLed = new System.Windows.Forms.CheckBox();
         this.buttonQuickAdd = new System.Windows.Forms.Button();
         this.groupBoxFilterProfile = new System.Windows.Forms.GroupBox();
         this.button1 = new System.Windows.Forms.Button();
         this.comboBoxProfileFilterDevice = new System.Windows.Forms.ComboBox();
         this.label2 = new System.Windows.Forms.Label();
         this.checkBoxProfileFilterStatic = new System.Windows.Forms.CheckBox();
         this.label1 = new System.Windows.Forms.Label();
         this.comboBoxProfileFilterAircraft = new System.Windows.Forms.ComboBox();
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
         this.columnHeaderEnabled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeaderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.tabPageMapping = new System.Windows.Forms.TabPage();
         this.labelMappingCurrentAircraft = new System.Windows.Forms.Label();
         this.textBoxMappingCurrentAircraft = new System.Windows.Forms.TextBox();
         this.buttonCopyMappingToCurrentAircraft = new System.Windows.Forms.Button();
         this.labelMappingNumberOfAircrafts = new System.Windows.Forms.Label();
         this.labelMappingNumberOfMappings = new System.Windows.Forms.Label();
         this.buttonImportFromProfile = new System.Windows.Forms.Button();
         this.groupBoxFilterMapping = new System.Windows.Forms.GroupBox();
         this.buttonCurrentAircraft = new System.Windows.Forms.Button();
         this.label7 = new System.Windows.Forms.Label();
         this.comboBoxMappingFilterAircraft = new System.Windows.Forms.ComboBox();
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
         this.textBoxNumberLedChangesPerSecond = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.textBoxTimeUsedLedCalcPercent = new System.Windows.Forms.TextBox();
         this.textBoxNumberLedChanges = new System.Windows.Forms.TextBox();
         this.textBoxTimeUsedLedCalc = new System.Windows.Forms.TextBox();
         this.textBoxTimeRunning = new System.Windows.Forms.TextBox();
         this.labelTimeUsedLedCalc = new System.Windows.Forms.Label();
         this.labelTimeRunning = new System.Windows.Forms.Label();
         this.labelNumberLedChanges = new System.Windows.Forms.Label();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.listViewIdLimit = new System.Windows.Forms.ListView();
         this.columnIdLimitAircraft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnIdLimitValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.checkBoxEnableStatistics = new System.Windows.Forms.CheckBox();
         this.comboBoxLogLevel = new System.Windows.Forms.ComboBox();
         this.labelLogLevel = new System.Windows.Forms.Label();
         this.checkBox3 = new System.Windows.Forms.CheckBox();
         this.checkBox2 = new System.Windows.Forms.CheckBox();
         this.checkBoxAutostartEnabled = new System.Windows.Forms.CheckBox();
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
         this.buttonMainStart = new System.Windows.Forms.Button();
         this.buttonMainLoad = new System.Windows.Forms.Button();
         this.buttonMainSave = new System.Windows.Forms.Button();
         this.buttonMainSetLeds = new System.Windows.Forms.Button();
         this.buttonDataQuery = new System.Windows.Forms.Button();
         this.radioButtonAll = new System.Windows.Forms.RadioButton();
         this.radioRegistered = new System.Windows.Forms.RadioButton();
         this.panelMode = new System.Windows.Forms.Panel();
         this.labelMode = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         this.radioButtonFull = new System.Windows.Forms.RadioButton();
         this.radioButtonChanges = new System.Windows.Forms.RadioButton();
         this.buttonRegister = new System.Windows.Forms.Button();
         this.progressBarEngineStatus = new System.Windows.Forms.ProgressBar();
         this.buttonMainResetLeds = new System.Windows.Forms.Button();
         this.buttonMainMerge = new System.Windows.Forms.Button();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.loadProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.installExportScrriptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.removeExportScriptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.copyDefaultProfileMappingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolTip = new System.Windows.Forms.ToolTip(this.components);
         this.tabMain.SuspendLayout();
         this.tabPageData.SuspendLayout();
         this.panel2.SuspendLayout();
         this.tabPageProfile.SuspendLayout();
         this.groupBoxFilterProfile.SuspendLayout();
         this.panel3.SuspendLayout();
         this.tabPageMapping.SuspendLayout();
         this.groupBoxFilterMapping.SuspendLayout();
         this.tabPageSettings.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.groupBox1.SuspendLayout();
         this.panelMode.SuspendLayout();
         this.panel1.SuspendLayout();
         this.menuStrip1.SuspendLayout();
         this.SuspendLayout();
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
         this.tabPageData.Controls.Add(this.panel2);
         this.tabPageData.Controls.Add(this.buttonCopyAircraftToClipboard);
         this.tabPageData.Controls.Add(this.buttonRegisterFromProfile);
         this.tabPageData.Controls.Add(this.checkBoxDataShowUnknown);
         this.tabPageData.Controls.Add(this.buttonRegisterRemove);
         this.tabPageData.Controls.Add(this.buttonRegisterAdd);
         this.tabPageData.Controls.Add(this.checkBoxData10Only);
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
         // panel2
         // 
         this.panel2.BackColor = System.Drawing.SystemColors.Control;
         this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel2.Controls.Add(this.checkBoxLiveDataEnabled);
         this.panel2.Location = new System.Drawing.Point(438, 537);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(65, 20);
         this.panel2.TabIndex = 13;
         // 
         // checkBoxLiveDataEnabled
         // 
         this.checkBoxLiveDataEnabled.AutoSize = true;
         this.checkBoxLiveDataEnabled.Checked = true;
         this.checkBoxLiveDataEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
         this.checkBoxLiveDataEnabled.Location = new System.Drawing.Point(3, 2);
         this.checkBoxLiveDataEnabled.Name = "checkBoxLiveDataEnabled";
         this.checkBoxLiveDataEnabled.Size = new System.Drawing.Size(65, 17);
         this.checkBoxLiveDataEnabled.TabIndex = 12;
         this.checkBoxLiveDataEnabled.Text = "Enabled";
         this.checkBoxLiveDataEnabled.UseVisualStyleBackColor = true;
         this.checkBoxLiveDataEnabled.CheckedChanged += new System.EventHandler(this.checkBoxLiveDataEnabled_CheckedChanged);
         // 
         // buttonCopyAircraftToClipboard
         // 
         this.buttonCopyAircraftToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopyAircraftToClipboard.Image")));
         this.buttonCopyAircraftToClipboard.Location = new System.Drawing.Point(158, 5);
         this.buttonCopyAircraftToClipboard.Name = "buttonCopyAircraftToClipboard";
         this.buttonCopyAircraftToClipboard.Size = new System.Drawing.Size(22, 22);
         this.buttonCopyAircraftToClipboard.TabIndex = 11;
         this.toolTip.SetToolTip(this.buttonCopyAircraftToClipboard, "Copy current aircraft");
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
         this.checkBoxDataShowUnknown.Location = new System.Drawing.Point(98, 540);
         this.checkBoxDataShowUnknown.Name = "checkBoxDataShowUnknown";
         this.checkBoxDataShowUnknown.Size = new System.Drawing.Size(102, 17);
         this.checkBoxDataShowUnknown.TabIndex = 9;
         this.checkBoxDataShowUnknown.Text = "Show Unknown";
         this.checkBoxDataShowUnknown.UseVisualStyleBackColor = true;
         this.checkBoxDataShowUnknown.CheckedChanged += new System.EventHandler(this.checkBoxDataShowUnknown_CheckedChanged);
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
         // checkBoxData10Only
         // 
         this.checkBoxData10Only.AutoSize = true;
         this.checkBoxData10Only.Location = new System.Drawing.Point(9, 540);
         this.checkBoxData10Only.Name = "checkBoxData10Only";
         this.checkBoxData10Only.Size = new System.Drawing.Size(83, 17);
         this.checkBoxData10Only.TabIndex = 6;
         this.checkBoxData10Only.Text = "0.0/1.0 only";
         this.checkBoxData10Only.UseVisualStyleBackColor = true;
         this.checkBoxData10Only.CheckedChanged += new System.EventHandler(this.checkBoxData10Only_CheckedChanged);
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
         this.toolTip.SetToolTip(this.textBoxAircraft, "Current aircraft");
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
         this.tabPageProfile.Controls.Add(this.buttonProfileEnable);
         this.tabPageProfile.Controls.Add(this.checkBoxHighlightLed);
         this.tabPageProfile.Controls.Add(this.buttonQuickAdd);
         this.tabPageProfile.Controls.Add(this.groupBoxFilterProfile);
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
         // buttonProfileEnable
         // 
         this.buttonProfileEnable.Enabled = false;
         this.buttonProfileEnable.Location = new System.Drawing.Point(901, 220);
         this.buttonProfileEnable.Name = "buttonProfileEnable";
         this.buttonProfileEnable.Size = new System.Drawing.Size(75, 23);
         this.buttonProfileEnable.TabIndex = 18;
         this.buttonProfileEnable.Text = "Disable";
         this.buttonProfileEnable.UseVisualStyleBackColor = true;
         this.buttonProfileEnable.Click += new System.EventHandler(this.buttonEnable_Click);
         // 
         // checkBoxHighlightLed
         // 
         this.checkBoxHighlightLed.AutoSize = true;
         this.checkBoxHighlightLed.Location = new System.Drawing.Point(901, 539);
         this.checkBoxHighlightLed.Name = "checkBoxHighlightLed";
         this.checkBoxHighlightLed.Size = new System.Drawing.Size(91, 17);
         this.checkBoxHighlightLed.TabIndex = 17;
         this.checkBoxHighlightLed.Text = "Highlight LED";
         this.checkBoxHighlightLed.UseVisualStyleBackColor = true;
         this.checkBoxHighlightLed.CheckedChanged += new System.EventHandler(this.checkBoxHighlightLed_CheckedChanged);
         // 
         // buttonQuickAdd
         // 
         this.buttonQuickAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.buttonQuickAdd.ForeColor = System.Drawing.Color.SeaGreen;
         this.buttonQuickAdd.Location = new System.Drawing.Point(901, 52);
         this.buttonQuickAdd.Name = "buttonQuickAdd";
         this.buttonQuickAdd.Size = new System.Drawing.Size(75, 46);
         this.buttonQuickAdd.TabIndex = 16;
         this.buttonQuickAdd.Text = "Quick Add";
         this.buttonQuickAdd.UseVisualStyleBackColor = true;
         this.buttonQuickAdd.Click += new System.EventHandler(this.buttonQuickAdd_Click);
         // 
         // groupBoxFilterProfile
         // 
         this.groupBoxFilterProfile.Controls.Add(this.button1);
         this.groupBoxFilterProfile.Controls.Add(this.comboBoxProfileFilterDevice);
         this.groupBoxFilterProfile.Controls.Add(this.label2);
         this.groupBoxFilterProfile.Controls.Add(this.checkBoxProfileFilterStatic);
         this.groupBoxFilterProfile.Controls.Add(this.label1);
         this.groupBoxFilterProfile.Controls.Add(this.comboBoxProfileFilterAircraft);
         this.groupBoxFilterProfile.Location = new System.Drawing.Point(414, 0);
         this.groupBoxFilterProfile.Name = "groupBoxFilterProfile";
         this.groupBoxFilterProfile.Size = new System.Drawing.Size(561, 46);
         this.groupBoxFilterProfile.TabIndex = 15;
         this.groupBoxFilterProfile.TabStop = false;
         this.groupBoxFilterProfile.Text = "Filter";
         // 
         // button1
         // 
         this.button1.Image = global::VLEDCONTROL.Properties.Resources.CurrentAircraftIcon;
         this.button1.Location = new System.Drawing.Point(208, 13);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(23, 23);
         this.button1.TabIndex = 17;
         this.toolTip.SetToolTip(this.button1, "Set to current aircraft");
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click_4);
         // 
         // comboBoxProfileFilterDevice
         // 
         this.comboBoxProfileFilterDevice.FormattingEnabled = true;
         this.comboBoxProfileFilterDevice.Items.AddRange(new object[] {
            "ANY"});
         this.comboBoxProfileFilterDevice.Location = new System.Drawing.Point(284, 14);
         this.comboBoxProfileFilterDevice.Name = "comboBoxProfileFilterDevice";
         this.comboBoxProfileFilterDevice.Size = new System.Drawing.Size(149, 21);
         this.comboBoxProfileFilterDevice.TabIndex = 4;
         this.comboBoxProfileFilterDevice.Text = "ANY";
         this.comboBoxProfileFilterDevice.SelectedIndexChanged += new System.EventHandler(this.comboBoxProfileFilterDevice_SelectedIndexChanged);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(237, 18);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(41, 13);
         this.label2.TabIndex = 3;
         this.label2.Text = "Device";
         // 
         // checkBoxProfileFilterStatic
         // 
         this.checkBoxProfileFilterStatic.AutoSize = true;
         this.checkBoxProfileFilterStatic.Checked = true;
         this.checkBoxProfileFilterStatic.CheckState = System.Windows.Forms.CheckState.Checked;
         this.checkBoxProfileFilterStatic.Location = new System.Drawing.Point(448, 17);
         this.checkBoxProfileFilterStatic.Name = "checkBoxProfileFilterStatic";
         this.checkBoxProfileFilterStatic.Size = new System.Drawing.Size(53, 17);
         this.checkBoxProfileFilterStatic.TabIndex = 2;
         this.checkBoxProfileFilterStatic.Text = "Static";
         this.checkBoxProfileFilterStatic.UseVisualStyleBackColor = true;
         this.checkBoxProfileFilterStatic.CheckedChanged += new System.EventHandler(this.checkBoxFilterStatic_CheckedChanged);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(7, 17);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(40, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "Aircraft";
         // 
         // comboBoxProfileFilterAircraft
         // 
         this.comboBoxProfileFilterAircraft.FormattingEnabled = true;
         this.comboBoxProfileFilterAircraft.Items.AddRange(new object[] {
            "ANY"});
         this.comboBoxProfileFilterAircraft.Location = new System.Drawing.Point(53, 14);
         this.comboBoxProfileFilterAircraft.Name = "comboBoxProfileFilterAircraft";
         this.comboBoxProfileFilterAircraft.Size = new System.Drawing.Size(149, 21);
         this.comboBoxProfileFilterAircraft.TabIndex = 0;
         this.comboBoxProfileFilterAircraft.Text = "ANY ";
         this.comboBoxProfileFilterAircraft.SelectedIndexChanged += new System.EventHandler(this.comboBoxProfileFilterAircraft_SelectedIndexChanged);
         // 
         // buttonProfilesClear
         // 
         this.buttonProfilesClear.ForeColor = System.Drawing.Color.Maroon;
         this.buttonProfilesClear.Location = new System.Drawing.Point(901, 339);
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
         this.label6.Location = new System.Drawing.Point(898, 378);
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
         this.panel3.Location = new System.Drawing.Point(899, 394);
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
         this.radioButtonNewElementsInsertAfter.TabStop = true;
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
         this.radioButtonNewElementsInsertBefore.TabStop = true;
         this.radioButtonNewElementsInsertBefore.Text = "Before";
         this.radioButtonNewElementsInsertBefore.UseVisualStyleBackColor = true;
         // 
         // buttonProfileDuplicate
         // 
         this.buttonProfileDuplicate.Enabled = false;
         this.buttonProfileDuplicate.Location = new System.Drawing.Point(901, 133);
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
         this.buttonProfileDown.Location = new System.Drawing.Point(901, 294);
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
         this.buttonProfileUp.Location = new System.Drawing.Point(901, 265);
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
         this.buttonProfileEdit.Location = new System.Drawing.Point(901, 191);
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
         this.buttonProfileRemove.Location = new System.Drawing.Point(901, 162);
         this.buttonProfileRemove.Name = "buttonProfileRemove";
         this.buttonProfileRemove.Size = new System.Drawing.Size(75, 23);
         this.buttonProfileRemove.TabIndex = 7;
         this.buttonProfileRemove.Text = "Remove";
         this.buttonProfileRemove.UseVisualStyleBackColor = true;
         this.buttonProfileRemove.Click += new System.EventHandler(this.buttonProfileRemove_Click);
         // 
         // buttonProfileAdd
         // 
         this.buttonProfileAdd.Location = new System.Drawing.Point(901, 104);
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
            this.columnHeaderEnabled,
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
         this.columnHeaderName.Width = 176;
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
         this.columnHeaderLed.Width = 33;
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
         // columnHeaderEnabled
         // 
         this.columnHeaderEnabled.Text = "E";
         this.columnHeaderEnabled.Width = 18;
         // 
         // columnHeaderDescription
         // 
         this.columnHeaderDescription.Text = "Description";
         this.columnHeaderDescription.Width = 200;
         // 
         // tabPageMapping
         // 
         this.tabPageMapping.Controls.Add(this.labelMappingCurrentAircraft);
         this.tabPageMapping.Controls.Add(this.textBoxMappingCurrentAircraft);
         this.tabPageMapping.Controls.Add(this.buttonCopyMappingToCurrentAircraft);
         this.tabPageMapping.Controls.Add(this.labelMappingNumberOfAircrafts);
         this.tabPageMapping.Controls.Add(this.labelMappingNumberOfMappings);
         this.tabPageMapping.Controls.Add(this.buttonImportFromProfile);
         this.tabPageMapping.Controls.Add(this.groupBoxFilterMapping);
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
         // labelMappingCurrentAircraft
         // 
         this.labelMappingCurrentAircraft.AutoSize = true;
         this.labelMappingCurrentAircraft.Location = new System.Drawing.Point(733, 7);
         this.labelMappingCurrentAircraft.Name = "labelMappingCurrentAircraft";
         this.labelMappingCurrentAircraft.Size = new System.Drawing.Size(80, 13);
         this.labelMappingCurrentAircraft.TabIndex = 19;
         this.labelMappingCurrentAircraft.Text = "Current Aircraft:";
         // 
         // textBoxMappingCurrentAircraft
         // 
         this.textBoxMappingCurrentAircraft.BackColor = System.Drawing.SystemColors.InactiveBorder;
         this.textBoxMappingCurrentAircraft.Enabled = false;
         this.textBoxMappingCurrentAircraft.Location = new System.Drawing.Point(733, 25);
         this.textBoxMappingCurrentAircraft.Name = "textBoxMappingCurrentAircraft";
         this.textBoxMappingCurrentAircraft.ReadOnly = true;
         this.textBoxMappingCurrentAircraft.Size = new System.Drawing.Size(151, 20);
         this.textBoxMappingCurrentAircraft.TabIndex = 18;
         this.toolTip.SetToolTip(this.textBoxMappingCurrentAircraft, "Current aircraft");
         // 
         // buttonCopyMappingToCurrentAircraft
         // 
         this.buttonCopyMappingToCurrentAircraft.Enabled = false;
         this.buttonCopyMappingToCurrentAircraft.Location = new System.Drawing.Point(641, 7);
         this.buttonCopyMappingToCurrentAircraft.Name = "buttonCopyMappingToCurrentAircraft";
         this.buttonCopyMappingToCurrentAircraft.Size = new System.Drawing.Size(86, 38);
         this.buttonCopyMappingToCurrentAircraft.TabIndex = 17;
         this.buttonCopyMappingToCurrentAircraft.Text = "Copy To Current Aircraft";
         this.toolTip.SetToolTip(this.buttonCopyMappingToCurrentAircraft, "Add new mapping entry");
         this.buttonCopyMappingToCurrentAircraft.UseVisualStyleBackColor = true;
         this.buttonCopyMappingToCurrentAircraft.Click += new System.EventHandler(this.buttonCopyMappingToCurrentAircraft_Click);
         // 
         // labelMappingNumberOfAircrafts
         // 
         this.labelMappingNumberOfAircrafts.Location = new System.Drawing.Point(552, 544);
         this.labelMappingNumberOfAircrafts.Name = "labelMappingNumberOfAircrafts";
         this.labelMappingNumberOfAircrafts.Size = new System.Drawing.Size(250, 14);
         this.labelMappingNumberOfAircrafts.TabIndex = 16;
         this.labelMappingNumberOfAircrafts.Text = "0 Aircrafts";
         // 
         // labelMappingNumberOfMappings
         // 
         this.labelMappingNumberOfMappings.Location = new System.Drawing.Point(552, 520);
         this.labelMappingNumberOfMappings.Name = "labelMappingNumberOfMappings";
         this.labelMappingNumberOfMappings.Size = new System.Drawing.Size(250, 14);
         this.labelMappingNumberOfMappings.TabIndex = 15;
         this.labelMappingNumberOfMappings.Text = "0 Mappings";
         // 
         // buttonImportFromProfile
         // 
         this.buttonImportFromProfile.Location = new System.Drawing.Point(560, 164);
         this.buttonImportFromProfile.Name = "buttonImportFromProfile";
         this.buttonImportFromProfile.Size = new System.Drawing.Size(75, 23);
         this.buttonImportFromProfile.TabIndex = 14;
         this.buttonImportFromProfile.Text = "Import ...";
         this.toolTip.SetToolTip(this.buttonImportFromProfile, "Import mappings from other profile");
         this.buttonImportFromProfile.UseVisualStyleBackColor = true;
         this.buttonImportFromProfile.Click += new System.EventHandler(this.buttonImportFromProfile_Click);
         // 
         // groupBoxFilterMapping
         // 
         this.groupBoxFilterMapping.Controls.Add(this.buttonCurrentAircraft);
         this.groupBoxFilterMapping.Controls.Add(this.label7);
         this.groupBoxFilterMapping.Controls.Add(this.comboBoxMappingFilterAircraft);
         this.groupBoxFilterMapping.Location = new System.Drawing.Point(397, 1);
         this.groupBoxFilterMapping.Name = "groupBoxFilterMapping";
         this.groupBoxFilterMapping.Size = new System.Drawing.Size(238, 44);
         this.groupBoxFilterMapping.TabIndex = 13;
         this.groupBoxFilterMapping.TabStop = false;
         this.groupBoxFilterMapping.Text = "Filter";
         // 
         // buttonCurrentAircraft
         // 
         this.buttonCurrentAircraft.AccessibleDescription = "";
         this.buttonCurrentAircraft.Image = global::VLEDCONTROL.Properties.Resources.CurrentAircraftIcon;
         this.buttonCurrentAircraft.Location = new System.Drawing.Point(207, 13);
         this.buttonCurrentAircraft.Margin = new System.Windows.Forms.Padding(2);
         this.buttonCurrentAircraft.Name = "buttonCurrentAircraft";
         this.buttonCurrentAircraft.Size = new System.Drawing.Size(23, 23);
         this.buttonCurrentAircraft.TabIndex = 14;
         this.toolTip.SetToolTip(this.buttonCurrentAircraft, "Set to current aircraft");
         this.buttonCurrentAircraft.UseVisualStyleBackColor = true;
         this.buttonCurrentAircraft.Click += new System.EventHandler(this.buttonCurrentAircraft_Click);
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(7, 17);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(40, 13);
         this.label7.TabIndex = 13;
         this.label7.Text = "Aircraft";
         // 
         // comboBoxMappingFilterAircraft
         // 
         this.comboBoxMappingFilterAircraft.FormattingEnabled = true;
         this.comboBoxMappingFilterAircraft.Items.AddRange(new object[] {
            "ANY"});
         this.comboBoxMappingFilterAircraft.Location = new System.Drawing.Point(53, 14);
         this.comboBoxMappingFilterAircraft.Name = "comboBoxMappingFilterAircraft";
         this.comboBoxMappingFilterAircraft.Size = new System.Drawing.Size(149, 21);
         this.comboBoxMappingFilterAircraft.TabIndex = 12;
         this.comboBoxMappingFilterAircraft.Text = "ANY ";
         this.comboBoxMappingFilterAircraft.SelectedIndexChanged += new System.EventHandler(this.comboBoxMappingFilterAircraft_SelectedIndexChanged);
         // 
         // buttonMappingEdit
         // 
         this.buttonMappingEdit.Enabled = false;
         this.buttonMappingEdit.Location = new System.Drawing.Point(560, 110);
         this.buttonMappingEdit.Name = "buttonMappingEdit";
         this.buttonMappingEdit.Size = new System.Drawing.Size(75, 23);
         this.buttonMappingEdit.TabIndex = 11;
         this.buttonMappingEdit.Text = "Edit";
         this.toolTip.SetToolTip(this.buttonMappingEdit, "Edit selected mapping entry");
         this.buttonMappingEdit.UseVisualStyleBackColor = true;
         this.buttonMappingEdit.Click += new System.EventHandler(this.buttonMappingEdit_Click);
         // 
         // buttonMappingRemove
         // 
         this.buttonMappingRemove.Enabled = false;
         this.buttonMappingRemove.Location = new System.Drawing.Point(560, 81);
         this.buttonMappingRemove.Name = "buttonMappingRemove";
         this.buttonMappingRemove.Size = new System.Drawing.Size(75, 23);
         this.buttonMappingRemove.TabIndex = 10;
         this.buttonMappingRemove.Text = "Remove";
         this.toolTip.SetToolTip(this.buttonMappingRemove, "Remove selected mapping entry");
         this.buttonMappingRemove.UseVisualStyleBackColor = true;
         this.buttonMappingRemove.Click += new System.EventHandler(this.buttonMappingRemove_Click);
         // 
         // buttonMappingAdd
         // 
         this.buttonMappingAdd.Location = new System.Drawing.Point(560, 52);
         this.buttonMappingAdd.Name = "buttonMappingAdd";
         this.buttonMappingAdd.Size = new System.Drawing.Size(75, 23);
         this.buttonMappingAdd.TabIndex = 9;
         this.buttonMappingAdd.Text = "Add";
         this.toolTip.SetToolTip(this.buttonMappingAdd, "Add new mapping entry");
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
         this.listViewMapping.Size = new System.Drawing.Size(540, 505);
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
         this.groupBox2.Controls.Add(this.textBoxNumberLedChangesPerSecond);
         this.groupBox2.Controls.Add(this.label3);
         this.groupBox2.Controls.Add(this.textBoxTimeUsedLedCalcPercent);
         this.groupBox2.Controls.Add(this.textBoxNumberLedChanges);
         this.groupBox2.Controls.Add(this.textBoxTimeUsedLedCalc);
         this.groupBox2.Controls.Add(this.textBoxTimeRunning);
         this.groupBox2.Controls.Add(this.labelTimeUsedLedCalc);
         this.groupBox2.Controls.Add(this.labelTimeRunning);
         this.groupBox2.Controls.Add(this.labelNumberLedChanges);
         this.groupBox2.Location = new System.Drawing.Point(563, 407);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(414, 110);
         this.groupBox2.TabIndex = 24;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Statistics";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(393, 77);
         this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(17, 13);
         this.label4.TabIndex = 10;
         this.label4.Text = "/s";
         // 
         // textBoxNumberLedChangesPerSecond
         // 
         this.textBoxNumberLedChangesPerSecond.Location = new System.Drawing.Point(346, 74);
         this.textBoxNumberLedChangesPerSecond.Name = "textBoxNumberLedChangesPerSecond";
         this.textBoxNumberLedChangesPerSecond.ReadOnly = true;
         this.textBoxNumberLedChangesPerSecond.Size = new System.Drawing.Size(44, 20);
         this.textBoxNumberLedChangesPerSecond.TabIndex = 9;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(393, 51);
         this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(15, 13);
         this.label3.TabIndex = 8;
         this.label3.Text = "%";
         // 
         // textBoxTimeUsedLedCalcPercent
         // 
         this.textBoxTimeUsedLedCalcPercent.Location = new System.Drawing.Point(346, 48);
         this.textBoxTimeUsedLedCalcPercent.Name = "textBoxTimeUsedLedCalcPercent";
         this.textBoxTimeUsedLedCalcPercent.ReadOnly = true;
         this.textBoxTimeUsedLedCalcPercent.Size = new System.Drawing.Size(44, 20);
         this.textBoxTimeUsedLedCalcPercent.TabIndex = 7;
         // 
         // textBoxNumberLedChanges
         // 
         this.textBoxNumberLedChanges.Location = new System.Drawing.Point(171, 74);
         this.textBoxNumberLedChanges.Name = "textBoxNumberLedChanges";
         this.textBoxNumberLedChanges.ReadOnly = true;
         this.textBoxNumberLedChanges.Size = new System.Drawing.Size(162, 20);
         this.textBoxNumberLedChanges.TabIndex = 6;
         // 
         // textBoxTimeUsedLedCalc
         // 
         this.textBoxTimeUsedLedCalc.Location = new System.Drawing.Point(171, 48);
         this.textBoxTimeUsedLedCalc.Name = "textBoxTimeUsedLedCalc";
         this.textBoxTimeUsedLedCalc.ReadOnly = true;
         this.textBoxTimeUsedLedCalc.Size = new System.Drawing.Size(162, 20);
         this.textBoxTimeUsedLedCalc.TabIndex = 5;
         // 
         // textBoxTimeRunning
         // 
         this.textBoxTimeRunning.Location = new System.Drawing.Point(171, 22);
         this.textBoxTimeRunning.Name = "textBoxTimeRunning";
         this.textBoxTimeRunning.ReadOnly = true;
         this.textBoxTimeRunning.Size = new System.Drawing.Size(162, 20);
         this.textBoxTimeRunning.TabIndex = 4;
         // 
         // labelTimeUsedLedCalc
         // 
         this.labelTimeUsedLedCalc.AutoSize = true;
         this.labelTimeUsedLedCalc.Location = new System.Drawing.Point(6, 51);
         this.labelTimeUsedLedCalc.Name = "labelTimeUsedLedCalc";
         this.labelTimeUsedLedCalc.Size = new System.Drawing.Size(159, 13);
         this.labelTimeUsedLedCalc.TabIndex = 3;
         this.labelTimeUsedLedCalc.Text = "Time used LED calculation [ms]:";
         // 
         // labelTimeRunning
         // 
         this.labelTimeRunning.AutoSize = true;
         this.labelTimeRunning.Location = new System.Drawing.Point(9, 25);
         this.labelTimeRunning.Name = "labelTimeRunning";
         this.labelTimeRunning.Size = new System.Drawing.Size(93, 13);
         this.labelTimeRunning.TabIndex = 2;
         this.labelTimeRunning.Text = "Time running [ms]:";
         // 
         // labelNumberLedChanges
         // 
         this.labelNumberLedChanges.AutoSize = true;
         this.labelNumberLedChanges.Location = new System.Drawing.Point(9, 77);
         this.labelNumberLedChanges.Name = "labelNumberLedChanges";
         this.labelNumberLedChanges.Size = new System.Drawing.Size(127, 13);
         this.labelNumberLedChanges.TabIndex = 0;
         this.labelNumberLedChanges.Text = "Number of LED changes:";
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.listViewIdLimit);
         this.groupBox1.Controls.Add(this.checkBoxEnableStatistics);
         this.groupBox1.Controls.Add(this.comboBoxLogLevel);
         this.groupBox1.Controls.Add(this.labelLogLevel);
         this.groupBox1.Controls.Add(this.checkBox3);
         this.groupBox1.Controls.Add(this.checkBox2);
         this.groupBox1.Controls.Add(this.checkBoxAutostartEnabled);
         this.groupBox1.Location = new System.Drawing.Point(563, 36);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(414, 365);
         this.groupBox1.TabIndex = 23;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "System";
         // 
         // listViewIdLimit
         // 
         this.listViewIdLimit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIdLimitAircraft,
            this.columnIdLimitValue});
         this.listViewIdLimit.FullRowSelect = true;
         this.listViewIdLimit.GridLines = true;
         this.listViewIdLimit.HideSelection = false;
         this.listViewIdLimit.Location = new System.Drawing.Point(6, 194);
         this.listViewIdLimit.MultiSelect = false;
         this.listViewIdLimit.Name = "listViewIdLimit";
         this.listViewIdLimit.Size = new System.Drawing.Size(205, 165);
         this.listViewIdLimit.TabIndex = 29;
         this.listViewIdLimit.UseCompatibleStateImageBehavior = false;
         this.listViewIdLimit.View = System.Windows.Forms.View.Details;
         this.listViewIdLimit.Visible = false;
         this.listViewIdLimit.SelectedIndexChanged += new System.EventHandler(this.listViewIdLimit_SelectedIndexChanged);
         // 
         // columnIdLimitAircraft
         // 
         this.columnIdLimitAircraft.Text = "Aircraft";
         this.columnIdLimitAircraft.Width = 140;
         // 
         // columnIdLimitValue
         // 
         this.columnIdLimitValue.Text = "Max ID";
         // 
         // checkBoxEnableStatistics
         // 
         this.checkBoxEnableStatistics.AutoSize = true;
         this.checkBoxEnableStatistics.Checked = true;
         this.checkBoxEnableStatistics.CheckState = System.Windows.Forms.CheckState.Checked;
         this.checkBoxEnableStatistics.Location = new System.Drawing.Point(6, 87);
         this.checkBoxEnableStatistics.Name = "checkBoxEnableStatistics";
         this.checkBoxEnableStatistics.Size = new System.Drawing.Size(104, 17);
         this.checkBoxEnableStatistics.TabIndex = 28;
         this.checkBoxEnableStatistics.Text = "Enable Statistics";
         this.checkBoxEnableStatistics.UseVisualStyleBackColor = true;
         this.checkBoxEnableStatistics.CheckedChanged += new System.EventHandler(this.checkBoxEnableStatistics_CheckedChanged);
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
         this.comboBoxLogLevel.Location = new System.Drawing.Point(6, 142);
         this.comboBoxLogLevel.Name = "comboBoxLogLevel";
         this.comboBoxLogLevel.Size = new System.Drawing.Size(121, 21);
         this.comboBoxLogLevel.TabIndex = 27;
         this.comboBoxLogLevel.Text = "INFO";
         this.comboBoxLogLevel.SelectedIndexChanged += new System.EventHandler(this.comboBoxLogLevel_SelectedIndexChanged);
         // 
         // labelLogLevel
         // 
         this.labelLogLevel.AutoSize = true;
         this.labelLogLevel.Location = new System.Drawing.Point(3, 126);
         this.labelLogLevel.Name = "labelLogLevel";
         this.labelLogLevel.Size = new System.Drawing.Size(57, 13);
         this.labelLogLevel.TabIndex = 26;
         this.labelLogLevel.Text = "Log Level:";
         // 
         // checkBox3
         // 
         this.checkBox3.AutoSize = true;
         this.checkBox3.Enabled = false;
         this.checkBox3.Location = new System.Drawing.Point(6, 42);
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
         this.checkBox2.Location = new System.Drawing.Point(6, 65);
         this.checkBox2.Name = "checkBox2";
         this.checkBox2.Size = new System.Drawing.Size(201, 17);
         this.checkBox2.TabIndex = 24;
         this.checkBox2.Text = "Check for Updates (not implemented)";
         this.checkBox2.UseVisualStyleBackColor = true;
         this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
         // 
         // checkBoxAutostartEnabled
         // 
         this.checkBoxAutostartEnabled.AutoSize = true;
         this.checkBoxAutostartEnabled.Checked = true;
         this.checkBoxAutostartEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
         this.checkBoxAutostartEnabled.Location = new System.Drawing.Point(6, 19);
         this.checkBoxAutostartEnabled.Name = "checkBoxAutostartEnabled";
         this.checkBoxAutostartEnabled.Size = new System.Drawing.Size(113, 17);
         this.checkBoxAutostartEnabled.TabIndex = 22;
         this.checkBoxAutostartEnabled.Text = "Start Automatically";
         this.checkBoxAutostartEnabled.UseVisualStyleBackColor = true;
         this.checkBoxAutostartEnabled.CheckedChanged += new System.EventHandler(this.checkBoxAutostart_CheckedChanged);
         // 
         // labelSettingsDescriptionFlashingCycles
         // 
         this.labelSettingsDescriptionFlashingCycles.AutoSize = true;
         this.labelSettingsDescriptionFlashingCycles.ForeColor = System.Drawing.Color.DimGray;
         this.labelSettingsDescriptionFlashingCycles.Location = new System.Drawing.Point(173, 123);
         this.labelSettingsDescriptionFlashingCycles.Name = "labelSettingsDescriptionFlashingCycles";
         this.labelSettingsDescriptionFlashingCycles.Size = new System.Drawing.Size(162, 13);
         this.labelSettingsDescriptionFlashingCycles.TabIndex = 21;
         this.labelSettingsDescriptionFlashingCycles.Text = "Update Cycles betweed flashing ";
         // 
         // textBoxSettingsFlashingCycles
         // 
         this.textBoxSettingsFlashingCycles.Location = new System.Drawing.Point(114, 120);
         this.textBoxSettingsFlashingCycles.Name = "textBoxSettingsFlashingCycles";
         this.textBoxSettingsFlashingCycles.Size = new System.Drawing.Size(52, 20);
         this.textBoxSettingsFlashingCycles.TabIndex = 20;
         this.textBoxSettingsFlashingCycles.TextChanged += new System.EventHandler(this.textBoxSettingsFlashingCycles_TextChanged);
         // 
         // labelSettings
         // 
         this.labelSettings.Location = new System.Drawing.Point(8, 123);
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
         this.listViewSettingsDevices.Size = new System.Drawing.Size(298, 300);
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
         this.labelSettingsDescriptionUpdateInterval.Location = new System.Drawing.Point(173, 89);
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
         this.labelSettingsDescriptionDataInterval.Location = new System.Drawing.Point(173, 157);
         this.labelSettingsDescriptionDataInterval.Name = "labelSettingsDescriptionDataInterval";
         this.labelSettingsDescriptionDataInterval.Size = new System.Drawing.Size(181, 13);
         this.labelSettingsDescriptionDataInterval.TabIndex = 10;
         this.labelSettingsDescriptionDataInterval.Text = "Interval in seconds for receiving data";
         // 
         // textBoxSettingsDataInterval
         // 
         this.textBoxSettingsDataInterval.Location = new System.Drawing.Point(114, 154);
         this.textBoxSettingsDataInterval.Name = "textBoxSettingsDataInterval";
         this.textBoxSettingsDataInterval.Size = new System.Drawing.Size(52, 20);
         this.textBoxSettingsDataInterval.TabIndex = 9;
         this.textBoxSettingsDataInterval.TextChanged += new System.EventHandler(this.textBoxSettingsDataInterval_TextChanged);
         // 
         // labelSettingsDataInterval
         // 
         this.labelSettingsDataInterval.Location = new System.Drawing.Point(8, 157);
         this.labelSettingsDataInterval.Name = "labelSettingsDataInterval";
         this.labelSettingsDataInterval.Size = new System.Drawing.Size(100, 13);
         this.labelSettingsDataInterval.TabIndex = 8;
         this.labelSettingsDataInterval.Text = "Data Interval:";
         // 
         // textBoxSettingsUpdateInterval
         // 
         this.textBoxSettingsUpdateInterval.Location = new System.Drawing.Point(114, 86);
         this.textBoxSettingsUpdateInterval.Name = "textBoxSettingsUpdateInterval";
         this.textBoxSettingsUpdateInterval.Size = new System.Drawing.Size(52, 20);
         this.textBoxSettingsUpdateInterval.TabIndex = 7;
         this.textBoxSettingsUpdateInterval.TextChanged += new System.EventHandler(this.textBoxSettingsUpdatenterval_TextChanged);
         // 
         // labelSettingsUpdateInterval
         // 
         this.labelSettingsUpdateInterval.Location = new System.Drawing.Point(8, 89);
         this.labelSettingsUpdateInterval.Name = "labelSettingsUpdateInterval";
         this.labelSettingsUpdateInterval.Size = new System.Drawing.Size(100, 13);
         this.labelSettingsUpdateInterval.TabIndex = 6;
         this.labelSettingsUpdateInterval.Text = "Update Interval:";
         this.labelSettingsUpdateInterval.Click += new System.EventHandler(this.label1_Click_6);
         // 
         // buttonChooseDefaultProfile
         // 
         this.buttonChooseDefaultProfile.Location = new System.Drawing.Point(481, 49);
         this.buttonChooseDefaultProfile.Name = "buttonChooseDefaultProfile";
         this.buttonChooseDefaultProfile.Size = new System.Drawing.Size(31, 22);
         this.buttonChooseDefaultProfile.TabIndex = 5;
         this.buttonChooseDefaultProfile.Text = "...";
         this.buttonChooseDefaultProfile.UseVisualStyleBackColor = true;
         this.buttonChooseDefaultProfile.Click += new System.EventHandler(this.buttonChooseDefaultProfile_Click);
         // 
         // textBoxSettingsDefaultProfile
         // 
         this.textBoxSettingsDefaultProfile.Location = new System.Drawing.Point(114, 50);
         this.textBoxSettingsDefaultProfile.Name = "textBoxSettingsDefaultProfile";
         this.textBoxSettingsDefaultProfile.ReadOnly = true;
         this.textBoxSettingsDefaultProfile.Size = new System.Drawing.Size(361, 20);
         this.textBoxSettingsDefaultProfile.TabIndex = 4;
         // 
         // labelSettingsDefaultProfile
         // 
         this.labelSettingsDefaultProfile.Location = new System.Drawing.Point(8, 53);
         this.labelSettingsDefaultProfile.Name = "labelSettingsDefaultProfile";
         this.labelSettingsDefaultProfile.Size = new System.Drawing.Size(100, 13);
         this.labelSettingsDefaultProfile.TabIndex = 3;
         this.labelSettingsDefaultProfile.Text = "Default Profile:";
         // 
         // buttonMainStart
         // 
         this.buttonMainStart.AccessibleName = "buttonMainStart";
         this.buttonMainStart.Location = new System.Drawing.Point(12, 28);
         this.buttonMainStart.Name = "buttonMainStart";
         this.buttonMainStart.Size = new System.Drawing.Size(81, 23);
         this.buttonMainStart.TabIndex = 2;
         this.buttonMainStart.Text = "START";
         this.toolTip.SetToolTip(this.buttonMainStart, "START/STOP");
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
         this.toolTip.SetToolTip(this.buttonMainLoad, "Load a profile");
         this.buttonMainLoad.UseVisualStyleBackColor = true;
         this.buttonMainLoad.Click += new System.EventHandler(this.buttonMainLoadProfile_Click);
         // 
         // buttonMainSave
         // 
         this.buttonMainSave.Location = new System.Drawing.Point(12, 115);
         this.buttonMainSave.Name = "buttonMainSave";
         this.buttonMainSave.Size = new System.Drawing.Size(81, 23);
         this.buttonMainSave.TabIndex = 4;
         this.buttonMainSave.Text = "Save Profile";
         this.toolTip.SetToolTip(this.buttonMainSave, "Save  the current profile");
         this.buttonMainSave.UseVisualStyleBackColor = true;
         this.buttonMainSave.Click += new System.EventHandler(this.buttonMainSaveProfile_Click);
         // 
         // buttonMainSetLeds
         // 
         this.buttonMainSetLeds.Location = new System.Drawing.Point(12, 144);
         this.buttonMainSetLeds.Name = "buttonMainSetLeds";
         this.buttonMainSetLeds.Size = new System.Drawing.Size(81, 23);
         this.buttonMainSetLeds.TabIndex = 5;
         this.buttonMainSetLeds.Text = "Set LEDs";
         this.buttonMainSetLeds.UseVisualStyleBackColor = true;
         this.buttonMainSetLeds.Click += new System.EventHandler(this.buttonMainSetLed_Click);
         // 
         // buttonDataQuery
         // 
         this.buttonDataQuery.Location = new System.Drawing.Point(12, 202);
         this.buttonDataQuery.Name = "buttonDataQuery";
         this.buttonDataQuery.Size = new System.Drawing.Size(81, 23);
         this.buttonDataQuery.TabIndex = 6;
         this.buttonDataQuery.Text = "Query";
         this.toolTip.SetToolTip(this.buttonDataQuery, "Query the status from DCS");
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
         this.panelMode.Location = new System.Drawing.Point(12, 342);
         this.panelMode.Name = "panelMode";
         this.panelMode.Size = new System.Drawing.Size(81, 56);
         this.panelMode.TabIndex = 9;
         this.panelMode.Visible = false;
         // 
         // labelMode
         // 
         this.labelMode.AutoSize = true;
         this.labelMode.Location = new System.Drawing.Point(12, 264);
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
         this.panel1.Location = new System.Drawing.Point(12, 280);
         this.panel1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(81, 56);
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
         this.buttonRegister.Enabled = false;
         this.buttonRegister.Location = new System.Drawing.Point(12, 231);
         this.buttonRegister.Name = "buttonRegister";
         this.buttonRegister.Size = new System.Drawing.Size(81, 23);
         this.buttonRegister.TabIndex = 11;
         this.buttonRegister.Text = "Register";
         this.toolTip.SetToolTip(this.buttonRegister, "Not implemented");
         this.buttonRegister.UseVisualStyleBackColor = true;
         this.buttonRegister.Visible = false;
         this.buttonRegister.Click += new System.EventHandler(this.button1_Click);
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
         // buttonMainResetLeds
         // 
         this.buttonMainResetLeds.Location = new System.Drawing.Point(12, 173);
         this.buttonMainResetLeds.Name = "buttonMainResetLeds";
         this.buttonMainResetLeds.Size = new System.Drawing.Size(81, 23);
         this.buttonMainResetLeds.TabIndex = 13;
         this.buttonMainResetLeds.Text = "Reset LEDs";
         this.buttonMainResetLeds.UseVisualStyleBackColor = true;
         this.buttonMainResetLeds.Click += new System.EventHandler(this.buttonMainResetLed_Click_4);
         // 
         // buttonMainMerge
         // 
         this.buttonMainMerge.Location = new System.Drawing.Point(12, 86);
         this.buttonMainMerge.Name = "buttonMainMerge";
         this.buttonMainMerge.Size = new System.Drawing.Size(81, 23);
         this.buttonMainMerge.TabIndex = 14;
         this.buttonMainMerge.Text = "Merge Profile";
         this.toolTip.SetToolTip(this.buttonMainMerge, "Merge a profile into the current one");
         this.buttonMainMerge.UseVisualStyleBackColor = true;
         this.buttonMainMerge.Click += new System.EventHandler(this.buttonMainMerge_Click);
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
            this.removeExportScriptsToolStripMenuItem});
         this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
         this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
         this.setupToolStripMenuItem.Text = "Setup";
         // 
         // installExportScrriptsToolStripMenuItem
         // 
         this.installExportScrriptsToolStripMenuItem.Name = "installExportScrriptsToolStripMenuItem";
         this.installExportScrriptsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
         this.installExportScrriptsToolStripMenuItem.Text = "Install Export Scrripts";
         this.installExportScrriptsToolStripMenuItem.Click += new System.EventHandler(this.installExportScrriptsToolStripMenuItem_Click);
         // 
         // removeExportScriptsToolStripMenuItem
         // 
         this.removeExportScriptsToolStripMenuItem.Name = "removeExportScriptsToolStripMenuItem";
         this.removeExportScriptsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
         this.removeExportScriptsToolStripMenuItem.Text = "Remove Export Scripts";
         this.removeExportScriptsToolStripMenuItem.Click += new System.EventHandler(this.removeExportScriptsToolStripMenuItem_Click);
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
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.debugToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(1170, 24);
         this.menuStrip1.TabIndex = 0;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // debugToolStripMenuItem
         // 
         this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyDefaultProfileMappingToolStripMenuItem});
         this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
         this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
         this.debugToolStripMenuItem.Text = "Debug";
         this.debugToolStripMenuItem.Visible = false;
         // 
         // copyDefaultProfileMappingToolStripMenuItem
         // 
         this.copyDefaultProfileMappingToolStripMenuItem.Name = "copyDefaultProfileMappingToolStripMenuItem";
         this.copyDefaultProfileMappingToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
         this.copyDefaultProfileMappingToolStripMenuItem.Text = "CopyDefaultProfileMapping";
         this.copyDefaultProfileMappingToolStripMenuItem.Click += new System.EventHandler(this.copyDefaultProfileMappingToolStripMenuItem_Click);
         // 
         // MainWindowForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.ControlLightLight;
         this.ClientSize = new System.Drawing.Size(1170, 629);
         this.Controls.Add(this.buttonMainMerge);
         this.Controls.Add(this.buttonMainResetLeds);
         this.Controls.Add(this.progressBarEngineStatus);
         this.Controls.Add(this.buttonRegister);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.labelMode);
         this.Controls.Add(this.panelMode);
         this.Controls.Add(this.buttonMainSetLeds);
         this.Controls.Add(this.buttonDataQuery);
         this.Controls.Add(this.buttonMainSave);
         this.Controls.Add(this.buttonMainLoad);
         this.Controls.Add(this.buttonMainStart);
         this.Controls.Add(this.tabMain);
         this.Controls.Add(this.menuStrip1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "MainWindowForm";
         this.Text = "VLEDCONTROL";
         this.Load += new System.EventHandler(this.MainWindowForm_Load);
         this.tabMain.ResumeLayout(false);
         this.tabPageData.ResumeLayout(false);
         this.tabPageData.PerformLayout();
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         this.tabPageProfile.ResumeLayout(false);
         this.tabPageProfile.PerformLayout();
         this.groupBoxFilterProfile.ResumeLayout(false);
         this.groupBoxFilterProfile.PerformLayout();
         this.panel3.ResumeLayout(false);
         this.panel3.PerformLayout();
         this.tabPageMapping.ResumeLayout(false);
         this.tabPageMapping.PerformLayout();
         this.groupBoxFilterMapping.ResumeLayout(false);
         this.groupBoxFilterMapping.PerformLayout();
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
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
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
      private System.Windows.Forms.Button buttonMainSetLeds;
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
      private System.Windows.Forms.ListView listViewRegistered;
      private System.Windows.Forms.ColumnHeader columnRegisteredId;
      private System.Windows.Forms.ColumnHeader columnRegisteredName;
      private System.Windows.Forms.Button buttonRegister;
      private System.Windows.Forms.TabPage tabPageSettings;
      private System.Windows.Forms.ColumnHeader columnHeaderLastChange;
      private System.Windows.Forms.Label labelSettingsUpdateInterval;
      private System.Windows.Forms.Label labelSettingsDefaultProfile;
      private System.Windows.Forms.Label labelSettingsDescriptionUpdateInterval;
      private System.Windows.Forms.Label labelSettingsDescriptionDataInterval;
      private System.Windows.Forms.Label labelSettingsDataInterval;
      private System.Windows.Forms.Button buttonRegisterAdd;
      private System.Windows.Forms.Button buttonRegisterRemove;
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
      public System.Windows.Forms.Button buttonChooseDefaultProfile;
      public System.Windows.Forms.TextBox textBoxSettingsDefaultProfile;
      public System.Windows.Forms.Button buttonSettingsCancel;
      public System.Windows.Forms.Button buttonSettingsSave;
      public System.Windows.Forms.TextBox textBoxSettingsDataInterval;
      public System.Windows.Forms.TextBox textBoxSettingsUpdateInterval;
      public System.Windows.Forms.TextBox textBoxSettingsFlashingCycles;
      internal System.Windows.Forms.ListView listViewSettingsDevices;
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
      internal System.Windows.Forms.CheckBox checkBoxAutostartEnabled;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.Label labelNumberLedChanges;
      internal System.Windows.Forms.CheckBox checkBox2;
      private System.Windows.Forms.Label labelMappingProfileName;
      internal System.Windows.Forms.TextBox textBoxMappingProfileName;
      private System.Windows.Forms.Label labelTimeUsedLedCalc;
      private System.Windows.Forms.Label labelTimeRunning;
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
      private System.Windows.Forms.Button buttonProfilesClear;
      private System.Windows.Forms.Button buttonCopyAircraftToClipboard;
      internal System.Windows.Forms.CheckBox checkBoxEnableStatistics;
      internal System.Windows.Forms.TextBox textBoxNumberLedChanges;
      internal System.Windows.Forms.TextBox textBoxTimeUsedLedCalc;
      internal System.Windows.Forms.TextBox textBoxTimeRunning;
      private System.Windows.Forms.GroupBox groupBoxFilterProfile;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      internal System.Windows.Forms.CheckBox checkBoxLiveDataEnabled;
      private System.Windows.Forms.Panel panel2;
      internal System.Windows.Forms.CheckBox checkBoxProfileFilterStatic;
      internal System.Windows.Forms.ComboBox comboBoxProfileFilterDevice;
      internal System.Windows.Forms.ComboBox comboBoxProfileFilterAircraft;
      private System.Windows.Forms.Label label4;
      internal System.Windows.Forms.TextBox textBoxNumberLedChangesPerSecond;
      private System.Windows.Forms.Label label3;
      internal System.Windows.Forms.TextBox textBoxTimeUsedLedCalcPercent;
      private System.Windows.Forms.GroupBox groupBoxFilterMapping;
      internal System.Windows.Forms.ComboBox comboBoxMappingFilterAircraft;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Button buttonImportFromProfile;
      internal System.Windows.Forms.CheckBox checkBoxDataShowUnknown;
      private System.Windows.Forms.Button buttonQuickAdd;
      private System.Windows.Forms.Button buttonMainResetLeds;
      internal System.Windows.Forms.CheckBox checkBoxData10Only;
      private System.Windows.Forms.Label labelMappingNumberOfAircrafts;
      private System.Windows.Forms.Label labelMappingNumberOfMappings;
      private System.Windows.Forms.Button buttonMainMerge;
      private System.Windows.Forms.Button buttonCurrentAircraft;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem loadProfileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem saveProfileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem installExportScrriptsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem removeExportScriptsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolTip toolTip;
      internal System.Windows.Forms.TabControl tabMain;
      private System.Windows.Forms.Button button1;
      internal System.Windows.Forms.CheckBox checkBoxHighlightLed;
      private System.Windows.Forms.ColumnHeader columnHeaderEnabled;
      private System.Windows.Forms.Button buttonProfileEnable;
      private System.Windows.Forms.ColumnHeader columnIdLimitAircraft;
      internal System.Windows.Forms.ListView listViewIdLimit;
      private System.Windows.Forms.ColumnHeader columnIdLimitValue;
      internal System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem copyDefaultProfileMappingToolStripMenuItem;
      private System.Windows.Forms.Button buttonCopyMappingToCurrentAircraft;
      private System.Windows.Forms.Label labelMappingCurrentAircraft;
      public System.Windows.Forms.TextBox textBoxMappingCurrentAircraft;
   }
}

