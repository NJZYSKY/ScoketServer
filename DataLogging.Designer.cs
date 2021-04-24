namespace ScoketServer
{
    partial class DataLogging
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
            this.buttonOpen = new System.Windows.Forms.Button();
            this.textBox_DataSaveName = new System.Windows.Forms.TextBox();
            this.checkBox_Path = new System.Windows.Forms.CheckBox();
            this.checkBox_Name = new System.Windows.Forms.CheckBox();
            this.button_Name = new System.Windows.Forms.Button();
            this.textBox_DataSavePath = new System.Windows.Forms.TextBox();
            this.button_Path = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(89, 66);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(56, 23);
            this.buttonOpen.TabIndex = 32;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            // 
            // textBox_DataSaveName
            // 
            this.textBox_DataSaveName.Location = new System.Drawing.Point(89, 39);
            this.textBox_DataSaveName.Name = "textBox_DataSaveName";
            this.textBox_DataSaveName.ReadOnly = true;
            this.textBox_DataSaveName.Size = new System.Drawing.Size(367, 21);
            this.textBox_DataSaveName.TabIndex = 28;
            // 
            // checkBox_Path
            // 
            this.checkBox_Path.AutoSize = true;
            this.checkBox_Path.Location = new System.Drawing.Point(10, 114);
            this.checkBox_Path.Name = "checkBox_Path";
            this.checkBox_Path.Size = new System.Drawing.Size(48, 16);
            this.checkBox_Path.TabIndex = 12;
            this.checkBox_Path.Text = "Path";
            this.checkBox_Path.UseVisualStyleBackColor = true;
            // 
            // checkBox_Name
            // 
            this.checkBox_Name.AutoSize = true;
            this.checkBox_Name.Location = new System.Drawing.Point(10, 41);
            this.checkBox_Name.Name = "checkBox_Name";
            this.checkBox_Name.Size = new System.Drawing.Size(48, 16);
            this.checkBox_Name.TabIndex = 13;
            this.checkBox_Name.Text = "Name";
            this.checkBox_Name.UseVisualStyleBackColor = true;
            // 
            // button_Name
            // 
            this.button_Name.Enabled = false;
            this.button_Name.Location = new System.Drawing.Point(10, 66);
            this.button_Name.Name = "button_Name";
            this.button_Name.Size = new System.Drawing.Size(73, 23);
            this.button_Name.TabIndex = 31;
            this.button_Name.Text = "默认Name";
            this.button_Name.UseVisualStyleBackColor = true;
            // 
            // textBox_DataSavePath
            // 
            this.textBox_DataSavePath.Location = new System.Drawing.Point(89, 112);
            this.textBox_DataSavePath.Multiline = true;
            this.textBox_DataSavePath.Name = "textBox_DataSavePath";
            this.textBox_DataSavePath.ReadOnly = true;
            this.textBox_DataSavePath.Size = new System.Drawing.Size(367, 51);
            this.textBox_DataSavePath.TabIndex = 26;
            // 
            // button_Path
            // 
            this.button_Path.Enabled = false;
            this.button_Path.Location = new System.Drawing.Point(10, 136);
            this.button_Path.Name = "button_Path";
            this.button_Path.Size = new System.Drawing.Size(73, 23);
            this.button_Path.TabIndex = 30;
            this.button_Path.Text = "默认Path";
            this.button_Path.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DataLogging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 464);
            this.Controls.Add(this.checkBox_Name);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.textBox_DataSaveName);
            this.Controls.Add(this.button_Name);
            this.Controls.Add(this.textBox_DataSavePath);
            this.Controls.Add(this.checkBox_Path);
            this.Controls.Add(this.button_Path);
            this.Name = "DataLogging";
            this.Text = "DataLogging";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.TextBox textBox_DataSaveName;
        private System.Windows.Forms.CheckBox checkBox_Path;
        private System.Windows.Forms.CheckBox checkBox_Name;
        private System.Windows.Forms.Button button_Name;
        private System.Windows.Forms.TextBox textBox_DataSavePath;
        private System.Windows.Forms.Button button_Path;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}