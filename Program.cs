using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,count,  f1 = 1, f2 = 1, f3 = 1;
            Console.Write("Enter the Limit : ");
            count = int.Parse(Console.ReadLine());
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            for (i = 0; i <=0; i++)
            {
                f3 = f1 + f2;
                Console.WriteLine(f3);
                f1 = f2;
                f2 = f3;
            }
            Console.ReadLine();

        }
    }
}