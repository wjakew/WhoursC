using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whours
{
    class FileReader
    {
        public String path;          // field for stoirng path to file

        List<String> file_lines;     // collection for storing lines of file
        StreamReader file;           // object representing file in object
        int line_counter;
        bool validation_flag;

        //constructor
        public FileReader(String path)
        {
            this.path = path;
            try
            {
                file = new StreamReader(this.path);
            }catch(Exception e)
            {
                file = null;
                Debug.WriteLine("ERROR: " + e.ToString());
            }
            file_lines = new List<String>();
            line_counter = 0;
            validation_flag = false;
        }

        //function for loading data from file
        public void load_file()
        {
            if ( file != null)
            {
                try
                {
                    String line;
                    while ((line = file.ReadLine()) != null)
                    {
                        file_lines.Add(line);
                        line_counter++;
                    }
                    validation_flag = true;
                }
                catch (Exception e)
                {
                    validation_flag = false;
                }
            }
        }

        //function for showing file data
        public void show_debug()
        {
            Debug.WriteLine("FILE PATH: " + path);
            Debug.WriteLine("Number of lines: " + line_counter);
            Debug.WriteLine("RAW DATA:");
            foreach(String line in file_lines){
                Debug.WriteLine(line);
            }
            Debug.WriteLine("EOF");
        }


    }
}
