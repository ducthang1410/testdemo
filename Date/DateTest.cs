using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DateCheckerLibrary
{
    class DateTest
    {

        [TestFixture]
        public class CheckDateInMonth
        {
            [TestCase]
            public void CheckDayInMonthTest1()
            {
                DateCheckerLibrary dc = new DateCheckerLibrary();
                Assert.AreEqual(31, dc.DaysInMonth(1999, 5));
            }

            [TestCase]
            public void CheckDayInMonthTest2()
            {
                DateCheckerLibrary dc = new DateCheckerLibrary();
                Assert.AreEqual(31, dc.DaysInMonth(1999, 4));
            }

        }
    }
}
