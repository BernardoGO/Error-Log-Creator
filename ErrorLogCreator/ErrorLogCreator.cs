using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ErrorLogCreator
{
    public class ErrorLogCreator
    {
        public static string LogName = "ErrorLog.txt";
        public static string AssemblyTitle = "Title";
        public static string AssemblyVersion = "Version";
        public static string AssemblyVersionInfo =  "VersionInfo";
        public static void AddError(string Error)
        {
            StreamWriter writer = File.AppendText(LogName);
            writer.WriteLine("-> " + AssemblyTitle + " v" + AssemblyVersion + AssemblyVersionInfo + " :: " + DateTime.Now.ToString() + " - Error: " + Error + "; <-");
            writer.Close();
        }
    }
}
