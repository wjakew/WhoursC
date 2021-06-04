using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whours.FileConnector
{
    class FileCrawler
    {
        String current_directory;
        String[] file_paths;
        int file_amount;

        public String path_found;

        // constructor
        public FileCrawler()
        {
            current_directory = Directory.GetCurrentDirectory();
            Debug.WriteLine("Looking for files in " + current_directory);
            file_amount = 0;
            path_found = "";
            crawl();
            search();
        }

        // function for crawling on files
        void crawl()
        {
            file_paths = Directory.GetFiles(current_directory);
            file_amount = file_paths.Length;

            Debug.WriteLine("Amount of objects " + file_amount);

            foreach (String path in file_paths)
            {
                Debug.WriteLine(path);
            }
        }

        // function for searching file
        void search()
        {
            foreach(String path in file_paths)
            {
                if ( path.Contains("czas_pracy.txt"))
                {
                    path_found = path;
                    break;
                }
            }
            Debug.WriteLine("search result: " + path_found);
        }

    }
}
