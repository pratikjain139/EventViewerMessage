using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventViewerMessage
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            for(int i =0;i<args.Length; i++)
            {
                MessageBox.Show(args[i]);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            
        }
    }
}
