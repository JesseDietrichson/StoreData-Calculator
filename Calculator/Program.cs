using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int secondNumber = int.Parse(Console.ReadLine());

            int answer = firstNumber * secondNumber;

            Console.WriteLine($"The answer is {answer}");
        }
    }
}
