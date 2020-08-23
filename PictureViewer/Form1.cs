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

        private void Backward_Click(object sender, EventArgs e)
        {
            int k = FilesList.SelectedIndex;
            if (k == -1)
            {
                MessageBox.Show("Вы не выбрали текущее изображение!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (k == 0)
                {
                    k = FilesList.Items.Count - 1;
                }
                else
                {
                    k--;
                }
                FilesList.SelectedIndex = k;
            }
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            int k = FilesList.SelectedIndex;
            if (k == -1)
            {
                MessageBox.Show("Вы не выбрали текущее изображение!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (k == FilesList.Items.Count - 1)
                {
                    k = 0;
                }
                else
                {
                    k++;
                }
                FilesList.SelectedIndex = k;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (FilesList.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали текущее изображение!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Progress.Value = FilesList.SelectedIndex + 1;
                Progress.Maximum = FilesList.Items.Count;
                timer1.Interval = Convert.ToInt32(Delay.Value) * 1000;
                timer1.Start();
                Start.Enabled = false;
                Stop.Enabled = true;
                Reset.Enabled = false;
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Start.Enabled = true;
            Stop.Enabled = false;
            Reset.Enabled = true;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Start.Enabled = true;
            Stop.Enabled = false;
            Reset.Enabled = false;
            FilesList.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            if (FilesList.SelectedIndex == FilesList.Items.Count - 1)
            {
                FilesList.SelectedIndex = 0;
                Progress.Value = 0;
            }
            else
            {               
                FilesList.SelectedIndex++;
                Progress.Value++;
            }
        }
    }
}
