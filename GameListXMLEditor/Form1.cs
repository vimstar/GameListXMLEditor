using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using NLog;

namespace GameListXMLEditor
{
    public partial class Form1 : Form
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public Form1()
        {
            InitializeComponent();
            this.Text = $"Recalbox GameList XML Editor v{Assembly.GetEntryAssembly().GetName().Version.Major}.{Assembly.GetEntryAssembly().GetName().Version.Minor}";
            tbPath.Text = Directory.GetCurrentDirectory() + @"\gamelist.xml";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Browse Template Files",
                CheckFileExists = true,
                CheckPathExists = true,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = openFileDialog1.FileName;
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            // This will process the file based on the selected options
            StartFeedback(0);
            try
            {
                string imagesPath = null;
                if (chkCopyImages.Checked || chkValidate.Checked)
                {
                    imagesPath = tbImagePath.Text;
                }

                if (chkNameFile.Checked)
                {
                    ImageElementUpdater.FixNames(tbPath.Text);
                }
                else if (chkValidate.Checked)
                {
                    ImageElementUpdater.ValidateImages(tbPath.Text, imagesPath);
                }
                else if (chkCopyImages.Checked)
                {
                    ImageElementUpdater.ProcessXML(tbPath.Text, tbExt.Text, imagesPath);
                }
                else
                {
                    MessageBox.Show("No valid option was selected.", "Invalid Option", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                StartFeedback(1);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Unknown error occured!");
                StartFeedback(2);
            }
        }

        private void chkCopyImages_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCopyImages.Checked)
            {
                chkValidate.Checked = false;
                chkNameFile.Checked = false;
            }

            ImageCheckChange();
        }

        private void chkValidate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkValidate.Checked)
            {
                chkCopyImages.Checked = false;
                chkNameFile.Checked = false;
            }

            ImageCheckChange();
        }

        private void chkNameFile_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNameFile.Checked)
            {
                chkCopyImages.Checked = false;
                chkValidate.Checked = false;
            }

            ImageCheckChange();
        }

        private void ImageCheckChange()
        {
            if (chkCopyImages.Checked || chkValidate.Checked)
            {
                tbImagePath.Enabled = true;
                tbExt.Enabled = true;
            }
            else
            {
                tbImagePath.Enabled = false;
                tbExt.Enabled = false;
            }
        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog
            {
                Description = "Images Path"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbImagePath.Text = dlg.SelectedPath;
            }
        }

        public void StartFeedback(int status)
        {

            switch (status)
            {
                case 0:
                    lblPublish.ForeColor = Color.Black;
                    lblPublish.Text = "Process Running...";
                    lblPublish.Visible = true;
                    btnProcess.Enabled = false;
                    break;
                case 1:
                    lblPublish.ForeColor = Color.DarkGreen;
                    lblPublish.Text = "Process Complete";
                    lblPublish.Visible = true;
                    btnProcess.Enabled = true;
                    break;
                default:
                    lblPublish.ForeColor = Color.DarkRed;
                    lblPublish.Text = "Process Error";
                    lblPublish.Visible = true;
                    btnProcess.Enabled = true;
                    break;
            }
        }

    }
}
