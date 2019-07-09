using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace FileNameProcessor
{
    public partial class FormMain : Form
    {
        private string _sourceDirectory = string.Empty;
        private string _destinationDirectory = string.Empty;
        public int StartingValue { get; set; }

        public FormMain()
        {
            InitializeComponent();
            StartingValue = 100;
        }
        private void ChooseFolder()
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tbxSelectedFolder.Text = folderBrowserDialog.SelectedPath;
                _sourceDirectory = folderBrowserDialog.SelectedPath;
                _destinationDirectory = _sourceDirectory + @"\converted";
            }
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }

        private void btnProcessFiles_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxSelectedFolder.Text))
            {
                return;
            }

            try
            {
                Directory.CreateDirectory(_destinationDirectory);

                var files = Directory.EnumerateFiles(_sourceDirectory, "*.wav");
                foreach (string file in files)
                {

                    string fileName = Path.GetFileName(file);
                    string newFileName = StartingValue.ToString() + "_" + fileName;
                    // Will not overwrite if the destination file already exists.
                    File.Copy(Path.Combine(_sourceDirectory, fileName), Path.Combine(_destinationDirectory, newFileName));
                    Debug.Print(newFileName);
                    StartingValue += 1;

                    if (StartingValue > StartingValue + 400) { break; };              
                }

            }
            // Catch exception if the file was already copied.
            catch (IOException copyError)
            {
                MessageBox.Show(copyError.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            var ctrl = (NumericUpDown)sender;
            StartingValue = (int)ctrl.Value;
        }
    }
}
