using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Logger
    {
        string _filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Log.txt");
        public void LogError(string errorMessage, DateTime time)
        {
            time = DateTime.Now;
            using (StreamWriter sw = File.AppendText(_filePath))
            {
                sw.WriteLine($"{errorMessage}|{time}");
            }
        }

    }
}
