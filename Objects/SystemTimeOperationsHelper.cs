using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeChanger.Objects
{
    public static class SystemTimeOperationsHelper
    {
        public static SystemTime Add(SystemTime time, long diffMs)
        {
            DateTime dateTime = ToDateTime(time);
            dateTime = dateTime.AddMilliseconds(diffMs);
            return FromDateTime(dateTime);
        }
        public static SystemTime Substract(SystemTime time, long diffMs)
        {
            DateTime dateTime = ToDateTime(time);
            dateTime = dateTime.AddMilliseconds(-diffMs);
            return FromDateTime(dateTime);
        }
        public static DateTime ToDateTime(SystemTime time)
        {
            return new DateTime(time.Year, time.Month, time.Day, time.Hour, time.Minute, time.Second, time.Millisecond);
        }
        public static SystemTime FromDateTime(DateTime time)
        {
            return new SystemTime()
            {
                Year = (ushort)time.Year,
                Month = (ushort)time.Month,
                Day = (ushort)time.Day,
                Hour = (ushort)time.Hour,
                Minute = (ushort)time.Minute,
                Second = (ushort)time.Second,
                Millisecond = (ushort)time.Millisecond,
                DayOfWeek = (ushort)time.DayOfWeek
            };
        }
    }
}
