using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whours.TimeManager
{
    class TimeManager_DayPair
    {
        public TimeManager_Object time_start, time_end;    // fields for storing time
        public bool validation;                            // flag for checking if time is correctly


        // constructor
        public TimeManager_DayPair(TimeManager_Object time_start,TimeManager_Object time_end)
        {
            this.time_start = time_start;
            this.time_end = time_end;

            validation = validate();
        }

        // function for validating data
        bool validate()
        {
            // time start before time_end
            return time_start.convert().CompareTo(time_end.convert()) == -1;
        }
    }
}
