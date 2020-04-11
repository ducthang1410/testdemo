using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
    [TestClass]
    public class OddEvenTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(new getOddEven().GetEven() % 2 == 0);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(new getOddEven().GetEven() % 2 == 1);
        }
    }
}

