using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5781_00_3224_5675
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Welcome3224();
            Welcome5675();
            Console.ReadKey();

        }


        static partial void Welcome5675();

        private static void Welcome3224()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("{0}, welcome to first console application ", name);
        }
    }
}