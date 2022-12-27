using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPracticeProblem.MethodOverriding
{
    public class OverridingMethod
    {
        public int n1,n2;
        public OverridingMethod()
        {
            
        }

        public OverridingMethod(int i, int j)
        {
            n1 = i;
            n2 = j;
        }

        public virtual void swap()
        {
            Console.WriteLine("Swap function of base class");
            Console.WriteLine("Before swap num1 = {0} and num2 = {1}", n1, n2);
            int t = n1;
            n1 = n2;
            n2 = t;
            Console.WriteLine("After swap num1 = {0} and num2 = {1}", n1, n2);
        }
    }

    public class DerivedClass : OverridingMethod
    {
        public DerivedClass() : base() { }
        public DerivedClass(int i, int j) : base(i, j) { }

        public override void swap()
        {
            base.swap();
            Console.WriteLine("\nSwap function of derived class");
            Console.WriteLine("Before swap num1 = {0} and num2 = {1}", n1, n2);
            int t = n1;
            n1 = n2;
            n2 = t;
            Console.WriteLine("After swap num1 = {0} and num2 = {1}", n1, n2);
        }
    }
}
