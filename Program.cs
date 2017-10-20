using System;

namespace csharp_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "hello world"; 
            char[] inputarray = input.ToCharArray();
            Array.Reverse(inputarray);
            string output = new string(inputarray);

            Console.WriteLine("Original string: " + input);
            Console.WriteLine("Reversed string: " + output);
        }
    }
}
