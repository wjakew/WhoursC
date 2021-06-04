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
        public String path;                 // field for stoirng path to file

        public List<String> file_lines;     // collection for storing lines of file
        StreamReader file;                  // object representing file in object
        
        int line_counter;
        public bool validation_flag;
        public bool file_exist;
        //constructor
        public FileReader(String path)
        {
            this.path = path;
            if (File.Exists(this.path)) // checking if file exists
            {
                try
                {
                    file = new StreamReader(this.path); // loading file to object
                    file_exist = true;
                }
                catch (Exception e)
                {
                    file = null;
                    Debug.WriteLine("ERROR: " + e.ToString());  // getting error by file exist
                    validation_flag = false;

                }
            }
            else
            {
                validation_flag = false;
                file_exist = false;
            }
            
            file_lines = new List<String>();
            line_counter = 0;
            load_file();
            
        }

        //function for loading data from file
        void load_file()
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
                    Debug.WriteLine(e.ToString());
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
