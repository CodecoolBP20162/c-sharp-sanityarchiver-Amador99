using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace SanityArchiver
{
    public partial class FileManager : Form
    {
        public FileManager()
        {
            InitializeComponent();
            string defaultPath = @"C:\";
            fileBrowser.Url = new Uri(defaultPath);
            dirComboBox.SelectedIndex = 0;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            if (fileBrowser.CanGoBack)
            {
                fileBrowser.GoBack();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (fileBrowser.CanGoForward)
            {
                fileBrowser.GoForward();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string path = (string)dirComboBox.SelectedItem;
            fileBrowser.Url = new Uri(path);
        }

        private void fileBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string path = fileBrowser.Url.ToString();
            pathBox.Text = path.Substring(8).Replace("/","\\");
        }

        private void compressBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "All files |*.*", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string fileName = ofd.FileName;
                    FileInfo file = new FileInfo(fileName);
                    bool success = Archiver.Compress(file);
                    if (success)
                    {
                        MessageBox.Show("Compression successful", "File Browser", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Compression unsuccessful", "File Browser", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }

        private void extractBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "All files |*.*", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string fileName = ofd.FileName;
                    FileInfo file = new FileInfo(fileName);
                    bool success = Archiver.Extract(file);
                    if (success)
                    {
                        MessageBox.Show("Extraction successful", "File Browser", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Extraction unsuccessful", "File Browser", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }
        
        private void refresBtn_Click(object sender, EventArgs e)
        {
            fileBrowser.Refresh();
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            string filename = ofd.FileName;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            
            string destination = sfd.FileName;

            Encryption.EncryptFile(filename, destination);
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            string filename = ofd.FileName;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();

            string destination = sfd.FileName;

            Encryption.DecryptFile(filename, destination);
        }
    }

    }

