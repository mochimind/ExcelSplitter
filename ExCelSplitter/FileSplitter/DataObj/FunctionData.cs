using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelSplitter.FileSplitter
{
    class FunctionData
    {
        public List<DataRow> entries;
        public string function;

        public FunctionData(string _function)
        {
            function = _function;
            entries = new List<DataRow>();
        }

        public void add(DataRow _row)
        {
            // check for duplicates
            foreach (DataRow token in entries)
            {
                if (token.data[0] == _row.data[0]) { return; }
            }
            entries.Add(_row);
        }
    }
}
