using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApplication1.FileSplitter
{
    class RowHandler
    {
        public readonly static int STARTING_COLUMN = 2;
        public readonly static int BLANK_COLS_TILL_STOP = 2;
        public readonly static char[] delimiter = new char[] {',' };

        private Excel.Range data;

        private List<string> functions;

        public RowHandler(Excel.Range _data)
        {
            data = _data;

            if (data.Cells[1, STARTING_COLUMN].value != null)
            {
                functions = new List<string>();
                string[] fsplit = ((string)data.Cells[1, STARTING_COLUMN].value).Split(delimiter);
                foreach (string token in fsplit)
                {
                    functions.Add(token.Trim());
                }
            }
        }
        public bool isBlankRow()
        {
            if (functions == null || functions[0].Length == 0) { return true; }
            return false;
        }

        public void handleRow()
        {
            if (isBlankRow()) { return; }
            DataRow dr = new DataRow();

            int blankColsSeen = 0;
            int curCol = STARTING_COLUMN + 1;
            for (int i = STARTING_COLUMN + 1; i < data.Columns.Count-1; i++) 
            {
                if (data.Cells[1, curCol].value == null || data.Cells[1, curCol].value.Trim().Length == 0)
                {
                    blankColsSeen++;
                    if (blankColsSeen >= BLANK_COLS_TILL_STOP)
                    {
                        break;
                    }

                }
                // here we want to preserve the table structure so keep the blank columns
                dr.addEntry(data.Cells[1, curCol]);
                curCol++;
            }

            foreach (string function in functions)
            {
                DataManager.GetFunctionData(function).add(dr);
            }
        }
    }
}
