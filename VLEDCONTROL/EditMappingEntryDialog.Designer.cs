namespace VLEDCONTROL
{
   partial class EditMappingEntryDialog
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
         this.button1 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.textBoxEventId = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.comboBoxAircraft = new System.Windows.Forms.ComboBox();
         this.labelAircraft = new System.Windows.Forms.Label();
         this.textBoxName = new System.Windows.Forms.TextBox();
         this.labelName = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // button1
         // 
         this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.button1.Location = new System.Drawing.Point(166, 134);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 0;
         this.button1.Text = "OK";
         this.button1.UseVisualStyleBackColor = true;
         // 
         // button2
         // 
         this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.button2.Location = new System.Drawing.Point(247, 134);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(75, 23);
         this.button2.TabIndex = 1;
         this.button2.Text = "Cancel";
         this.button2.UseVisualStyleBackColor = true;
         // 
         // textBoxEventId
         // 
         this.textBoxEventId.Location = new System.Drawing.Point(15, 37);
         this.textBoxEventId.Name = "textBoxEventId";
         this.textBoxEventId.Size = new System.Drawing.Size(68, 20);
         this.textBoxEventId.TabIndex = 2;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 22);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(21, 13);
         this.label1.TabIndex = 3;
         this.label1.Text = "ID:";
         // 
         // comboBoxAircraft
         // 
         this.comboBoxAircraft.FormattingEnabled = true;
         this.comboBoxAircraft.Location = new System.Drawing.Point(89, 37);
         this.comboBoxAircraft.Name = "comboBoxAircraft";
         this.comboBoxAircraft.Size = new System.Drawing.Size(233, 21);
         this.comboBoxAircraft.TabIndex = 4;
         // 
         // labelAircraft
         // 
         this.labelAircraft.AutoSize = true;
         this.labelAircraft.Location = new System.Drawing.Point(86, 21);
         this.labelAircraft.Name = "labelAircraft";
         this.labelAircraft.Size = new System.Drawing.Size(43, 13);
         this.labelAircraft.TabIndex = 5;
         this.labelAircraft.Text = "Aircraft:";
         // 
         // textBoxName
         // 
         this.textBoxName.Location = new System.Drawing.Point(15, 92);
         this.textBoxName.Name = "textBoxName";
         this.textBoxName.Size = new System.Drawing.Size(307, 20);
         this.textBoxName.TabIndex = 6;
         // 
         // labelName
         // 
         this.labelName.AutoSize = true;
         this.labelName.Location = new System.Drawing.Point(12, 76);
         this.labelName.Name = "labelName";
         this.labelName.Size = new System.Drawing.Size(38, 13);
         this.labelName.TabIndex = 7;
         this.labelName.Text = "Name:";
         // 
         // EditMappingEntryDialog
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(337, 177);
         this.Controls.Add(this.labelName);
         this.Controls.Add(this.textBoxName);
         this.Controls.Add(this.labelAircraft);
         this.Controls.Add(this.comboBoxAircraft);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.textBoxEventId);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.button1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Name = "EditMappingEntryDialog";
         this.ShowIcon = false;
         this.Text = "EditMappingEntryDialog";
         this.Load += new System.EventHandler(this.EditMappingEntryDialog_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.TextBox textBoxEventId;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.ComboBox comboBoxAircraft;
      private System.Windows.Forms.Label labelAircraft;
      private System.Windows.Forms.TextBox textBoxName;
      private System.Windows.Forms.Label labelName;
   }
}