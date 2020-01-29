using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Scheduler.Data
{
    static class LogManager
    {
        public static void Log(string text)
        {
            string docPath = "./log.txt";
            try
            {
                File.AppendAllText(docPath, text);
            }
            catch (IOException)
            {
                MessageBox.Show("Error reading from file",
                   "File Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }
    }
}
