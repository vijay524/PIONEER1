/*
 * C# Program to Swap two Numbers
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, equally;
            Console.Write("\nEnter the First Number : ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the Second Number : ");
            n2 = int.Parse(Console.ReadLine());
            equally = n1;
            n1 = n2;
            n2 = equally;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + n1);
            Console.Write("\nSecond Number : " + n2);
            Console.Read();
        }
    }
}
