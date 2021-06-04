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

        // function for calculating time between dates
        TimeSpan calculate_span()
        {
            return time_end.convert().Subtract(time_start.convert());
        }

        // function for calculating minutes
        public long calculate_minutes()
        {
            return calculate_span().Minutes;
        }

        // function for calculating hours
        public long calculate_hours()
        {
            return calculate_span().Hours;
        }

        // function for showing object data for gui components
        public String prepare_glance()
        {
            return time_start.convert().ToString() + " -> " + time_end.convert().ToString();
        }

        // function for showing object data for gui components with time span
        public String prepare_glance_full()
        {
            return time_start.convert().ToString() + " -> " + time_end.convert().ToString() + "[" + calculate_minutes() + "]";
        }
    }
}
