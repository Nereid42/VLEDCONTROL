namespace VLEDCONTROL
{
   partial class EditDeviceDialog
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
         this.labelDeviceName = new System.Windows.Forms.Label();
         this.textBoxDeviceName = new System.Windows.Forms.TextBox();
         this.labelUsbVid = new System.Windows.Forms.Label();
         this.textBoxUsbVid = new System.Windows.Forms.TextBox();
         this.labelUsbPid = new System.Windows.Forms.Label();
         this.textBoxUsbPid = new System.Windows.Forms.TextBox();
         this.labelId = new System.Windows.Forms.Label();
         this.textBoxId = new System.Windows.Forms.TextBox();
         this.buttonCancel = new System.Windows.Forms.Button();
         this.buttonOk = new System.Windows.Forms.Button();
         this.comboBoxDevice = new System.Windows.Forms.ComboBox();
         this.SuspendLayout();
         // 
         // labelDeviceName
         // 
         this.labelDeviceName.AutoSize = true;
         this.labelDeviceName.Location = new System.Drawing.Point(12, 60);
         this.labelDeviceName.Name = "labelDeviceName";
         this.labelDeviceName.Size = new System.Drawing.Size(75, 13);
         this.labelDeviceName.TabIndex = 0;
         this.labelDeviceName.Text = "Device Name:";
         // 
         // textBoxDeviceName
         // 
         this.textBoxDeviceName.Location = new System.Drawing.Point(94, 57);
         this.textBoxDeviceName.Name = "textBoxDeviceName";
         this.textBoxDeviceName.Size = new System.Drawing.Size(156, 20);
         this.textBoxDeviceName.TabIndex = 1;
         this.textBoxDeviceName.TextChanged += new System.EventHandler(this.textBoxDeviceName_TextChanged);
         // 
         // labelUsbVid
         // 
         this.labelUsbVid.AutoSize = true;
         this.labelUsbVid.Location = new System.Drawing.Point(13, 89);
         this.labelUsbVid.Name = "labelUsbVid";
         this.labelUsbVid.Size = new System.Drawing.Size(53, 13);
         this.labelUsbVid.TabIndex = 2;
         this.labelUsbVid.Text = "USB VID:";
         // 
         // textBoxUsbVid
         // 
         this.textBoxUsbVid.Location = new System.Drawing.Point(94, 86);
         this.textBoxUsbVid.Name = "textBoxUsbVid";
         this.textBoxUsbVid.Size = new System.Drawing.Size(75, 20);
         this.textBoxUsbVid.TabIndex = 3;
         // 
         // labelUsbPid
         // 
         this.labelUsbPid.AutoSize = true;
         this.labelUsbPid.Location = new System.Drawing.Point(13, 119);
         this.labelUsbPid.Name = "labelUsbPid";
         this.labelUsbPid.Size = new System.Drawing.Size(53, 13);
         this.labelUsbPid.TabIndex = 4;
         this.labelUsbPid.Text = "USB PID:";
         // 
         // textBoxUsbPid
         // 
         this.textBoxUsbPid.Location = new System.Drawing.Point(94, 112);
         this.textBoxUsbPid.Name = "textBoxUsbPid";
         this.textBoxUsbPid.Size = new System.Drawing.Size(75, 20);
         this.textBoxUsbPid.TabIndex = 5;
         // 
         // labelId
         // 
         this.labelId.AutoSize = true;
         this.labelId.Location = new System.Drawing.Point(13, 18);
         this.labelId.Name = "labelId";
         this.labelId.Size = new System.Drawing.Size(21, 13);
         this.labelId.TabIndex = 6;
         this.labelId.Text = "ID:";
         // 
         // textBoxId
         // 
         this.textBoxId.Location = new System.Drawing.Point(49, 15);
         this.textBoxId.Name = "textBoxId";
         this.textBoxId.Size = new System.Drawing.Size(38, 20);
         this.textBoxId.TabIndex = 7;
         this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
         // 
         // buttonCancel
         // 
         this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.buttonCancel.Location = new System.Drawing.Point(175, 156);
         this.buttonCancel.Name = "buttonCancel";
         this.buttonCancel.Size = new System.Drawing.Size(75, 23);
         this.buttonCancel.TabIndex = 8;
         this.buttonCancel.Text = "Cancel";
         this.buttonCancel.UseVisualStyleBackColor = true;
         // 
         // buttonOk
         // 
         this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.buttonOk.Location = new System.Drawing.Point(94, 156);
         this.buttonOk.Name = "buttonOk";
         this.buttonOk.Size = new System.Drawing.Size(75, 23);
         this.buttonOk.TabIndex = 9;
         this.buttonOk.Text = "Ok";
         this.buttonOk.UseVisualStyleBackColor = true;
         this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
         // 
         // comboBoxDevice
         // 
         this.comboBoxDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.comboBoxDevice.FormattingEnabled = true;
         this.comboBoxDevice.Items.AddRange(new object[] {
            "VPC Panel #1",
            "VPC Panel #2",
            "VPC SharKa Panel",
            "VPC Throttle MT-50",
            "VPC Stick WarBRD"});
         this.comboBoxDevice.Location = new System.Drawing.Point(129, 14);
         this.comboBoxDevice.Name = "comboBoxDevice";
         this.comboBoxDevice.Size = new System.Drawing.Size(121, 21);
         this.comboBoxDevice.TabIndex = 10;
         this.comboBoxDevice.SelectedIndexChanged += new System.EventHandler(this.comboBoxDevice_SelectedIndexChanged);
         // 
         // EditDeviceDialog
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(276, 189);
         this.ControlBox = false;
         this.Controls.Add(this.comboBoxDevice);
         this.Controls.Add(this.buttonOk);
         this.Controls.Add(this.buttonCancel);
         this.Controls.Add(this.textBoxId);
         this.Controls.Add(this.labelId);
         this.Controls.Add(this.textBoxUsbPid);
         this.Controls.Add(this.labelUsbPid);
         this.Controls.Add(this.textBoxUsbVid);
         this.Controls.Add(this.labelUsbVid);
         this.Controls.Add(this.textBoxDeviceName);
         this.Controls.Add(this.labelDeviceName);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Name = "EditDeviceDialog";
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.Text = "Edit Virpil Device";
         this.Load += new System.EventHandler(this.EditDeviceDialog_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label labelDeviceName;
      private System.Windows.Forms.TextBox textBoxDeviceName;
      private System.Windows.Forms.Label labelUsbVid;
      private System.Windows.Forms.TextBox textBoxUsbVid;
      private System.Windows.Forms.Label labelUsbPid;
      private System.Windows.Forms.TextBox textBoxUsbPid;
      private System.Windows.Forms.Label labelId;
      private System.Windows.Forms.TextBox textBoxId;
      private System.Windows.Forms.Button buttonCancel;
      private System.Windows.Forms.Button buttonOk;
      internal System.Windows.Forms.ComboBox comboBoxDevice;
   }
}