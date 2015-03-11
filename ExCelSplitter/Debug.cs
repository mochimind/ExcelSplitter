using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelSplitter
{
    public partial class Debug : Form
    {
        private static Debug instance;

        public Debug()
        {
            InitializeComponent();
            instance = this;
        }

        public static void Log(string msg)
        {
            instance.LogBox.AppendText(msg + "\r\n");
        }
    }
}
