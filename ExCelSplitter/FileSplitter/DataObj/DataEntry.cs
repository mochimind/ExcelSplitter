using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelSplitter.FileSplitter
{
    class DataEntry
    {
        public string entryData;
        public int row;
        public int col;

        public DataEntry(int _row, int _col, string _entryData)
        {
            row = _row;
            col = _col;
            entryData = _entryData;
        }
    }
}
