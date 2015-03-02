using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void DataSelect_Click(object sender, EventArgs e)
        {
            SelectFileDialog.ShowDialog();
            if (SelectFileDialog.FileNames.Length != 0)
            {
                SplitterMain.setFileNames(SelectFileDialog.FileNames);
                OutputSelect.Enabled = true;
            }
        }

        private void OutputSelect_Click(object sender, EventArgs e)
        {
            SelectFolderDialog.ShowDialog();
            if (SelectFolderDialog.SelectedPath != "")
            {
                SplitterMain.setOutputFolder(SelectFolderDialog.SelectedPath);
                Begin.Enabled = true;
            }
        }

        private void Begin_Click(object sender, EventArgs e)
        {
            Begin.Enabled = false;
            OutputSelect.Enabled = false;
            DataSelect.Enabled = false;
            Debug debug = new Debug();
            debug.Show();
            SplitterMain.start();
            MessageBox.Show("Split complete!");
            DataSelect.Enabled = true;
        }
    }
}
