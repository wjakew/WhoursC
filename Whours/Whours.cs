using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Whours.FileConnector;
using Whours.TimeManager;

namespace Whours
{
    static class Whours
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        static int debug = 0;   // flag for debug
        static String version = "#.0.1A1";

        [STAThread]
        static void Main()
        {
            show_header();

            // debug option
            if ( debug == 1)
            {
                FileCrawler fc = new FileCrawler();
            }
            // normal running
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
            String header = "\nw#ours";
            Debug.WriteLine(header);
            Debug.WriteLine("by Jakub Wawak 2021 " + version);
        }
    }
}
