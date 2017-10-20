using System;

namespace csharp_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "hello world"; 
            string output = ""; 
            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }
            Console.WriteLine("Original String: " + input);
            Console.WriteLine("Reversed String: " + output);
        }
    }
}
