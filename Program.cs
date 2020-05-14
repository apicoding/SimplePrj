using System;

namespace SimplePrj
{
    interface IPrint
    {
        void Print();
    }

    class Printer : IPrint
    {
        public void Print()
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class Program
    {
        public static void Main()
        {
            new Printer().Print();
        }
    }
}
