using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationSolverDemo
{
    public class EquationSolver
    {
        public ResultType ResultType { get; set; }
        public double x1 { get; set; }
        public double x2 { get; set; }

        public static EquationSolver Solve(int a, int b, int c)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        return new EquationSolver()
                        {
                            ResultType = ResultType.Infinity
                        };
                    }
                    else
                    {
                        return new EquationSolver()
                        {
                            ResultType = ResultType.NoSolution
                        };
                    }
                }
                else
                {
                    return  new EquationSolver()
                    {
                        ResultType = ResultType.OneSolution,
                        x1 = (double)-c / b
                    };
                }
            }
            return null;
        }

        
    }

    public class EquationResult
        {
        public ResultType ResultType { get; set; }
        public double x1 { get; set; }
            public double x2 { get; set; }
        }

        public enum ResultType
        {
            NoSolution,
            OneSolution,
            TwoSolution,
            Infinity
        }

    }

