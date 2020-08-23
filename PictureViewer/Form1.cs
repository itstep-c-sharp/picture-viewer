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

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        List<string> FileNames;
        List<string> FilePathes;

        public Form1()
        {
            InitializeComponent();
            FileNames = new List<string>();
            FilePathes = new List<string>();
        }

        private void OpenItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo di = new DirectoryInfo(fbd.SelectedPath);
                FileInfo[] jpg_files = di.GetFiles("*.jpg");
                FileInfo[] png_files = di.GetFiles("*.png");
                FileInfo[] gif_files = di.GetFiles("*.gif");
                FilesList.Items.Clear();
                FilePathes.Clear();

                if (jpg_files.Length > 0)
                {
                    foreach (FileInfo fi in jpg_files)
                    {
                        FilesList.Items.Add(fi.Name);
                        FilePathes.Add(fi.FullName);
                    }
                }

                if (png_files.Length > 0)
                {
                    foreach (FileInfo fi in png_files)
                    {
                        FilesList.Items.Add(fi.Name);
                        FilePathes.Add(fi.FullName);
                    }
                }

                if (gif_files.Length > 0)
                {
                    foreach (FileInfo fi in gif_files)
                    {
                        FilesList.Items.Add(fi.Name);
                        FilePathes.Add(fi.FullName);
                    }
                }
            }
        }

        private void CloseItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitItem_Click(object sender, EventArgs e)
        {

        }

        private void FilesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int k = FilesList.SelectedIndex;
            ViewBox.Image = Image.FromFile(FilePathes[k]);
        }
    }
}
