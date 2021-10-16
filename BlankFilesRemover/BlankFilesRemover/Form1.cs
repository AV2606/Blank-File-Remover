using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BlankFilesRemover
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //pathLabel.Text = folderBrowserDialog1.SelectedPath;
        }

        private void pathBox_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data;

        }

        private void pathBox_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
        }

        private void pathBox_DoubleClick(object sender, EventArgs e)
        {
            this.folderDialog.ShowDialog(this);
            var path = this.folderDialog.SelectedPath;
            pathBox.Text = path;
            button1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderDialog.SelectedPath.Length < 1)
                return;
            Directory d = new Directory(folderDialog.SelectedPath);
            var files=Directory.FindEmptyFiles(d);
            if(files.Count==0)
            {
                MessageBox.Show(this, "There are no empty files in this folder.", "Confusion Occured", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;            
            }
            if(files.Count>25)
            {
                MessageBox.Show(this, "Cant delete more that 25 files in one run!", "Maximum capacity reached.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var r=MessageBox.Show(this, ToString(files.GetPaths()), "Files deleted!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (r != DialogResult.Cancel)
            {
                Directory.DeleteFiles(files);
            }
            else
            {
                MessageBox.Show(this, "Operation aborted!", "Cancelation!", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private static string ToString(string[] arr)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var item in arr)
            {
                builder.Append(item + "\n");
            }
            return builder.ToString();
        }

        private void pathBox_TextChanged(object sender, EventArgs e)
        {
            folderDialog.SelectedPath = pathBox.Text;
        }
    }
}
