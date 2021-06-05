namespace VLEDCONTROL
{
   partial class QuickAddDialog
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
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
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickAddDialog));
         this.groupBoxEvent = new System.Windows.Forms.GroupBox();
         this.comboBoxAircraft = new System.Windows.Forms.ComboBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.comboBoxEventNames = new System.Windows.Forms.ComboBox();
         this.groupBoxTestLed = new System.Windows.Forms.GroupBox();
         this.buttonTestColorOff = new System.Windows.Forms.Button();
         this.buttonTestColorOn = new System.Windows.Forms.Button();
         this.groupBoxDescription = new System.Windows.Forms.GroupBox();
         this.textBoxDescription = new System.Windows.Forms.TextBox();
         this.groupBoxLed = new System.Windows.Forms.GroupBox();
         this.label3 = new System.Windows.Forms.Label();
         this.comboBoxDeviceName = new System.Windows.Forms.ComboBox();
         this.comboBoxLed = new System.Windows.Forms.ComboBox();
         this.label5 = new System.Windows.Forms.Label();
         this.buttonColorOn = new System.Windows.Forms.Button();
         this.buttonColorOff = new System.Windows.Forms.Button();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.label7 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.buttonCancel = new System.Windows.Forms.Button();
         this.buttonOk = new System.Windows.Forms.Button();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.tabControl1 = new System.Windows.Forms.TabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.tabPageDeviceCP2 = new System.Windows.Forms.TabPage();
         this.groupBoxEvent.SuspendLayout();
         this.groupBoxTestLed.SuspendLayout();
         this.groupBoxDescription.SuspendLayout();
         this.groupBoxLed.SuspendLayout();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.tabControl1.SuspendLayout();
         this.SuspendLayout();
         // 
         // groupBoxEvent
         // 
         this.groupBoxEvent.Controls.Add(this.comboBoxAircraft);
         this.groupBoxEvent.Controls.Add(this.label1);
         this.groupBoxEvent.Controls.Add(this.label2);
         this.groupBoxEvent.Controls.Add(this.comboBoxEventNames);
         this.groupBoxEvent.Location = new System.Drawing.Point(12, 12);
         this.groupBoxEvent.Name = "groupBoxEvent";
         this.groupBoxEvent.Size = new System.Drawing.Size(328, 102);
         this.groupBoxEvent.TabIndex = 12;
         this.groupBoxEvent.TabStop = false;
         this.groupBoxEvent.Text = "Event";
         // 
         // comboBoxAircraft
         // 
         this.comboBoxAircraft.FormattingEnabled = true;
         this.comboBoxAircraft.Location = new System.Drawing.Point(66, 19);
         this.comboBoxAircraft.Name = "comboBoxAircraft";
         this.comboBoxAircraft.Size = new System.Drawing.Size(249, 21);
         this.comboBoxAircraft.TabIndex = 4;
         this.comboBoxAircraft.SelectedIndexChanged += new System.EventHandler(this.comboBoxAircraft_SelectedIndexChanged);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(28, 61);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(21, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "ID:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(6, 22);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(43, 13);
         this.label2.TabIndex = 2;
         this.label2.Text = "Aircraft:";
         // 
         // comboBoxEventNames
         // 
         this.comboBoxEventNames.FormattingEnabled = true;
         this.comboBoxEventNames.Location = new System.Drawing.Point(66, 58);
         this.comboBoxEventNames.Name = "comboBoxEventNames";
         this.comboBoxEventNames.Size = new System.Drawing.Size(249, 21);
         this.comboBoxEventNames.TabIndex = 3;
         // 
         // groupBoxTestLed
         // 
         this.groupBoxTestLed.BackColor = System.Drawing.SystemColors.ControlLight;
         this.groupBoxTestLed.Controls.Add(this.buttonTestColorOff);
         this.groupBoxTestLed.Controls.Add(this.buttonTestColorOn);
         this.groupBoxTestLed.Location = new System.Drawing.Point(356, 269);
         this.groupBoxTestLed.Name = "groupBoxTestLed";
         this.groupBoxTestLed.Size = new System.Drawing.Size(207, 59);
         this.groupBoxTestLed.TabIndex = 18;
         this.groupBoxTestLed.TabStop = false;
         this.groupBoxTestLed.Text = "Test LED";
         // 
         // buttonTestColorOff
         // 
         this.buttonTestColorOff.BackColor = System.Drawing.SystemColors.AppWorkspace;
         this.buttonTestColorOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.buttonTestColorOff.Location = new System.Drawing.Point(117, 19);
         this.buttonTestColorOff.Name = "buttonTestColorOff";
         this.buttonTestColorOff.Size = new System.Drawing.Size(75, 23);
         this.buttonTestColorOff.TabIndex = 1;
         this.buttonTestColorOff.Text = "Test Off";
         this.buttonTestColorOff.UseVisualStyleBackColor = false;
         this.buttonTestColorOff.Click += new System.EventHandler(this.buttonTestColorOff_Click);
         // 
         // buttonTestColorOn
         // 
         this.buttonTestColorOn.BackColor = System.Drawing.SystemColors.AppWorkspace;
         this.buttonTestColorOn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.buttonTestColorOn.Location = new System.Drawing.Point(14, 19);
         this.buttonTestColorOn.Name = "buttonTestColorOn";
         this.buttonTestColorOn.Size = new System.Drawing.Size(75, 23);
         this.buttonTestColorOn.TabIndex = 0;
         this.buttonTestColorOn.Text = "Test On";
         this.buttonTestColorOn.UseVisualStyleBackColor = false;
         this.buttonTestColorOn.Click += new System.EventHandler(this.buttonTestColorOn_Click);
         // 
         // groupBoxDescription
         // 
         this.groupBoxDescription.Controls.Add(this.textBoxDescription);
         this.groupBoxDescription.Location = new System.Drawing.Point(12, 219);
         this.groupBoxDescription.Name = "groupBoxDescription";
         this.groupBoxDescription.Size = new System.Drawing.Size(328, 109);
         this.groupBoxDescription.TabIndex = 19;
         this.groupBoxDescription.TabStop = false;
         this.groupBoxDescription.Text = "Description";
         // 
         // textBoxDescription
         // 
         this.textBoxDescription.Location = new System.Drawing.Point(7, 19);
         this.textBoxDescription.Multiline = true;
         this.textBoxDescription.Name = "textBoxDescription";
         this.textBoxDescription.Size = new System.Drawing.Size(315, 84);
         this.textBoxDescription.TabIndex = 0;
         // 
         // groupBoxLed
         // 
         this.groupBoxLed.Controls.Add(this.label3);
         this.groupBoxLed.Controls.Add(this.comboBoxDeviceName);
         this.groupBoxLed.Controls.Add(this.comboBoxLed);
         this.groupBoxLed.Controls.Add(this.label5);
         this.groupBoxLed.Location = new System.Drawing.Point(12, 120);
         this.groupBoxLed.Name = "groupBoxLed";
         this.groupBoxLed.Size = new System.Drawing.Size(210, 93);
         this.groupBoxLed.TabIndex = 20;
         this.groupBoxLed.TabStop = false;
         this.groupBoxLed.Text = "LED";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(5, 55);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(31, 13);
         this.label3.TabIndex = 16;
         this.label3.Text = "LED:";
         this.label3.Click += new System.EventHandler(this.label3_Click);
         // 
         // comboBoxDeviceName
         // 
         this.comboBoxDeviceName.FormattingEnabled = true;
         this.comboBoxDeviceName.Location = new System.Drawing.Point(51, 25);
         this.comboBoxDeviceName.Name = "comboBoxDeviceName";
         this.comboBoxDeviceName.Size = new System.Drawing.Size(146, 21);
         this.comboBoxDeviceName.TabIndex = 15;
         // 
         // comboBoxLed
         // 
         this.comboBoxLed.FormattingEnabled = true;
         this.comboBoxLed.Items.AddRange(new object[] {
            "[00] Set default",
            "[01] Set Add-boards LED 01",
            "[02] Set Add-boards LED 02",
            "[03] Set Add-boards LED 03",
            "[04] Set Add-boards LED 04",
            "[05] Set On-board LED 01",
            "[06] Set On-board LED 02",
            "[07] Set On-board LED 03",
            "[08] Set On-board LED 04",
            "[09] Set On-board LED 05",
            "[10] Set On-board LED 06",
            "[11] Set On-board LED 07",
            "[12] Set On-board LED 08",
            "[13] Set On-board LED 09",
            "[14] Set On-board LED 10",
            "[15] Set On-board LED 11",
            "[16] Set On-board LED 12",
            "[17] Set On-board LED 13",
            "[18] Set On-board LED 14",
            "[19] Set On-board LED 15",
            "[20] Set On-board LED 16",
            "[21] Set On-board LED 17",
            "[22] Set On-board LED 18",
            "[23] Set On-board LED 19",
            "[24] Set On-board LED 20",
            "[25] Set Slave-board LED 01",
            "[26] Set Slave-board LED 02",
            "[27] Set Slave-board LED 03",
            "[28] Set Slave-board LED 04",
            "[29] Set Slave-board LED 05",
            "[30] Set Slave-board LED 06",
            "[31] Set Slave-board LED 07",
            "[32] Set Slave-board LED 08",
            "[33] Set Slave-board LED 09",
            "[34] Set Slave-board LED 10",
            "[35] Set Slave-board LED 11",
            "[36] Set Slave-board LED 12",
            "[37] Set Slave-board LED 13",
            "[38] Set Slave-board LED 14",
            "[39] Set Slave-board LED 15",
            "[40] Set Slave-board LED 16",
            "[41] Set Slave-board LED 17",
            "[42] Set Slave-board LED 18",
            "[43] Set Slave-board LED 19",
            "[44] Set Slave-board LED 20",
            ""});
         this.comboBoxLed.Location = new System.Drawing.Point(51, 52);
         this.comboBoxLed.Name = "comboBoxLed";
         this.comboBoxLed.Size = new System.Drawing.Size(146, 21);
         this.comboBoxLed.TabIndex = 14;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(6, 29);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(44, 13);
         this.label5.TabIndex = 9;
         this.label5.Text = "Device:";
         // 
         // buttonColorOn
         // 
         this.buttonColorOn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.buttonColorOn.Location = new System.Drawing.Point(38, 22);
         this.buttonColorOn.Name = "buttonColorOn";
         this.buttonColorOn.Size = new System.Drawing.Size(61, 21);
         this.buttonColorOn.TabIndex = 13;
         this.buttonColorOn.Text = "ON";
         this.buttonColorOn.UseVisualStyleBackColor = true;
         this.buttonColorOn.Click += new System.EventHandler(this.buttonColorOn_Click);
         // 
         // buttonColorOff
         // 
         this.buttonColorOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.buttonColorOff.Location = new System.Drawing.Point(38, 55);
         this.buttonColorOff.Name = "buttonColorOff";
         this.buttonColorOff.Size = new System.Drawing.Size(61, 21);
         this.buttonColorOff.TabIndex = 12;
         this.buttonColorOff.Text = "OFF";
         this.buttonColorOff.UseVisualStyleBackColor = true;
         this.buttonColorOff.Click += new System.EventHandler(this.buttonColorOff_Click);
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.label7);
         this.groupBox1.Controls.Add(this.label4);
         this.groupBox1.Controls.Add(this.buttonColorOn);
         this.groupBox1.Controls.Add(this.buttonColorOff);
         this.groupBox1.Location = new System.Drawing.Point(228, 120);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(112, 93);
         this.groupBox1.TabIndex = 21;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Color";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(14, 58);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(24, 13);
         this.label7.TabIndex = 18;
         this.label7.Text = "Off:";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(14, 26);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(24, 13);
         this.label4.TabIndex = 17;
         this.label4.Text = "On:";
         // 
         // buttonCancel
         // 
         this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.buttonCancel.Location = new System.Drawing.Point(492, 338);
         this.buttonCancel.Name = "buttonCancel";
         this.buttonCancel.Size = new System.Drawing.Size(75, 23);
         this.buttonCancel.TabIndex = 23;
         this.buttonCancel.Text = "Cancel";
         this.buttonCancel.UseVisualStyleBackColor = true;
         // 
         // buttonOk
         // 
         this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.buttonOk.Location = new System.Drawing.Point(411, 338);
         this.buttonOk.Name = "buttonOk";
         this.buttonOk.Size = new System.Drawing.Size(75, 23);
         this.buttonOk.TabIndex = 22;
         this.buttonOk.Text = "OK";
         this.buttonOk.UseVisualStyleBackColor = true;
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.tabControl1);
         this.groupBox2.Location = new System.Drawing.Point(356, 12);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(207, 251);
         this.groupBox2.TabIndex = 25;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Devcie";
         // 
         // tabControl1
         // 
         this.tabControl1.Controls.Add(this.tabPage1);
         this.tabControl1.Controls.Add(this.tabPageDeviceCP2);
         this.tabControl1.Location = new System.Drawing.Point(10, 19);
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedIndex = 0;
         this.tabControl1.Size = new System.Drawing.Size(182, 212);
         this.tabControl1.TabIndex = 0;
         // 
         // tabPage1
         // 
         this.tabPage1.Location = new System.Drawing.Point(4, 22);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(174, 186);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "T50CM3";
         this.tabPage1.UseVisualStyleBackColor = true;
         this.tabPage1.Click += new System.EventHandler(this.tabPageT50CM3_Click);
         // 
         // tabPageDeviceCP2
         // 
         this.tabPageDeviceCP2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageDeviceCP2.BackgroundImage")));
         this.tabPageDeviceCP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.tabPageDeviceCP2.Location = new System.Drawing.Point(4, 22);
         this.tabPageDeviceCP2.Name = "tabPageDeviceCP2";
         this.tabPageDeviceCP2.Padding = new System.Windows.Forms.Padding(3);
         this.tabPageDeviceCP2.Size = new System.Drawing.Size(174, 186);
         this.tabPageDeviceCP2.TabIndex = 1;
         this.tabPageDeviceCP2.Text = "Control Panel #2";
         this.tabPageDeviceCP2.UseVisualStyleBackColor = true;
         this.tabPageDeviceCP2.Click += new System.EventHandler(this.tabPageDeviceCP2_Click);
         // 
         // QuickAddDialog
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(579, 369);
         this.ControlBox = false;
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.buttonCancel);
         this.Controls.Add(this.buttonOk);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.groupBoxLed);
         this.Controls.Add(this.groupBoxDescription);
         this.Controls.Add(this.groupBoxTestLed);
         this.Controls.Add(this.groupBoxEvent);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Name = "QuickAddDialog";
         this.Text = "Add Profile Event";
         this.TopMost = true;
         this.Load += new System.EventHandler(this.QickAddDialog_Load);
         this.groupBoxEvent.ResumeLayout(false);
         this.groupBoxEvent.PerformLayout();
         this.groupBoxTestLed.ResumeLayout(false);
         this.groupBoxDescription.ResumeLayout(false);
         this.groupBoxDescription.PerformLayout();
         this.groupBoxLed.ResumeLayout(false);
         this.groupBoxLed.PerformLayout();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.tabControl1.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBoxEvent;
      private System.Windows.Forms.ComboBox comboBoxAircraft;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.ComboBox comboBoxEventNames;
      private System.Windows.Forms.GroupBox groupBoxTestLed;
      private System.Windows.Forms.Button buttonTestColorOff;
      private System.Windows.Forms.Button buttonTestColorOn;
      private System.Windows.Forms.GroupBox groupBoxDescription;
      private System.Windows.Forms.TextBox textBoxDescription;
      private System.Windows.Forms.GroupBox groupBoxLed;
      private System.Windows.Forms.ComboBox comboBoxDeviceName;
      private System.Windows.Forms.ComboBox comboBoxLed;
      private System.Windows.Forms.Button buttonColorOn;
      private System.Windows.Forms.Button buttonColorOff;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Button buttonCancel;
      private System.Windows.Forms.Button buttonOk;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.TabControl tabControl1;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.TabPage tabPageDeviceCP2;
   }
}