using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace DateCheckerLibrary
{
    public class DateCheckerLibrary
    {
        public byte DaysInMonth(ushort year, byte month)
        {
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                return 31;
            if (month == 4 || month == 6 || month == 9 || month == 11)
                return 30;
            if (month == 2)
            {
                if (year % 400 == 0)
                    return 29;
                if (year % 100 == 0)
                    return 28;
                if (year % 4 == 0)
                    return 29;
                return 28;
            }
            return 0;
        }

        public Boolean IsValidDate(short year, byte month, byte date)
        {
            if (month > 12 || month < 1)
                return false;
            if (date < 1)
                return false;
            if (date > DaysInMonth((ushort)year, month))
                return false;
            return true;
        }
    }
}

    