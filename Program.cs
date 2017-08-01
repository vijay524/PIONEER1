using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharacterInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "RAMBOPAL";

            // Get size of string
            Console.WriteLine("Size of string: {0}", name.Length);

            // Remove all empty characters
            string nameWithoutEmptyChar = name.Replace(" ", "");

            // Size after empty characters are removed
            Console.WriteLine("Size of non empty char string: {0}",
            nameWithoutEmptyChar.Length);

            // Read and print all characters
            for (int counter = 0; counter <= nameWithoutEmptyChar.Length - 1; counter++)
                Console.WriteLine(nameWithoutEmptyChar[counter]);
            Console.ReadLine();
        }
    }
}