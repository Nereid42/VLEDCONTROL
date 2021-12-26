namespace VLEDCONTROL
{
   partial class InstallScriptsDialog
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
         this.buttonDcsRelease = new System.Windows.Forms.Button();
         this.buttonDcsOpenBeta = new System.Windows.Forms.Button();
         this.buttonChooseFolder = new System.Windows.Forms.Button();
         this.buttonSkip = new System.Windows.Forms.Button();
         this.labelExplanation = new System.Windows.Forms.Label();
         this.textBoxFirstInstallWarning = new System.Windows.Forms.TextBox();
         this.checkBoxDirectExport = new System.Windows.Forms.CheckBox();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(13, 13);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(395, 20);
         this.label1.TabIndex = 0;
         this.label1.Text = "Installation of LUA Scripts for Digital Combat Simulator";
         // 
         // buttonDcsRelease
         // 
         this.buttonDcsRelease.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.buttonDcsRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.buttonDcsRelease.ForeColor = System.Drawing.SystemColors.HotTrack;
         this.buttonDcsRelease.Location = new System.Drawing.Point(17, 54);
         this.buttonDcsRelease.Name = "buttonDcsRelease";
         this.buttonDcsRelease.Size = new System.Drawing.Size(184, 46);
         this.buttonDcsRelease.TabIndex = 1;
         this.buttonDcsRelease.Text = "DCS World Release";
         this.buttonDcsRelease.UseVisualStyleBackColor = true;
         this.buttonDcsRelease.Click += new System.EventHandler(this.buttonDcsRelease_Click);
         // 
         // buttonDcsOpenBeta
         // 
         this.buttonDcsOpenBeta.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.buttonDcsOpenBeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.buttonDcsOpenBeta.ForeColor = System.Drawing.Color.Firebrick;
         this.buttonDcsOpenBeta.Location = new System.Drawing.Point(207, 54);
         this.buttonDcsOpenBeta.Name = "buttonDcsOpenBeta";
         this.buttonDcsOpenBeta.Size = new System.Drawing.Size(184, 46);
         this.buttonDcsOpenBeta.TabIndex = 2;
         this.buttonDcsOpenBeta.Text = "DCS World Open Beta";
         this.buttonDcsOpenBeta.UseVisualStyleBackColor = true;
         this.buttonDcsOpenBeta.Click += new System.EventHandler(this.buttonDcsOpenBeta_Click);
         // 
         // buttonChooseFolder
         // 
         this.buttonChooseFolder.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.buttonChooseFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.buttonChooseFolder.Location = new System.Drawing.Point(397, 54);
         this.buttonChooseFolder.Name = "buttonChooseFolder";
         this.buttonChooseFolder.Size = new System.Drawing.Size(184, 46);
         this.buttonChooseFolder.TabIndex = 3;
         this.buttonChooseFolder.Text = "Choose Folder...";
         this.buttonChooseFolder.UseVisualStyleBackColor = true;
         this.buttonChooseFolder.Click += new System.EventHandler(this.buttonChooseFolder_Click);
         // 
         // buttonSkip
         // 
         this.buttonSkip.DialogResult = System.Windows.Forms.DialogResult.Ignore;
         this.buttonSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.buttonSkip.ForeColor = System.Drawing.SystemColors.MenuHighlight;
         this.buttonSkip.Location = new System.Drawing.Point(587, 54);
         this.buttonSkip.Name = "buttonSkip";
         this.buttonSkip.Size = new System.Drawing.Size(184, 46);
         this.buttonSkip.TabIndex = 4;
         this.buttonSkip.Text = "Skip";
         this.buttonSkip.UseVisualStyleBackColor = true;
         // 
         // labelExplanation
         // 
         this.labelExplanation.AutoSize = true;
         this.labelExplanation.Location = new System.Drawing.Point(17, 120);
         this.labelExplanation.Name = "labelExplanation";
         this.labelExplanation.Size = new System.Drawing.Size(350, 13);
         this.labelExplanation.TabIndex = 5;
         this.labelExplanation.Text = "This will install all necessary scripts in your local DCS configuration folder.";
         // 
         // textBoxFirstInstallWarning
         // 
         this.textBoxFirstInstallWarning.BackColor = System.Drawing.SystemColors.Control;
         this.textBoxFirstInstallWarning.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.textBoxFirstInstallWarning.Cursor = System.Windows.Forms.Cursors.No;
         this.textBoxFirstInstallWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.textBoxFirstInstallWarning.ForeColor = System.Drawing.Color.Red;
         this.textBoxFirstInstallWarning.Location = new System.Drawing.Point(20, 184);
         this.textBoxFirstInstallWarning.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
         this.textBoxFirstInstallWarning.Multiline = true;
         this.textBoxFirstInstallWarning.Name = "textBoxFirstInstallWarning";
         this.textBoxFirstInstallWarning.ReadOnly = true;
         this.textBoxFirstInstallWarning.Size = new System.Drawing.Size(748, 38);
         this.textBoxFirstInstallWarning.TabIndex = 7;
         this.textBoxFirstInstallWarning.TabStop = false;
         this.textBoxFirstInstallWarning.Text = "This is the first execution of VLEDCONTROL. If you skip this installation, VLEDCO" +
    "NTROL will not work unless you configure the DCS export scripts yourself later.\r" +
    "\n";
         this.textBoxFirstInstallWarning.Visible = false;
         // 
         // checkBoxDirectExport
         // 
         this.checkBoxDirectExport.AutoSize = true;
         this.checkBoxDirectExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.checkBoxDirectExport.ForeColor = System.Drawing.SystemColors.Highlight;
         this.checkBoxDirectExport.Location = new System.Drawing.Point(20, 150);
         this.checkBoxDirectExport.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
         this.checkBoxDirectExport.Name = "checkBoxDirectExport";
         this.checkBoxDirectExport.Size = new System.Drawing.Size(564, 17);
         this.checkBoxDirectExport.TabIndex = 8;
         this.checkBoxDirectExport.Text = "Use multiplayer support (this may not work with other plugins or render other plu" +
    "gins unusable!)";
         this.checkBoxDirectExport.UseVisualStyleBackColor = true;
         this.checkBoxDirectExport.CheckedChanged += new System.EventHandler(this.checkBoxDirectExport_CheckedChanged);
         // 
         // InstallScriptsDialog
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(788, 224);
         this.ControlBox = false;
         this.Controls.Add(this.checkBoxDirectExport);
         this.Controls.Add(this.textBoxFirstInstallWarning);
         this.Controls.Add(this.labelExplanation);
         this.Controls.Add(this.buttonSkip);
         this.Controls.Add(this.buttonChooseFolder);
         this.Controls.Add(this.buttonDcsOpenBeta);
         this.Controls.Add(this.buttonDcsRelease);
         this.Controls.Add(this.label1);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "InstallScriptsDialog";
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "VLEDCONTROL - Install LUA Scripts";
         this.TopMost = true;
         this.Load += new System.EventHandler(this.InstallScriptsDialog_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button buttonDcsRelease;
      private System.Windows.Forms.Button buttonDcsOpenBeta;
      private System.Windows.Forms.Button buttonChooseFolder;
      private System.Windows.Forms.Button buttonSkip;
      private System.Windows.Forms.Label labelExplanation;
      internal System.Windows.Forms.TextBox textBoxFirstInstallWarning;
      private System.Windows.Forms.CheckBox checkBoxDirectExport;
   }
}