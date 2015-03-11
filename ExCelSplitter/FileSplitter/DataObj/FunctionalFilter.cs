using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelSplitter.FileSplitter.DataObj
{
    class FunctionalFilter
    {
        // this class takes several similar function names and maps them to a single one
        // note, the first name in the FUNCTION_MAPS array row will be the one all the other items map to
        private readonly static string[][] FUNCTION_MAPS = new string[][] { 
                        new string[] {"Finance-Tax-Treasury", "Finance", "Tax", "Treasury" }, 
                        new string[] {"Change Management and Communications", "Change Management", "Communications" }};

        public static string ProcessFunctionalName(string rawName)
        {
            for (int i = 0; i < FUNCTION_MAPS.Length; i++)
            {
                for (int j = 0; j < FUNCTION_MAPS[i].Length; j++)
                {
                    if (FUNCTION_MAPS[i][j].Trim() == rawName.Trim())
                    {
                        return FUNCTION_MAPS[i][0];
                    }
                }
            }
            return rawName;
        }
    }
}
