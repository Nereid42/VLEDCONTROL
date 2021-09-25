namespace VLEDCONTROL
{
   partial class EditProfileEventDialog
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
         this.label1 = new System.Windows.Forms.Label();
         this.textBoxEventId = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.comboBoxEventNames = new System.Windows.Forms.ComboBox();
         this.comboBoxAircraft = new System.Windows.Forms.ComboBox();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.comboBoxPrimaryCondition = new System.Windows.Forms.ComboBox();
         this.textBoxPrimaryValue = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.textBoxDeviceId = new System.Windows.Forms.TextBox();
         this.groupBoxEvent = new System.Windows.Forms.GroupBox();
         this.groupBoxCondition = new System.Windows.Forms.GroupBox();
         this.buttonSetSecondaryValue1 = new System.Windows.Forms.Button();
         this.buttonSetSecondaryValue0 = new System.Windows.Forms.Button();
         this.buttonSetPrimaryValue1 = new System.Windows.Forms.Button();
         this.buttonSetPrimaryValue0 = new System.Windows.Forms.Button();
         this.comboBoxSecondaryCondition = new System.Windows.Forms.ComboBox();
         this.textBoxSecondaryValue = new System.Windows.Forms.TextBox();
         this.groupBoxLed = new System.Windows.Forms.GroupBox();
         this.comboBoxDeviceName = new System.Windows.Forms.ComboBox();
         this.comboBoxLed = new System.Windows.Forms.ComboBox();
         this.buttonColor2 = new System.Windows.Forms.Button();
         this.buttonColor1 = new System.Windows.Forms.Button();
         this.buttonOk = new System.Windows.Forms.Button();
         this.buttonCancel = new System.Windows.Forms.Button();
         this.groupBoxTestLed = new System.Windows.Forms.GroupBox();
         this.buttonSetDefault = new System.Windows.Forms.Button();
         this.buttonTestColor2 = new System.Windows.Forms.Button();
         this.buttonTestColor1 = new System.Windows.Forms.Button();
         this.groupBoxDescription = new System.Windows.Forms.GroupBox();
         this.textBoxDescription = new System.Windows.Forms.TextBox();
         this.groupBoxEvent.SuspendLayout();
         this.groupBoxCondition.SuspendLayout();
         this.groupBoxLed.SuspendLayout();
         this.groupBoxTestLed.SuspendLayout();
         this.groupBoxDescription.SuspendLayout();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(39, 30);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(21, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "ID:";
         // 
         // textBoxEventId
         // 
         this.textBoxEventId.Location = new System.Drawing.Point(66, 27);
         this.textBoxEventId.Name = "textBoxEventId";
         this.textBoxEventId.Size = new System.Drawing.Size(48, 20);
         this.textBoxEventId.TabIndex = 1;
         this.textBoxEventId.TextChanged += new System.EventHandler(this.textBoxEventId_TextChanged);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(17, 61);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(43, 13);
         this.label2.TabIndex = 2;
         this.label2.Text = "Aircraft:";
         // 
         // comboBoxEventNames
         // 
         this.comboBoxEventNames.FormattingEnabled = true;
         this.comboBoxEventNames.Location = new System.Drawing.Point(120, 27);
         this.comboBoxEventNames.Name = "comboBoxEventNames";
         this.comboBoxEventNames.Size = new System.Drawing.Size(195, 21);
         this.comboBoxEventNames.TabIndex = 3;
         this.comboBoxEventNames.SelectedIndexChanged += new System.EventHandler(this.comboBoxEventNames_SelectedIndexChanged);
         // 
         // comboBoxAircraft
         // 
         this.comboBoxAircraft.FormattingEnabled = true;
         this.comboBoxAircraft.Location = new System.Drawing.Point(66, 58);
         this.comboBoxAircraft.Name = "comboBoxAircraft";
         this.comboBoxAircraft.Size = new System.Drawing.Size(249, 21);
         this.comboBoxAircraft.TabIndex = 4;
         this.comboBoxAircraft.SelectedIndexChanged += new System.EventHandler(this.comboBoxAircraft_SelectedIndexChanged);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(6, 32);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(91, 13);
         this.label3.TabIndex = 5;
         this.label3.Text = "Primary Condition:";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(6, 60);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(108, 13);
         this.label4.TabIndex = 6;
         this.label4.Text = "Secondary Condition:";
         // 
         // comboBoxPrimaryCondition
         // 
         this.comboBoxPrimaryCondition.FormattingEnabled = true;
         this.comboBoxPrimaryCondition.Items.AddRange(new object[] {
            "S",
            "=",
            "!=",
            ">",
            "<",
            ">=",
            "<="});
         this.comboBoxPrimaryCondition.Location = new System.Drawing.Point(121, 29);
         this.comboBoxPrimaryCondition.Name = "comboBoxPrimaryCondition";
         this.comboBoxPrimaryCondition.Size = new System.Drawing.Size(52, 21);
         this.comboBoxPrimaryCondition.TabIndex = 7;
         // 
         // textBoxPrimaryValue
         // 
         this.textBoxPrimaryValue.Location = new System.Drawing.Point(179, 30);
         this.textBoxPrimaryValue.Name = "textBoxPrimaryValue";
         this.textBoxPrimaryValue.Size = new System.Drawing.Size(76, 20);
         this.textBoxPrimaryValue.TabIndex = 8;
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
         // textBoxDeviceId
         // 
         this.textBoxDeviceId.Location = new System.Drawing.Point(56, 25);
         this.textBoxDeviceId.Name = "textBoxDeviceId";
         this.textBoxDeviceId.Size = new System.Drawing.Size(41, 20);
         this.textBoxDeviceId.TabIndex = 10;
         this.textBoxDeviceId.TextChanged += new System.EventHandler(this.textBoxDeviceId_TextChanged);
         // 
         // groupBoxEvent
         // 
         this.groupBoxEvent.Controls.Add(this.comboBoxAircraft);
         this.groupBoxEvent.Controls.Add(this.label1);
         this.groupBoxEvent.Controls.Add(this.textBoxEventId);
         this.groupBoxEvent.Controls.Add(this.label2);
         this.groupBoxEvent.Controls.Add(this.comboBoxEventNames);
         this.groupBoxEvent.Location = new System.Drawing.Point(16, 12);
         this.groupBoxEvent.Name = "groupBoxEvent";
         this.groupBoxEvent.Size = new System.Drawing.Size(328, 102);
         this.groupBoxEvent.TabIndex = 11;
         this.groupBoxEvent.TabStop = false;
         this.groupBoxEvent.Text = "Event";
         this.groupBoxEvent.Enter += new System.EventHandler(this.GroupBoxEvent_Enter);
         // 
         // groupBoxCondition
         // 
         this.groupBoxCondition.Controls.Add(this.buttonSetSecondaryValue1);
         this.groupBoxCondition.Controls.Add(this.buttonSetSecondaryValue0);
         this.groupBoxCondition.Controls.Add(this.buttonSetPrimaryValue1);
         this.groupBoxCondition.Controls.Add(this.buttonSetPrimaryValue0);
         this.groupBoxCondition.Controls.Add(this.comboBoxSecondaryCondition);
         this.groupBoxCondition.Controls.Add(this.textBoxSecondaryValue);
         this.groupBoxCondition.Controls.Add(this.label3);
         this.groupBoxCondition.Controls.Add(this.label4);
         this.groupBoxCondition.Controls.Add(this.comboBoxPrimaryCondition);
         this.groupBoxCondition.Controls.Add(this.textBoxPrimaryValue);
         this.groupBoxCondition.Location = new System.Drawing.Point(16, 120);
         this.groupBoxCondition.Name = "groupBoxCondition";
         this.groupBoxCondition.Size = new System.Drawing.Size(328, 95);
         this.groupBoxCondition.TabIndex = 12;
         this.groupBoxCondition.TabStop = false;
         this.groupBoxCondition.Text = "Condition";
         // 
         // buttonSetSecondaryValue1
         // 
         this.buttonSetSecondaryValue1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.buttonSetSecondaryValue1.Location = new System.Drawing.Point(291, 57);
         this.buttonSetSecondaryValue1.Name = "buttonSetSecondaryValue1";
         this.buttonSetSecondaryValue1.Size = new System.Drawing.Size(26, 20);
         this.buttonSetSecondaryValue1.TabIndex = 19;
         this.buttonSetSecondaryValue1.Text = "1";
         this.buttonSetSecondaryValue1.UseVisualStyleBackColor = true;
         this.buttonSetSecondaryValue1.Click += new System.EventHandler(this.buttonSetSecondaryValue1_Click);
         // 
         // buttonSetSecondaryValue0
         // 
         this.buttonSetSecondaryValue0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.buttonSetSecondaryValue0.Location = new System.Drawing.Point(261, 57);
         this.buttonSetSecondaryValue0.Name = "buttonSetSecondaryValue0";
         this.buttonSetSecondaryValue0.Size = new System.Drawing.Size(26, 20);
         this.buttonSetSecondaryValue0.TabIndex = 18;
         this.buttonSetSecondaryValue0.Text = "0";
         this.buttonSetSecondaryValue0.UseVisualStyleBackColor = true;
         this.buttonSetSecondaryValue0.Click += new System.EventHandler(this.buttonSetSecondaryValue0_Click);
         // 
         // buttonSetPrimaryValue1
         // 
         this.buttonSetPrimaryValue1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.buttonSetPrimaryValue1.Location = new System.Drawing.Point(291, 30);
         this.buttonSetPrimaryValue1.Name = "buttonSetPrimaryValue1";
         this.buttonSetPrimaryValue1.Size = new System.Drawing.Size(26, 20);
         this.buttonSetPrimaryValue1.TabIndex = 17;
         this.buttonSetPrimaryValue1.Text = "1";
         this.buttonSetPrimaryValue1.UseVisualStyleBackColor = true;
         this.buttonSetPrimaryValue1.Click += new System.EventHandler(this.buttonSetPrimaryValue1_Click);
         // 
         // buttonSetPrimaryValue0
         // 
         this.buttonSetPrimaryValue0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.buttonSetPrimaryValue0.Location = new System.Drawing.Point(261, 30);
         this.buttonSetPrimaryValue0.Name = "buttonSetPrimaryValue0";
         this.buttonSetPrimaryValue0.Size = new System.Drawing.Size(26, 20);
         this.buttonSetPrimaryValue0.TabIndex = 16;
         this.buttonSetPrimaryValue0.Text = "0";
         this.buttonSetPrimaryValue0.UseVisualStyleBackColor = true;
         this.buttonSetPrimaryValue0.Click += new System.EventHandler(this.buttonSetPrimaryValue0_Click);
         // 
         // comboBoxSecondaryCondition
         // 
         this.comboBoxSecondaryCondition.FormattingEnabled = true;
         this.comboBoxSecondaryCondition.Items.AddRange(new object[] {
            "-",
            "=",
            "!=",
            ">",
            "<",
            ">=",
            "<="});
         this.comboBoxSecondaryCondition.Location = new System.Drawing.Point(121, 56);
         this.comboBoxSecondaryCondition.Name = "comboBoxSecondaryCondition";
         this.comboBoxSecondaryCondition.Size = new System.Drawing.Size(52, 21);
         this.comboBoxSecondaryCondition.TabIndex = 9;
         // 
         // textBoxSecondaryValue
         // 
         this.textBoxSecondaryValue.Location = new System.Drawing.Point(179, 57);
         this.textBoxSecondaryValue.Name = "textBoxSecondaryValue";
         this.textBoxSecondaryValue.Size = new System.Drawing.Size(76, 20);
         this.textBoxSecondaryValue.TabIndex = 10;
         // 
         // groupBoxLed
         // 
         this.groupBoxLed.Controls.Add(this.comboBoxDeviceName);
         this.groupBoxLed.Controls.Add(this.comboBoxLed);
         this.groupBoxLed.Controls.Add(this.textBoxDeviceId);
         this.groupBoxLed.Controls.Add(this.buttonColor2);
         this.groupBoxLed.Controls.Add(this.buttonColor1);
         this.groupBoxLed.Controls.Add(this.label5);
         this.groupBoxLed.Location = new System.Drawing.Point(350, 120);
         this.groupBoxLed.Name = "groupBoxLed";
         this.groupBoxLed.Size = new System.Drawing.Size(303, 95);
         this.groupBoxLed.TabIndex = 13;
         this.groupBoxLed.TabStop = false;
         this.groupBoxLed.Text = "LED";
         // 
         // comboBoxDeviceName
         // 
         this.comboBoxDeviceName.FormattingEnabled = true;
         this.comboBoxDeviceName.Location = new System.Drawing.Point(103, 25);
         this.comboBoxDeviceName.Name = "comboBoxDeviceName";
         this.comboBoxDeviceName.Size = new System.Drawing.Size(194, 21);
         this.comboBoxDeviceName.TabIndex = 15;
         this.comboBoxDeviceName.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeviceName_SelectedIndexChanged);
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
         this.comboBoxLed.Location = new System.Drawing.Point(6, 60);
         this.comboBoxLed.Name = "comboBoxLed";
         this.comboBoxLed.Size = new System.Drawing.Size(157, 21);
         this.comboBoxLed.TabIndex = 14;
         this.comboBoxLed.SelectedIndexChanged += new System.EventHandler(this.comboBoxLed_SelectedIndexChanged);
         // 
         // buttonColor2
         // 
         this.buttonColor2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.buttonColor2.Location = new System.Drawing.Point(236, 60);
         this.buttonColor2.Name = "buttonColor2";
         this.buttonColor2.Size = new System.Drawing.Size(61, 21);
         this.buttonColor2.TabIndex = 13;
         this.buttonColor2.Text = "Color 2";
         this.buttonColor2.UseVisualStyleBackColor = true;
         this.buttonColor2.Click += new System.EventHandler(this.buttonColor2_Click);
         // 
         // buttonColor1
         // 
         this.buttonColor1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.buttonColor1.Location = new System.Drawing.Point(169, 60);
         this.buttonColor1.Name = "buttonColor1";
         this.buttonColor1.Size = new System.Drawing.Size(61, 21);
         this.buttonColor1.TabIndex = 12;
         this.buttonColor1.Text = "Color 1";
         this.buttonColor1.UseVisualStyleBackColor = true;
         this.buttonColor1.Click += new System.EventHandler(this.button1_Click);
         // 
         // buttonOk
         // 
         this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.buttonOk.Location = new System.Drawing.Point(497, 258);
         this.buttonOk.Name = "buttonOk";
         this.buttonOk.Size = new System.Drawing.Size(75, 23);
         this.buttonOk.TabIndex = 15;
         this.buttonOk.Text = "OK";
         this.buttonOk.UseVisualStyleBackColor = true;
         this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
         // 
         // buttonCancel
         // 
         this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.buttonCancel.Location = new System.Drawing.Point(578, 258);
         this.buttonCancel.Name = "buttonCancel";
         this.buttonCancel.Size = new System.Drawing.Size(75, 23);
         this.buttonCancel.TabIndex = 16;
         this.buttonCancel.Text = "Cancel";
         this.buttonCancel.UseVisualStyleBackColor = true;
         // 
         // groupBoxTestLed
         // 
         this.groupBoxTestLed.BackColor = System.Drawing.SystemColors.ControlLight;
         this.groupBoxTestLed.Controls.Add(this.buttonSetDefault);
         this.groupBoxTestLed.Controls.Add(this.buttonTestColor2);
         this.groupBoxTestLed.Controls.Add(this.buttonTestColor1);
         this.groupBoxTestLed.Location = new System.Drawing.Point(351, 13);
         this.groupBoxTestLed.Name = "groupBoxTestLed";
         this.groupBoxTestLed.Size = new System.Drawing.Size(302, 101);
         this.groupBoxTestLed.TabIndex = 17;
         this.groupBoxTestLed.TabStop = false;
         this.groupBoxTestLed.Text = "Test LED";
         this.groupBoxTestLed.Enter += new System.EventHandler(this.groupBoxTestLed_Enter);
         // 
         // buttonSetDefault
         // 
         this.buttonSetDefault.BackColor = System.Drawing.Color.Silver;
         this.buttonSetDefault.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.buttonSetDefault.Location = new System.Drawing.Point(170, 18);
         this.buttonSetDefault.Name = "buttonSetDefault";
         this.buttonSetDefault.Size = new System.Drawing.Size(123, 23);
         this.buttonSetDefault.TabIndex = 4;
         this.buttonSetDefault.Text = "Set Default";
         this.buttonSetDefault.UseVisualStyleBackColor = false;
         this.buttonSetDefault.Click += new System.EventHandler(this.buttonSetDefault_Click);
         // 
         // buttonTestColor2
         // 
         this.buttonTestColor2.BackColor = System.Drawing.SystemColors.AppWorkspace;
         this.buttonTestColor2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.buttonTestColor2.Location = new System.Drawing.Point(89, 18);
         this.buttonTestColor2.Name = "buttonTestColor2";
         this.buttonTestColor2.Size = new System.Drawing.Size(75, 23);
         this.buttonTestColor2.TabIndex = 1;
         this.buttonTestColor2.Text = "Test Color 2";
         this.buttonTestColor2.UseVisualStyleBackColor = false;
         this.buttonTestColor2.Click += new System.EventHandler(this.buttonTestColor2_Click);
         // 
         // buttonTestColor1
         // 
         this.buttonTestColor1.BackColor = System.Drawing.SystemColors.AppWorkspace;
         this.buttonTestColor1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.buttonTestColor1.Location = new System.Drawing.Point(8, 18);
         this.buttonTestColor1.Name = "buttonTestColor1";
         this.buttonTestColor1.Size = new System.Drawing.Size(75, 23);
         this.buttonTestColor1.TabIndex = 0;
         this.buttonTestColor1.Text = "Test Color 1";
         this.buttonTestColor1.UseVisualStyleBackColor = false;
         this.buttonTestColor1.Click += new System.EventHandler(this.buttonTestColor1_Click);
         // 
         // groupBoxDescription
         // 
         this.groupBoxDescription.Controls.Add(this.textBoxDescription);
         this.groupBoxDescription.Location = new System.Drawing.Point(16, 222);
         this.groupBoxDescription.Name = "groupBoxDescription";
         this.groupBoxDescription.Size = new System.Drawing.Size(328, 66);
         this.groupBoxDescription.TabIndex = 18;
         this.groupBoxDescription.TabStop = false;
         this.groupBoxDescription.Text = "Description";
         // 
         // textBoxDescription
         // 
         this.textBoxDescription.Location = new System.Drawing.Point(7, 19);
         this.textBoxDescription.Multiline = true;
         this.textBoxDescription.Name = "textBoxDescription";
         this.textBoxDescription.Size = new System.Drawing.Size(315, 37);
         this.textBoxDescription.TabIndex = 0;
         this.textBoxDescription.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
         // 
         // EditProfileEventDialog
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(669, 293);
         this.ControlBox = false;
         this.Controls.Add(this.groupBoxDescription);
         this.Controls.Add(this.groupBoxTestLed);
         this.Controls.Add(this.buttonCancel);
         this.Controls.Add(this.buttonOk);
         this.Controls.Add(this.groupBoxLed);
         this.Controls.Add(this.groupBoxCondition);
         this.Controls.Add(this.groupBoxEvent);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Name = "EditProfileEventDialog";
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Edit Profile Event";
         this.Load += new System.EventHandler(this.EditProfileEventDialog_Load);
         this.groupBoxEvent.ResumeLayout(false);
         this.groupBoxEvent.PerformLayout();
         this.groupBoxCondition.ResumeLayout(false);
         this.groupBoxCondition.PerformLayout();
         this.groupBoxLed.ResumeLayout(false);
         this.groupBoxLed.PerformLayout();
         this.groupBoxTestLed.ResumeLayout(false);
         this.groupBoxDescription.ResumeLayout(false);
         this.groupBoxDescription.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox textBoxEventId;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.ComboBox comboBoxEventNames;
      private System.Windows.Forms.ComboBox comboBoxAircraft;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.ComboBox comboBoxPrimaryCondition;
      private System.Windows.Forms.TextBox textBoxPrimaryValue;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.TextBox textBoxDeviceId;
      private System.Windows.Forms.GroupBox groupBoxEvent;
      private System.Windows.Forms.GroupBox groupBoxCondition;
      private System.Windows.Forms.ComboBox comboBoxSecondaryCondition;
      private System.Windows.Forms.TextBox textBoxSecondaryValue;
      private System.Windows.Forms.GroupBox groupBoxLed;
      private System.Windows.Forms.ComboBox comboBoxLed;
      private System.Windows.Forms.Button buttonColor2;
      private System.Windows.Forms.Button buttonColor1;
      private System.Windows.Forms.Button buttonOk;
      private System.Windows.Forms.Button buttonCancel;
      private System.Windows.Forms.ComboBox comboBoxDeviceName;
      private System.Windows.Forms.GroupBox groupBoxTestLed;
      private System.Windows.Forms.Button buttonTestColor2;
      private System.Windows.Forms.Button buttonTestColor1;
      private System.Windows.Forms.GroupBox groupBoxDescription;
      private System.Windows.Forms.TextBox textBoxDescription;
      private System.Windows.Forms.Button buttonSetDefault;
      private System.Windows.Forms.Button buttonSetSecondaryValue1;
      private System.Windows.Forms.Button buttonSetSecondaryValue0;
      private System.Windows.Forms.Button buttonSetPrimaryValue1;
      private System.Windows.Forms.Button buttonSetPrimaryValue0;
   }
}