using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPracticeProblem.MethodOverloading
{
    internal class Method
    {
        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }
        public double Add(double a,
                          double b, double c)
        {
            double sum = a + b + c;
            return sum;
        }
    }
}
