using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whours
{
    static class Whours
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        static int debug = 1;
        static String version = "#.0.1A1";

        [STAThread]
        static void Main()
        {
            show_header();
            if ( debug == 1)
            {
                Debug.Write("Debug session is on!");
                FileReader fr = new FileReader("text.txt");
                fr.load_file();
                fr.show_debug();
                
            }
            else
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Main_Window());
                
            }

            // prevents from ending after execution code
            Console.ReadLine();
        }

        static void show_header()
        {
            String header = "w#ours\n";
            Debug.Write(header);
            Debug.Write("by Jakub Wawak 2021 " + version);
        }
    }
}
