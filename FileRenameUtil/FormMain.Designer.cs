namespace FileNameProcessor
{
    partial class FormMain
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
      this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
      this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.tbxSelectedFolder = new System.Windows.Forms.TextBox();
      this.btnSelectFolder = new System.Windows.Forms.Button();
      this.lblSelectedFolder = new System.Windows.Forms.Label();
      this.btnProcessFiles = new System.Windows.Forms.Button();
      this.lblStartingValue = new System.Windows.Forms.Label();
      this.numericUpDown = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
      this.SuspendLayout();
      // 
      // openFileDialog
      // 
      this.openFileDialog.FileName = "openFileDialog1";
      // 
      // tbxSelectedFolder
      // 
      this.tbxSelectedFolder.Location = new System.Drawing.Point(194, 39);
      this.tbxSelectedFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tbxSelectedFolder.Name = "tbxSelectedFolder";
      this.tbxSelectedFolder.ReadOnly = true;
      this.tbxSelectedFolder.Size = new System.Drawing.Size(754, 31);
      this.tbxSelectedFolder.TabIndex = 0;
      // 
      // btnSelectFolder
      // 
      this.btnSelectFolder.Location = new System.Drawing.Point(958, 33);
      this.btnSelectFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnSelectFolder.Name = "btnSelectFolder";
      this.btnSelectFolder.Size = new System.Drawing.Size(58, 47);
      this.btnSelectFolder.TabIndex = 1;
      this.btnSelectFolder.Text = "...";
      this.btnSelectFolder.UseVisualStyleBackColor = true;
      this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
      // 
      // lblSelectedFolder
      // 
      this.lblSelectedFolder.AutoSize = true;
      this.lblSelectedFolder.Location = new System.Drawing.Point(18, 44);
      this.lblSelectedFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblSelectedFolder.Name = "lblSelectedFolder";
      this.lblSelectedFolder.Size = new System.Drawing.Size(169, 25);
      this.lblSelectedFolder.TabIndex = 2;
      this.lblSelectedFolder.Text = "Selected Folder:";
      // 
      // btnProcessFiles
      // 
      this.btnProcessFiles.Location = new System.Drawing.Point(866, 178);
      this.btnProcessFiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnProcessFiles.Name = "btnProcessFiles";
      this.btnProcessFiles.Size = new System.Drawing.Size(152, 44);
      this.btnProcessFiles.TabIndex = 3;
      this.btnProcessFiles.Text = "Process Files";
      this.btnProcessFiles.UseVisualStyleBackColor = true;
      this.btnProcessFiles.Click += new System.EventHandler(this.btnProcessFiles_Click);
      // 
      // lblStartingValue
      // 
      this.lblStartingValue.AutoSize = true;
      this.lblStartingValue.Location = new System.Drawing.Point(18, 103);
      this.lblStartingValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblStartingValue.Name = "lblStartingValue";
      this.lblStartingValue.Size = new System.Drawing.Size(147, 25);
      this.lblStartingValue.TabIndex = 4;
      this.lblStartingValue.Text = "StartingValue:";
      // 
      // numericUpDown
      // 
      this.numericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
      this.numericUpDown.Location = new System.Drawing.Point(194, 100);
      this.numericUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.numericUpDown.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
      this.numericUpDown.Name = "numericUpDown";
      this.numericUpDown.Size = new System.Drawing.Size(153, 31);
      this.numericUpDown.TabIndex = 5;
      this.numericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
      this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1059, 264);
      this.Controls.Add(this.numericUpDown);
      this.Controls.Add(this.lblStartingValue);
      this.Controls.Add(this.btnProcessFiles);
      this.Controls.Add(this.lblSelectedFolder);
      this.Controls.Add(this.btnSelectFolder);
      this.Controls.Add(this.tbxSelectedFolder);
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "FormMain";
      this.Text = "WavTrigger Filename Processor";
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox tbxSelectedFolder;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Label lblSelectedFolder;
        private System.Windows.Forms.Button btnProcessFiles;
        private System.Windows.Forms.Label lblStartingValue;
        private System.Windows.Forms.NumericUpDown numericUpDown;
    }
}

