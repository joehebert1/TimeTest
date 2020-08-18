using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace TimeTest
{
    class MyTime
    {
        #region Compare Time
        private static bool IsFromLessThanTo(TimeSpan from, TimeSpan to)
        {
            //RETURNS for compare
            //Value   Description
            //- 1     t1 is shorter than t2.
            //  0     t1 is equal to t2.
            //  1     t1 is longer than t2.

            return (TimeSpan.Compare(from, to) < 0); 
        }

        private static bool IsFromPositive (TimeSpan from)
        {
            TimeSpan newDay = new TimeSpan(0,0,0,0);
            return (TimeSpan.Compare(from, newDay) >= 0);
        }

        private static bool IsToWithinDay(TimeSpan to)
        {
            TimeSpan fullDay = new TimeSpan(0, 23, 59, 0);
            return (TimeSpan.Compare(to, fullDay) <= 0);
        }

        #endregion

        #region Format Time
        public static string ConvertTimeToHourMinute(TimeSpan ts)
        {
            return ts.ToString("hh\\:mm");
        }
        public static string ConvertTimeToHourMinuteAMPM(TimeSpan ts)
        {
            DateTime dt = DateTime.Today.Add(ts);
            return dt.ToString("hh:mm tt");
        }
        #endregion

        #region FROM Time
        public static TimeSpan TryFromTimeAdd(TimeSpan from, TimeSpan to, TimeSpan value)
        {
            TimeSpan temp = new TimeSpan(from.Hours, from.Minutes,from.Seconds);

            temp = temp.Add(value);

            return IsFromLessThanTo(temp, to) ? temp : from;
        }

        public static TimeSpan TryFromTimeSubtract(TimeSpan from, TimeSpan to, TimeSpan value)
        {
            TimeSpan temp = new TimeSpan(from.Hours, from.Minutes, from.Seconds);

            temp = temp.Subtract(value);

            return IsFromPositive(temp) ? temp : from;

        }

        public static TimeSpan FromTimeAddHour(TimeSpan from, TimeSpan to)
        {
            TimeSpan oneHour = new TimeSpan(1, 0, 0);
            return MyTime.TryFromTimeAdd(from, to, oneHour);
        }

        public static TimeSpan FromTimeAddMinute(TimeSpan from, TimeSpan to)
        {
            TimeSpan oneMinute = new TimeSpan(0, 1, 0);
            return MyTime.TryFromTimeAdd(from, to, oneMinute);
        }

        public static TimeSpan FromTimeSubtractHour(TimeSpan from, TimeSpan to)
        {
            TimeSpan oneHour = new TimeSpan(1, 0, 0);
            return MyTime.TryFromTimeSubtract(from, to, oneHour);
        }

        public static TimeSpan FromTimeSubtractMinute(TimeSpan from, TimeSpan to)
        {
            TimeSpan oneMinute = new TimeSpan(0, 1, 0);
            return MyTime.TryFromTimeSubtract(from, to, oneMinute);
        }
        #endregion

        #region TO Time
        public static TimeSpan TryToTimeAdd(TimeSpan from, TimeSpan to, TimeSpan value)
        {
            TimeSpan temp = new TimeSpan(to.Hours, to.Minutes, to.Seconds);

            temp = temp.Add(value);

            return IsToWithinDay(temp) ? temp : to;

        }

        public static TimeSpan TryToTimeSubtract(TimeSpan from, TimeSpan to, TimeSpan value)
        {
            TimeSpan temp = new TimeSpan(to.Hours, to.Minutes, to.Seconds);

            temp = temp.Subtract(value);

            return IsFromLessThanTo(from, temp) ? temp : to;

        }

        public static TimeSpan ToTimeAddHour(TimeSpan from, TimeSpan to)
        {
            TimeSpan oneHour = new TimeSpan(1, 0, 0);
            return MyTime.TryToTimeAdd(from, to, oneHour);
        }

        public static TimeSpan ToTimeAddMinute(TimeSpan from, TimeSpan to)
        {
            TimeSpan oneMinute = new TimeSpan(0, 1, 0);
            return MyTime.TryToTimeAdd(from, to, oneMinute);
        }

        public static TimeSpan ToTimeSubtractHour(TimeSpan from, TimeSpan to)
        {
            TimeSpan oneHour = new TimeSpan(1, 0, 0);
            return MyTime.TryToTimeSubtract(from, to, oneHour);
        }

        public static TimeSpan ToTimeSubtractMinute(TimeSpan from, TimeSpan to)
        {
            TimeSpan oneMinute = new TimeSpan(0, 1, 0);
            return MyTime.TryToTimeSubtract(from, to, oneMinute);
        }

        #endregion

    }
}
