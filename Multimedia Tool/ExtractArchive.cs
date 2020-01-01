using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multimedia_Tool
{
    public partial class ExtractArchive : Form
    {
        private string inputFile { get; set; }
        private string outputDirectory { get; set; }
        public ExtractArchive()
        {
            InitializeComponent();
        }

        private void btnExtractArchive_Click(object sender, EventArgs e)
        {
            inputFile = textBoxSelectedZip.Text;
            outputDirectory = textBoxExtractionDir.Text;

            try
            {

                var directory = new DirectoryInfo(outputDirectory);

                if (!directory.Exists)
                {
                    directory.Create();
                    ZipFileasync(inputFile, outputDirectory);
                }

                else
                {
                    ZipFileasync(inputFile, outputDirectory);
                    System.Windows.MessageBox.Show("File Extracted!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSelectZip_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileBrowserDialog = new OpenFileDialog();

            fileBrowserDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;

            fileBrowserDialog.ShowDialog();

            textBoxSelectedZip.Text = fileBrowserDialog.FileName;
        }

        private void btnSelectExtrDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;

            folderBrowserDialog.ShowDialog();

            textBoxExtractionDir.Text = folderBrowserDialog.SelectedPath;
        }
        public async Task ZipFileasync(string inputFileName, string outputDirectory)//TODO if file exists try overwrite
        {
            await Task.Run(() => {
                System.IO.Compression.ZipFile.ExtractToDirectory(inputFileName, outputDirectory);
                System.Windows.MessageBox.Show("Archive Extracted!");

            });

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
