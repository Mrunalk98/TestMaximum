using System;

namespace TestMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Test Maximum Program !");

            
            int maxInteger = new GenericMaximum<int>().MaximumValue(20, 40, 10);
            Console.WriteLine("Maximum Integer Output: " + maxInteger);

            double maxDouble = new GenericMaximum<double>().MaximumValue(20.22, 3.058, 80.5);
            Console.WriteLine("Maximum Double Output : " + maxDouble);


            string maxString = new GenericMaximum<string>().MaximumValue("Apple", "Peach", "Banana");
            Console.WriteLine("Maximum String Output : " + maxString);
        }
    }
}
