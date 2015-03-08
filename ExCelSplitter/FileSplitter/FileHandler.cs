using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel; 

namespace WindowsFormsApplication1.FileSplitter
{
    class FileHandler
    {
        private string filename;

        public FileHandler(string _filename)
        {
            filename = _filename;
        }

        public void process()
        {
            Debug.Log("Beginning to process" + filename);
            Excel.Application app = new Excel.Application();
            Excel.Workbook workbook = app.Workbooks.Open(filename);

            foreach (Excel.Worksheet sheet in workbook.Worksheets)
            {
                TabHandler th = new TabHandler(sheet);
                th.processTab();
            }
            Debug.Log("Completed processing" + filename);
            workbook.Close(false);
            app.Quit();
        }
    }
}
