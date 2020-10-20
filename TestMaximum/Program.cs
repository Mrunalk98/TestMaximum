using System;

namespace TestMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Test Maximum Program !");
            int maxInteger = MaximumInteger(20, 10, 40);
            Console.WriteLine("Maximum Integer Output: " + maxInteger);

            double maxDouble = MaximumFloat(20.22, 3.058, 80.5);
            Console.WriteLine("Maximum Double Output : " + maxDouble);


            string maxString = MaximumString("Apple", "Peach", "Banana");
            Console.WriteLine("Maximum String Output : " + maxString);
        }

        // UC 1
        public static int MaximumInteger(int a, int b, int c)
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
                return a;
            if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
                return b;
            if (c.CompareTo(a) > 0 && c.CompareTo(b) > 0)
                return c;
            return 0;
        }

        // UC 2
        public static double MaximumFloat(double a, double b, double c)
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
                return a;
            if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
                return b;
            if (c.CompareTo(a) > 0 && c.CompareTo(b) > 0)
                return c;
            return 0;
        }

        // UC 3
        public static string MaximumString(string a, string b, string c)
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
                return a;
            if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
                return b;
            if (c.CompareTo(a) > 0 && c.CompareTo(b) > 0)
                return c;
            return null;
        }
    }
}
