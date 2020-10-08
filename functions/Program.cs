using System;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloUser();
            Sum();
        }

        public static void HelloUser()
        {
            Console.WriteLine("enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"hello, {userName}");
        }

        public static void Sum()
        {
            Console.WriteLine("Enter the first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int b = Int32.Parse(Console.ReadLine());
        }

    }
}
