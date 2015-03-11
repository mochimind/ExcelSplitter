using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelSplitter.FileSplitter
{
    class DataWriter
    {
        public readonly static string TEMPLATE_NAME = "template.xlsx";

        public readonly static int START_WRITE_ROW = TabHandler.STARTING_ROW;
        public readonly static int START_WRITE_COL = RowHandler.STARTING_COLUMN;
        public readonly static string TAB_NAME = "Status Items";

        private string path;
        private FunctionData data;

        public DataWriter(string outPath, FunctionData _data)
        {
            data = _data;
            path = outPath + "/" + data.function + ".xlsx";
            System.IO.File.Copy(TEMPLATE_NAME, path, true);


        }

        public void writeData()
        {
            Debug.Log("Beginning to write for function: " + data.function);
            Excel.Application app = new Excel.Application();
            Excel.Workbook outBook = app.Workbooks.Open(path);
            Excel.Worksheet sheet = outBook.Worksheets[TAB_NAME];
            //app.Visible = true;

            int writeRow = START_WRITE_ROW;
            Excel.Range copyRange = sheet.Cells[START_WRITE_ROW, START_WRITE_COL].EntireRow;

            // main write loop
            foreach (DataRow rowdata in data.entries)
            {
                // copy the number of rows we need
                Excel.Range pasteRange = sheet.Cells[writeRow + 1, START_WRITE_COL].EntireRow;
                pasteRange.Insert(Excel.XlInsertShiftDirection.xlShiftDown, copyRange);
                
                foreach (DataEntry entry in rowdata.data)
                {
                    // we need to take 1 off the column because we removed the function column
                    sheet.Cells[writeRow, entry.col-1].value = entry.entryData;
                }
                writeRow++;
            }
            sheet.Cells[writeRow, START_WRITE_COL].EntireRow.Delete(Excel.XlDeleteShiftDirection.xlShiftUp);
            sheet.Cells[writeRow, START_WRITE_COL].EntireRow.Delete(Excel.XlDeleteShiftDirection.xlShiftUp);
            

            Debug.Log("Finished writing function: " + data.function);
            outBook.Close(true);
            app.Quit();
        }
    }
}
