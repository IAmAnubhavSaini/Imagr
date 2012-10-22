using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Anubhav.ImagrLib;

namespace Anubhav.ImagrDesk
{
    public partial class Home : Form
    {
        private const string multipleFiles = "multiple files?";
        private const string multipleFolders = "multiple folders?";


        public Home()
        {
            InitializeComponent();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            /* here I wanted to select multiple folders */
            //if (IsFileDialogFilesRadio.Checked)
            //{
            //    FileMultiplicityCheck.Text = multipleFiles;
            //}
            //if (IsFileDialogFoldersRadio.Checked)
            //{
            //    FileMultiplicityCheck.Text = multipleFolders;
            //    OpenFile.
            //}

            if (FileMultiplicityCheck.Checked)
            {
                OpenFile.Multiselect = true;
            }
            else
            {
                OpenFile.Multiselect = false;
            }
            //then it is only natural that we go ahead with showing dialog.
            OpenFile.ShowDialog();

            foreach (string name in OpenFile.FileNames)
            {
                SelectedFilesList.Items.Add(name);

            }

            int fileCount = SelectedFilesList.Items.Count;

            SelectedFilesList.Text = SelectedFilesList.Items[fileCount - 1].ToString();

            string item1 = " item ";
            string itemMany = " items ";

            string item = fileCount > 1 ? itemMany : item1;
            SelectedFileCountLabel.Text = fileCount.ToString() + item + "selected.";
            
            //actionable link start over show.
            StartOverFilesLink.Show();

        }

        private void StartOverFilesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectedFileCountLabel.Text = "";
            SelectedFilesList.Items.Clear();
            SelectedFilesList.Text = "";
        }

        private void Home_Load(object sender, EventArgs e)
        {
            StartOverFilesLink.Hide();
            IsFileDialogFoldersRadio.Hide();
            IsFileDialogFilesRadio.Hide();
        }
    }
}
