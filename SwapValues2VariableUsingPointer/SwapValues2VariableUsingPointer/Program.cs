using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwapValues2VariableUsingPointer
{
    class Program
    {
        static void SwapNum(ref int x, ref int y)
        {
            int tempswap = x;
            x = y;
            y = tempswap;
        }
        static void Main(string[] args)
        {
            int a = 100;
            int b = 500;
            Console.WriteLine("Value of a and b before swapping");
            Console.WriteLine();
            Console.WriteLine("a = " + " " + a);
            Console.WriteLine("b = " + " " + b);
            SwapNum(ref a, ref b);
            Console.WriteLine();
            Console.WriteLine("Value of a and b after swapping");
            Console.WriteLine();
            Console.WriteLine("a = " + " " + a);
            Console.WriteLine("b = " + " " + b);
            Console.ReadLine();
        }
    }
}
