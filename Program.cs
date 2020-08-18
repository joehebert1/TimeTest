using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TimeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string fromTime = "11:58";
            string toTime = "13:00";

            TimeSpan fromTS = TimeSpan.Parse(fromTime);
            TimeSpan toTS = TimeSpan.Parse(toTime);
            PrintOut(fromTS, toTS);

            Console.WriteLine("FromTimeAddHour()\n");
            fromTS = MyTime.FromTimeAddHour(fromTS, toTS);
            PrintOut(fromTS, toTS);

            Console.WriteLine("FromTimeAddMinute()\n");
            fromTS = MyTime.FromTimeAddMinute(fromTS, toTS);
            PrintOut(fromTS, toTS);

            Console.WriteLine("FromTimeSubtractMinute()\n");
            fromTS = MyTime.FromTimeSubtractMinute(fromTS, toTS);
            PrintOut(fromTS, toTS);

            Console.WriteLine("FromTimeSubtractHour()\n");
            fromTS = MyTime.FromTimeSubtractHour(fromTS, toTS);
            PrintOut(fromTS, toTS);


            Console.WriteLine("ToTimeAddHour()\n");
            toTS = MyTime.ToTimeAddHour(fromTS, toTS);
            PrintOut(fromTS, toTS);

            Console.WriteLine("ToTimeAddMinute()\n");
            toTS = MyTime.ToTimeAddMinute(fromTS, toTS);
            PrintOut(fromTS, toTS);

            Console.WriteLine("ToTimeSubtractMinute()\n");
            toTS = MyTime.ToTimeSubtractMinute(fromTS, toTS);
            PrintOut(fromTS, toTS);

            Console.WriteLine("ToTimeSubtractHour()\n");
            toTS = MyTime.ToTimeSubtractHour(fromTS, toTS);
            PrintOut(fromTS, toTS);
        }

        static void PrintOut(TimeSpan from, TimeSpan to)
        {
            Console.WriteLine("FROM: " + MyTime.ConvertTimeToHourMinute(from) +
                "\tTO: " + MyTime.ConvertTimeToHourMinute(to));

            Console.WriteLine("FROM: " + MyTime.ConvertTimeToHourMinuteAMPM(from) +
                "\tTO: " + MyTime.ConvertTimeToHourMinuteAMPM(to) + "\n");
        }
    }
}
/*
FROM: 12:58     TO: 13:00
FROM: 12:58 PM  TO: 01:00 PM

FromTimeAddMinute()

FROM: 12:59     TO: 13:00
FROM: 12:59 PM  TO: 01:00 PM

FromTimeSubtractMinute()

FROM: 12:58     TO: 13:00
FROM: 12:58 PM  TO: 01:00 PM

FromTimeSubtractHour()

FROM: 11:58     TO: 13:00
FROM: 11:58 AM  TO: 01:00 PM

ToTimeAddHour()

FROM: 11:58     TO: 14:00
FROM: 11:58 AM  TO: 02:00 PM

ToTimeAddMinute()

FROM: 11:58     TO: 14:01
FROM: 11:58 AM  TO: 02:01 PM

ToTimeSubtractMinute()

FROM: 11:58     TO: 14:00
FROM: 11:58 AM  TO: 02:00 PM

ToTimeSubtractHour()

FROM: 11:58     TO: 13:00
FROM: 11:58 AM  TO: 01:00 PM

Press any key to continue . . .

*/