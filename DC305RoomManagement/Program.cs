using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DC305RoomManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            AppDomain.CurrentDomain.SetData("Data", GetDataPath());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        private static string GetDataPath()
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string srcPath = (System.IO.Path.GetDirectoryName(executable));
            int uselessIndex = Array.IndexOf(srcPath.Split('\\'), "bin");
            string[] destPath = new string[uselessIndex];
            Array.Copy(srcPath.Split('\\'), destPath, uselessIndex);

            return string.Join("\\", destPath);
        }
    }

    
}
