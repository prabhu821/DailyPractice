using DailyPracticeProblem.MethodOverloading;
using DailyPracticeProblem.CollectionDemo;
using DailyPracticeProblem.MethodOverriding;

namespace DailyPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Method method = new Method();
            //Console.WriteLine("Daily Practice Problem");


            //int sum = method.Add(2, 4, 6);
            //Console.WriteLine("sum of the three "
            //                  + "integer value : " + sum);
            //double doubleSum = method.Add(1.0, 2.4, 3.0);
            //Console.WriteLine("sum of the three "
            //                  + "double value : " + doubleSum);

            //Collection collection = new Collection();
            //Collection.List();
            //Collection.Queue();
            //Collection.Dictinory();
            //Collection.Stack();
            //Collection.Set();

            DerivedClass d1 = new DerivedClass();
            DerivedClass d2 = new DerivedClass(10, 20);
            d2.swap();

        }
    }
}