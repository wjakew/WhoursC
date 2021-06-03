using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whours.TimeManager;

namespace Whours
{
    class FileParser
    {
        FileReader file_object;         // field for storing original object
        public int data_obj_amount;            // amount of read objects from file

        bool validation_flag;           // flag for checking if object is correct

        public List<TimeManager_DayPair> time_objects;    // collection for storing objects
        
        //constructor
        public FileParser(FileReader file_object)
        {
            this.file_object = file_object;
            time_objects = new List<TimeManager_DayPair>();
            parse();

            validation_flag = validate();
        }

        // function for parasing file object
        void parse()
        {
            foreach(String line in file_object.file_lines)
            {
                time_objects.Add(new TimeManager_DayPair(new TimeManager_Object(line, 0), new TimeManager_Object(line, 1)));
            }

            data_obj_amount = time_objects.Count;
        }

        // function for validating object
        bool validate()
        {
            return data_obj_amount == file_object.file_lines.Count;
        }

        // function for showing debug data
        public void show_debug()
        {
            Debug.WriteLine("Debug data for FileParser data");
            Debug.WriteLine("Number of objects: "+data_obj_amount);
            Debug.WriteLine("RAW DATA:");
            foreach (TimeManager_DayPair tdp in time_objects)
            {
                Debug.WriteLine(tdp.time_start.convert().ToString()+" -> "+tdp.time_end.convert().ToString());
            }
            Debug.WriteLine("END");
        }

    }
}
