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
        public static void WriteToFile (object value)
        {
            //this will return a current project path, probably in bin / debug folder
            string destPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "WriteLines2.txt");
            using (StreamWriter file =
             new StreamWriter(destPath, true))
            {
                file.WriteLine("Total is: " + String.Format("{0:0.##}", value));
                file.WriteLine(DateTime.Now);
                file.WriteLine("\n");
            }
            Console.WriteLine("These expenses were saved to a log file");
        }

        public static void WriteAValue(object value)
        {
            //this will return a current project path, probably in bin / debug folder
            string destPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "WriteLines2.txt");
            using (StreamWriter file =
             new StreamWriter(destPath, true))
            {
                file.Write(value);
                file.Write(" ");
            }
        }
    }
}
