using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whours.TimeManager
{
    class TimeManager_Object
    {
        String raw_data;            // raw data from line

        // fileds for parsed data
        int year, month, day;
        long hours, minutes;

        int obj_index;              // index for object
        public bool validation;     // flag for checking if vield is validated

        // constructor
        public TimeManager_Object(String line,int obj_index)
        {
            this.raw_data = line;
            this.obj_index = obj_index;
            validation = false;
            parse();
        }

        //function for parsing line to object
        void parse()
        {
            //template
            //05.06.2021[0:00-0:00]
            if ( raw_data.Contains("["))
            {
                String data_part = raw_data.Split("[")[0];
                String hour_part = raw_data.Split("[")[1].Split("-")[obj_index];

                // removing sign from the end
                if ( hour_part.EndsWith("]"))
                {
                    hour_part = hour_part.Substring(0, hour_part.Length - 1);
                }

                Debug.WriteLine(data_part + " | " + hour_part);
                String[] data_element = data_part.Split(".");

                // loading date info to objects
                if ( data_element.Length == 3 )
                {
                    day = Int32.Parse(data_element[0]);
                    month = Int32.Parse(data_element[1]);
                    year = Int32.Parse(data_element[2]);
                }
                else
                {
                    day = 1;
                    month = 1;
                    year = 1999;
                }

                String[] hour_element = hour_part.Split(":");
                // loading time info to objects
                if( hour_element.Length == 2 )
                {
                    hours = long.Parse(hour_element[0]);
                    minutes = long.Parse(hour_element[1]);
                }
                else
                {
                    hours = 0;
                    minutes = 0;
                }
                validation = true;
            }
            else
            {
                validation = false;
            }
        }

        //function for converting object to DateTime
        public DateTime convert()
        {
            // DateTime dt = new DateTime(2019, 2, 22, 14, 0, 0);
            return new DateTime(year, month, day, unchecked((int)hours), unchecked((int)minutes), 0);
        }

        public void show_debug()
        {
            Debug.WriteLine("RAW DATA: "+raw_data);
            Debug.WriteLine("Hours: " + hours + " Minutes: " + minutes);
            Debug.WriteLine("Year: " + year + " month: " + month + " day: " + day);
            Debug.WriteLine("Converted: "+convert().ToString());
        }
    }
}
