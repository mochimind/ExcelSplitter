using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApplication1.FileSplitter
{
    class DataRow
    {
        public List<DataEntry> data;

        public DataRow()
        {
            data = new List<DataEntry>();
        }

        public void addEntry(Excel.Range _range)
        {
            data.Add(new DataEntry(_range.Row, _range.Column, _range.Cells[1,1].value));
        }
    }
}
