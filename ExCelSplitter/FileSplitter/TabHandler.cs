using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelSplitter.FileSplitter
{
    class TabHandler
    {
        private Excel.Worksheet sheet;
        public readonly static string[] VALID_TABS = new string[] { "1. Legal Entity Related", "2. Communications & Change Mgt.", 
                                                                    "3. Order to Cash", "4. Procure to Pay", "5. Record to Report", 
                                                                    "6. Supply Continuity" };
        public readonly static int STARTING_ROW = 12;
        public readonly static int BLANK_ROWS_TILL_STOP = 2;

        public TabHandler(Excel.Worksheet _sheet)
        {
            sheet = _sheet;
        }

        public void processTab()
        {
            bool isValidTab = false;
            foreach (String validTab in VALID_TABS) {
                if (validTab == sheet.Name) { isValidTab = true; }
            }

            if (!isValidTab) {
                Debug.Log("Tab: " + sheet.Name + " is not one of the tabs we're looking for");
                return; 
            }

            Debug.Log("Processing tab: " + sheet.Name);
            int blankRowsSeen = 0;
            for (int i = STARTING_ROW; i < sheet.Rows.Count-1; i++ )
            {
                RowHandler rh = new RowHandler(sheet.Rows[i]);
                if (rh.isBlankRow())
                {
                    blankRowsSeen++;
                    if (blankRowsSeen >= BLANK_ROWS_TILL_STOP)
                    {
                        return;
                    }
                }
                else
                {
                    rh.handleRow();

                }
            }
            Debug.Log("Completed Processing: " + sheet.Name);
        }
    }
}
