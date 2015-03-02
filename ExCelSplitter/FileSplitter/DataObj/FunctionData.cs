using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.FileSplitter
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
            entries.Add(_row);
        }
    }
}
