using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1re
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 20, secondNumber = 15;

            Console.WriteLine("Before swapping:");
            Console.WriteLine("firstNumber = " + firstNumber);
            Console.WriteLine("secondNumber = " + secondNumber);

            // Swap using the XOR trick
            firstNumber ^= secondNumber;
            secondNumber ^= firstNumber;
            firstNumber ^= secondNumber;

            Console.WriteLine("\nAfter swapping:");
            Console.WriteLine("firstNumber = " + firstNumber);
            Console.WriteLine("secondNumber = " + secondNumber);
        }
    }
}
