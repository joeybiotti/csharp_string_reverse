using System;
using System.Linq;

namespace csharp_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "hello world"; 
            string output = new string(input.ToCharArray().Reverse().ToArray());

            Console.WriteLine("Original string: " + input);
            Console.WriteLine("Reversed string: " + output);
        }
    }
}
