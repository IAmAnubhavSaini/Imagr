namespace Anubhav.ImagrDesk
{
    partial class Home
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
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.SelectedFilesList = new System.Windows.Forms.ComboBox();
            this.SelectedFileCountLabel = new System.Windows.Forms.Label();
            this.StartOverFilesLink = new System.Windows.Forms.LinkLabel();
            this.FileMultiplicityCheck = new System.Windows.Forms.CheckBox();
            this.IsFileDialogFilesRadio = new System.Windows.Forms.RadioButton();
            this.IsFileDialogFoldersRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "OpenFile";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(12, 33);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(75, 23);
            this.OpenFileButton.TabIndex = 0;
            this.OpenFileButton.Text = "File Input";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SelectedFilesList
            // 
            this.SelectedFilesList.FormattingEnabled = true;
            this.SelectedFilesList.Location = new System.Drawing.Point(93, 33);
            this.SelectedFilesList.Name = "SelectedFilesList";
            this.SelectedFilesList.Size = new System.Drawing.Size(530, 21);
            this.SelectedFilesList.TabIndex = 1;
            // 
            // SelectedFileCountLabel
            // 
            this.SelectedFileCountLabel.AutoSize = true;
            this.SelectedFileCountLabel.Location = new System.Drawing.Point(9, 9);
            this.SelectedFileCountLabel.Name = "SelectedFileCountLabel";
            this.SelectedFileCountLabel.Size = new System.Drawing.Size(0, 13);
            this.SelectedFileCountLabel.TabIndex = 2;
            // 
            // StartOverFilesLink
            // 
            this.StartOverFilesLink.AutoSize = true;
            this.StartOverFilesLink.Location = new System.Drawing.Point(568, 9);
            this.StartOverFilesLink.Name = "StartOverFilesLink";
            this.StartOverFilesLink.Size = new System.Drawing.Size(55, 13);
            this.StartOverFilesLink.TabIndex = 3;
            this.StartOverFilesLink.TabStop = true;
            this.StartOverFilesLink.Text = "Start Over";
            this.StartOverFilesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.StartOverFilesLink_LinkClicked);
            // 
            // FileMultiplicityCheck
            // 
            this.FileMultiplicityCheck.AutoSize = true;
            this.FileMultiplicityCheck.Location = new System.Drawing.Point(12, 60);
            this.FileMultiplicityCheck.Name = "FileMultiplicityCheck";
            this.FileMultiplicityCheck.Size = new System.Drawing.Size(88, 17);
            this.FileMultiplicityCheck.TabIndex = 4;
            this.FileMultiplicityCheck.Text = "multiple files?";
            this.FileMultiplicityCheck.UseVisualStyleBackColor = true;
            // 
            // IsFileDialogFilesRadio
            // 
            this.IsFileDialogFilesRadio.AutoSize = true;
            this.IsFileDialogFilesRadio.Location = new System.Drawing.Point(12, 303);
            this.IsFileDialogFilesRadio.Name = "IsFileDialogFilesRadio";
            this.IsFileDialogFilesRadio.Size = new System.Drawing.Size(52, 17);
            this.IsFileDialogFilesRadio.TabIndex = 5;
            this.IsFileDialogFilesRadio.TabStop = true;
            this.IsFileDialogFilesRadio.Text = "files ?";
            this.IsFileDialogFilesRadio.UseVisualStyleBackColor = true;
            // 
            // IsFileDialogFoldersRadio
            // 
            this.IsFileDialogFoldersRadio.AutoSize = true;
            this.IsFileDialogFoldersRadio.Location = new System.Drawing.Point(70, 303);
            this.IsFileDialogFoldersRadio.Name = "IsFileDialogFoldersRadio";
            this.IsFileDialogFoldersRadio.Size = new System.Drawing.Size(65, 17);
            this.IsFileDialogFoldersRadio.TabIndex = 7;
            this.IsFileDialogFoldersRadio.TabStop = true;
            this.IsFileDialogFoldersRadio.Text = "folders ?";
            this.IsFileDialogFoldersRadio.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 332);
            this.Controls.Add(this.IsFileDialogFoldersRadio);
            this.Controls.Add(this.IsFileDialogFilesRadio);
            this.Controls.Add(this.FileMultiplicityCheck);
            this.Controls.Add(this.StartOverFilesLink);
            this.Controls.Add(this.SelectedFileCountLabel);
            this.Controls.Add(this.SelectedFilesList);
            this.Controls.Add(this.OpenFileButton);
            this.Name = "Home";
            this.Text = "Imagr Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.ComboBox SelectedFilesList;
        private System.Windows.Forms.Label SelectedFileCountLabel;
        private System.Windows.Forms.LinkLabel StartOverFilesLink;
        private System.Windows.Forms.CheckBox FileMultiplicityCheck;
        private System.Windows.Forms.RadioButton IsFileDialogFilesRadio;
        private System.Windows.Forms.RadioButton IsFileDialogFoldersRadio;
    }
}

