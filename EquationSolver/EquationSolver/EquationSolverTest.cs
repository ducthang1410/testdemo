using System;
using System.Runtime.Remoting.Messaging;
using EquationSolverDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TC01_A0_B0_C0()
        {
            var rs = EquationSolver.Solve(0, 0, 0);
            Assert.AreEqual(ResultType.Infinity, rs.ResultType);
        }

        [TestMethod]
        public void TC02_A0_B0_C0()
        {
            var rs = EquationSolver.Solve(0, 0, 0);
            Assert.AreEqual(ResultType.NoSolution, rs.ResultType);
        }

        [TestMethod]
        public void TC03_A0_B0_C0()
        {
            var rs = EquationSolver.Solve(0, 1, 5);
            Assert.AreEqual(ResultType.OneSolution, rs.ResultType);
            Assert.AreEqual(-5, rs.x1);
    
        }
    }
}
