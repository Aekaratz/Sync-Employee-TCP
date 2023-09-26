using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace SyncDataApp
{
    class Logger
    {
       
        public static void DeleteLog()
        {
            string logPath = ConfigurationManager.AppSettings["logPath"]; 
          
            if (File.Exists(logPath))
            {
                File.Delete(logPath);
            }

        }
        public static void WriteLog(string message)
        {
            string logPath = ConfigurationManager.AppSettings["logPath"];
            using (StreamWriter writer = new StreamWriter(logPath, true))
            {
                writer.WriteLine($"{DateTime.Now} : {message}\n");
            }

        }
    }
}
