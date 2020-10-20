using System;

namespace TestMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Test Maximum Program !");

            
            int maxInteger = new GenericMaximum<int>(20, 40, 10).MaxValue();
            Console.WriteLine("Maximum Integer Output: " + maxInteger);

            double maxDouble = new GenericMaximum<double>(20.22, 3.058, 80.5).MaxValue();
            Console.WriteLine("Maximum Double Output : " + maxDouble);


            string maxString = new GenericMaximum<string>("Apple", "Peach", "Banana").MaxValue();
            Console.WriteLine("Maximum String Output : " + maxString);
        }
    }
}
