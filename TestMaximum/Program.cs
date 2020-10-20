using System;

namespace TestMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Test Maximum Program !");
            int[] array = { 20, 40, 60, 48, 15 };
            var maxVal = new GenericMaximum<int>(array).GetMaximumValue();
            Console.WriteLine("Maximum value = " + maxVal);
        }
    }
}
