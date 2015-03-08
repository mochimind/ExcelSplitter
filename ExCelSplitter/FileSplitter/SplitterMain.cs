using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.FileSplitter;

namespace WindowsFormsApplication1
{
    class SplitterMain
    {
        private static String[] filenames;
        private static String outDir = null;

        public static void setFileNames(String[] _filenames)
        {
            filenames = _filenames;

        }

        public static void setOutputFolder(String _outDir)
        {
            outDir = _outDir;
        }

        public static Boolean start()
        {
            if (outDir == null || filenames == null) { return false;  }
            foreach (string file in filenames)
            {
                new FileHandler(file).process();
            }

            foreach (FunctionData dat in DataManager.functions)
            {
                new DataWriter(outDir, dat).writeData();
            }

            GC.Collect();
            return true;
        }
    }
}
