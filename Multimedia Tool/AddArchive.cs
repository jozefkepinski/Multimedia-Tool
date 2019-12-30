

using System;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Multimedia_Tool
{
    public partial class AddArchive : Form
    {
        private string archievePathString { get; set; }
        private string destinationArchievePathString { get; set; }
        private string compressionLevelString { get; set; }
        private CompressionLevel compressionLevel { get; set; }

        FileInfo fileInfo;
        private string inputDirectory;


        public AddArchive()
        {
            InitializeComponent();
            InitializeCbCompresiontype();
        }

        private void btnSelectDirectoryPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog SearchDirSourceFolderBrowser = new FolderBrowserDialog();
            SearchDirSourceFolderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;
            SearchDirSourceFolderBrowser.ShowDialog();
            textBox1.Text = SearchDirSourceFolderBrowser.SelectedPath;
        }

        private void btnSelectOutputZip_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FileDirFolderBrowser = new FolderBrowserDialog();
            FileDirFolderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;
            FileDirFolderBrowser.ShowDialog();
            fileInfo = new FileInfo(textBox1.Text);
            string fileName = fileInfo.Name;

            textBox2.Text = FileDirFolderBrowser.SelectedPath + fileName + ".zip";
            destinationArchievePathString = textBox2.Text;
        }

        private void btnCreateArchive_Click(object sender, EventArgs e)
        {
            destinationArchievePathString = textBox2.Text;
            compressionLevelString = CBCompresiontype.Text;
            CompressionLevelFunc(compressionLevelString);
            try
            {
                if (!Ionic.Zip.ZipFile.IsZipFile(destinationArchievePathString))
                {
                    inputDirectory = textBox1.Text;
                    ZipFileasync(inputDirectory, destinationArchievePathString, compressionLevel);

                }
                else
                {
                    MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Do you want rewrite existing file?", "Rewrite Confirmation", MessageBoxButton.YesNoCancel);

                    switch (messageBoxResult)
                    {
                        //case MessageBoxResult.None:
                        //    break;
                        //case MessageBoxResult.OK:
                        //    break;
                        case MessageBoxResult.Cancel:
                            break;
                        case MessageBoxResult.Yes:
                            Ionic.Zip.ZipFile.FixZipDirectory(destinationArchievePathString);
                            System.Windows.MessageBox.Show("File rewrited!");
                            break;
                        case MessageBoxResult.No:
                            break;
                        default:
                            break;
                    }


                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task ZipFileasync(string inputFolder, string outputFile, CompressionLevel compressionLevel)
        {
            await Task.Run(() => {
                ZipFile.CreateFromDirectory(inputFolder, outputFile, compressionLevel, true);
                System.Windows.MessageBox.Show("Archive Created!");
                


            });

        }
        private void InitializeCbCompresiontype()
        {
            string[] compressionLevel = new string[] { "Optimal", "Fastest", "NoCompression" };
            foreach (var item in compressionLevel)
            {
                CBCompresiontype.Items.Add(item);
            }

        }
        public CompressionLevel CompressionLevelFunc(string compLevel)
        {
            switch (compLevel)
            {
                case "Optimal":
                    compressionLevel = CompressionLevel.Optimal;
                    break;

                case "Fastest":
                    compressionLevel = CompressionLevel.Fastest;
                    break;
                case "NoCompression":
                    compressionLevel = CompressionLevel.NoCompression;
                    break;

            }
            return compressionLevel;
        }

        private void CBCompresiontype_SelectedValueChanged(object sender, EventArgs e)
        {
            //CBCompresiontype.Items.Refresh();
            compressionLevelString = CBCompresiontype.Text;
        }
    }
}
