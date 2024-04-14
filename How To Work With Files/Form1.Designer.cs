namespace How_To_Work_With_Files
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOpenFile = new Button();
            txtDisplayFilePath = new TextBox();
            txtDisplayFile = new TextBox();
            btnSaveFile = new Button();
            openFileDialog1 = new OpenFileDialog();
            txtFileName = new TextBox();
            txtCreate = new TextBox();
            btnCreate = new Button();
            RbtnFile = new RadioButton();
            RbtnDirectory = new RadioButton();
            folderBrowserDialog1 = new FolderBrowserDialog();
            btnSelect = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(87, 64);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(94, 29);
            btnOpenFile.TabIndex = 0;
            btnOpenFile.Text = "Open";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // txtDisplayFilePath
            // 
            txtDisplayFilePath.Location = new Point(243, 66);
            txtDisplayFilePath.Name = "txtDisplayFilePath";
            txtDisplayFilePath.Size = new Size(462, 27);
            txtDisplayFilePath.TabIndex = 1;
            // 
            // txtDisplayFile
            // 
            txtDisplayFile.Location = new Point(243, 132);
            txtDisplayFile.Multiline = true;
            txtDisplayFile.Name = "txtDisplayFile";
            txtDisplayFile.Size = new Size(462, 106);
            txtDisplayFile.TabIndex = 2;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Location = new Point(87, 99);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(94, 29);
            btnSaveFile.TabIndex = 3;
            btnSaveFile.Text = "Save";
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(243, 99);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(462, 27);
            txtFileName.TabIndex = 1;
            // 
            // txtCreate
            // 
            txtCreate.Location = new Point(243, 244);
            txtCreate.Name = "txtCreate";
            txtCreate.Size = new Size(462, 27);
            txtCreate.TabIndex = 4;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(87, 242);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // RbtnFile
            // 
            RbtnFile.AutoSize = true;
            RbtnFile.Checked = true;
            RbtnFile.Location = new Point(416, 298);
            RbtnFile.Name = "RbtnFile";
            RbtnFile.Size = new Size(53, 24);
            RbtnFile.TabIndex = 6;
            RbtnFile.TabStop = true;
            RbtnFile.Text = "File";
            RbtnFile.UseVisualStyleBackColor = true;
            // 
            // RbtnDirectory
            // 
            RbtnDirectory.AutoSize = true;
            RbtnDirectory.Location = new Point(416, 328);
            RbtnDirectory.Name = "RbtnDirectory";
            RbtnDirectory.Size = new Size(91, 24);
            RbtnDirectory.TabIndex = 6;
            RbtnDirectory.Text = "Directory";
            RbtnDirectory.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(87, 381);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(163, 29);
            btnSelect.TabIndex = 7;
            btnSelect.Text = "Select Your Folder";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(555, 277);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.Size = new Size(241, 164);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(btnSelect);
            Controls.Add(RbtnDirectory);
            Controls.Add(RbtnFile);
            Controls.Add(btnCreate);
            Controls.Add(txtCreate);
            Controls.Add(btnSaveFile);
            Controls.Add(txtDisplayFile);
            Controls.Add(txtFileName);
            Controls.Add(txtDisplayFilePath);
            Controls.Add(btnOpenFile);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpenFile;
        private TextBox txtDisplayFilePath;
        private TextBox txtDisplayFile;
        private Button btnSaveFile;
        private OpenFileDialog openFileDialog1;
        private TextBox txtFileName;
        private TextBox txtCreate;
        private Button btnCreate;
        private RadioButton RbtnFile;
        private RadioButton RbtnDirectory;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btnSelect;
        private ListBox listBox1;
    }
}
