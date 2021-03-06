﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelSplitter.FileSplitter
{
    class DataManager
    {
        public static List<FunctionData> functions = new List<FunctionData>();

        public static FunctionData GetFunctionData(string _fname)
        {
            foreach (FunctionData token in functions) {
                if (token.function.ToLower() == _fname.ToLower()) { return token; }
            }

            FunctionData newFunc = new FunctionData(_fname); 
            functions.Add(newFunc);
            return newFunc;
        }
    }
}
