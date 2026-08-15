using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyFirstWindowsApp
{
    public partial class AddApplicationForm : Form
    {
        public string ApplicationName { get; private set; } = "";
        public string ExePath { get; private set; } = "";
        public AddApplicationForm()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    exePathTextBox.Text = dialog.FileName;
                }
            }
        }

        private void addAppButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(appNameTextBox.Text))
            {
                MessageBox.Show("Please enter an application name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(exePathTextBox.Text))
            {
                MessageBox.Show("Please select an executable.");
                return;
            }

            ApplicationName = appNameTextBox.Text;
            ExePath = exePathTextBox.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
