using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.FileSplitter
{
    class DataManager
    {
        public static List<FunctionData> functions = new List<FunctionData>();

        public static FunctionData GetFunctionData(string _fname)
        {
            foreach (FunctionData token in functions) {
                if (token.function == _fname) { return token; }
            }

            FunctionData newFunc = new FunctionData(_fname); 
            functions.Add(newFunc);
            return newFunc;
        }
    }
}
