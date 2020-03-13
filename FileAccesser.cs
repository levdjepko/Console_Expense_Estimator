using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace simpleExpenseTracking_withClasses
{
    public static class FileAccesser
    {
        public static void WriteToFile (double value)
        {
            //this will return a current project path, probably in bin / debug folder
            string destPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "WriteLines2.txt");
            using (StreamWriter file =
             new StreamWriter(destPath, true))
            {
                file.WriteLine(value);
                file.WriteLine(DateTime.Now);
                file.WriteLine("\n");
            }
        }
    }
}
