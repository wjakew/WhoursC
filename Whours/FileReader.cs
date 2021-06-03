using System;
using System.Collections.Generic;
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
            file = new StreamReader(this.path);
            line_counter = 0;
            validation_flag = false;
        }

        //function for loading data from file
        void load_file()
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
            }catch(Exception e)
            {
                validation_flag = false;
            }
            
        }

        void show_rawdata()
        {
            System.out.
        }


    }
}
