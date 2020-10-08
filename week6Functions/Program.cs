using System;

namespace week6Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            ParamSum(5, 5);
            DisplayString("100");
        }


        public static void ParamSum(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }

        public static void DisplayString(string someString)
        {
            Console.WriteLine(someString);
        }

    }
}
