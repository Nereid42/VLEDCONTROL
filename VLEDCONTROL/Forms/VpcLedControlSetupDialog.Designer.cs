namespace VLEDCONTROL
{
   partial class VpcLedControlSetupDialog
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
         this.textBoxFirstInstallWarning = new System.Windows.Forms.TextBox();
         this.buttonAutomatic = new System.Windows.Forms.Button();
         this.buttonSkip = new System.Windows.Forms.Button();
         this.buttonChooseFolder = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // textBoxFirstInstallWarning
         // 
         this.textBoxFirstInstallWarning.BackColor = System.Drawing.SystemColors.Control;
         this.textBoxFirstInstallWarning.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.textBoxFirstInstallWarning.Cursor = System.Windows.Forms.Cursors.No;
         this.textBoxFirstInstallWarning.Enabled = false;
         this.textBoxFirstInstallWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.textBoxFirstInstallWarning.ForeColor = System.Drawing.Color.Red;
         this.textBoxFirstInstallWarning.Location = new System.Drawing.Point(12, 83);
         this.textBoxFirstInstallWarning.Multiline = true;
         this.textBoxFirstInstallWarning.Name = "textBoxFirstInstallWarning";
         this.textBoxFirstInstallWarning.Size = new System.Drawing.Size(564, 57);
         this.textBoxFirstInstallWarning.TabIndex = 8;
         this.textBoxFirstInstallWarning.Text = "This is the first execution of VLEDCONTROL. Please search for the file VPC_LED_Co" +
    "ntrol.exe on your computer. Without it, VLEDCONTROL will not work.\r\n";
         // 
         // buttonAutomatic
         // 
         this.buttonAutomatic.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.buttonAutomatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.buttonAutomatic.ForeColor = System.Drawing.Color.Red;
         this.buttonAutomatic.Location = new System.Drawing.Point(12, 12);
         this.buttonAutomatic.Name = "buttonAutomatic";
         this.buttonAutomatic.Size = new System.Drawing.Size(184, 46);
         this.buttonAutomatic.TabIndex = 9;
         this.buttonAutomatic.Text = "Automatically";
         this.buttonAutomatic.UseVisualStyleBackColor = true;
         this.buttonAutomatic.Click += new System.EventHandler(this.buttonAutomatic_Click);
         // 
         // buttonSkip
         // 
         this.buttonSkip.DialogResult = System.Windows.Forms.DialogResult.Ignore;
         this.buttonSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.buttonSkip.ForeColor = System.Drawing.SystemColors.MenuHighlight;
         this.buttonSkip.Location = new System.Drawing.Point(392, 12);
         this.buttonSkip.Name = "buttonSkip";
         this.buttonSkip.Size = new System.Drawing.Size(184, 46);
         this.buttonSkip.TabIndex = 10;
         this.buttonSkip.Text = "Skip";
         this.buttonSkip.UseVisualStyleBackColor = true;
         // 
         // buttonChooseFolder
         // 
         this.buttonChooseFolder.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.buttonChooseFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.buttonChooseFolder.Location = new System.Drawing.Point(202, 12);
         this.buttonChooseFolder.Name = "buttonChooseFolder";
         this.buttonChooseFolder.Size = new System.Drawing.Size(184, 46);
         this.buttonChooseFolder.TabIndex = 11;
         this.buttonChooseFolder.Text = "Choose Folder...";
         this.buttonChooseFolder.UseVisualStyleBackColor = true;
         this.buttonChooseFolder.Click += new System.EventHandler(this.buttonChooseFolder_Click);
         // 
         // VpcLedControlSetupDialog
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(596, 142);
         this.ControlBox = false;
         this.Controls.Add(this.buttonChooseFolder);
         this.Controls.Add(this.buttonSkip);
         this.Controls.Add(this.buttonAutomatic);
         this.Controls.Add(this.textBoxFirstInstallWarning);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "VpcLedControlSetupDialog";
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Search for VPC_LED_CONTROL";
         this.Load += new System.EventHandler(this.VpcLedControlSetupDialog_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      internal System.Windows.Forms.TextBox textBoxFirstInstallWarning;
      private System.Windows.Forms.Button buttonAutomatic;
      private System.Windows.Forms.Button buttonSkip;
      private System.Windows.Forms.Button buttonChooseFolder;
   }
}