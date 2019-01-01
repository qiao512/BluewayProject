using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desay.DataReader
{
    public static class ExtensionCenter
    {
        public static DateTime TimeStampToDateTime(this string timestamp)
        {
            //2018072700205170

            int year = int.Parse(timestamp.Substring(0, 4));
            int month = int.Parse(timestamp.Substring(4, 2));
            int day = int.Parse(timestamp.Substring(6, 2));
            int hour = int.Parse(timestamp.Substring(8, 2));
            int minute = int.Parse(timestamp.Substring(10, 2));
            int second = int.Parse(timestamp.Substring(12, 2));
            int msecond = int.Parse(timestamp.Substring(14));
            DateTime t = new DateTime(year, month, day, hour, minute, second, msecond);
            return t;
        }
    }
}
