using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TimeChanger.Objects
{
    public static class SystemTimeHelper
    {
        [DllImport("kernel32.dll", EntryPoint = "GetSystemTime", SetLastError = true)]
        extern static void Win32GetSystemTime(ref SystemTime sysTime);

        [DllImport("kernel32.dll", EntryPoint = "SetSystemTime", SetLastError = true)]
        extern static bool Win32SetSystemTime(ref SystemTime sysTime);

        public static SystemTime GetTime()
        {
            SystemTime time = new SystemTime();
            Win32GetSystemTime(ref time);
            return time;
        }
        public static void SetTime(SystemTime time)
        {
            if (!Win32SetSystemTime(ref time))
                throw new Exception("Set time failed");
        }
    }
}
