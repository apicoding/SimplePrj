using System;

// ready to merge

namespace SimplePrj
{
    interface IPrint
    {
        void Print();
    }

    class Printer : IPrint
    {
        // method missing here
    }

    class Program
    {
        public static void Main()
        {
            new Printer().Print();
        }
    }
}
