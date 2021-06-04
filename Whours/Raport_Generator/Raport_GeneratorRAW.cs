using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whours.TimeManager;

namespace Whours.Raport_Generator
{
    class Raport_GeneratorRAW
    {
        FileParser session_data;

        bool validate;

        //constructor
        public Raport_GeneratorRAW(FileParser session_data)
        {
            this.session_data = session_data;
            
        }

        // function for object validation
        bool validation()
        {
            return session_data.data_obj_amount > 0;
        }

        // function for calculating minutes
        public long calculate_minutes()
        {
            long calculated = 0;
            if ( validation())
            {
                foreach(TimeManager_DayPair tmdp in session_data.time_objects)
                {
                    calculated = calculated + tmdp.calculate_minutes();
                }
            }

            return calculated;
        }

        // function for calculating hours
        public long calculate_hours()
        {
            long calculated = 0;
            if (validation())
            {
                foreach (TimeManager_DayPair tmdp in session_data.time_objects)
                {
                    calculated = calculated + tmdp.calculate_hours();
                }
            }

            return calculated;
        }
    }
}
