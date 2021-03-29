using System;

namespace Homework_02_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            string numberInput1 = Console.ReadLine();

            Console.Write("Enter the second number: ");
            string numberInput2 = Console.ReadLine();

            Console.Write("Enter the third number: ");
            string numberInput3 = Console.ReadLine();

            Console.Write("Enter the fourth number: ");
            string numberInput4 = Console.ReadLine();

            double result = (double.Parse(numberInput1) + double.Parse(numberInput2) + double.Parse(numberInput3) + double.Parse(numberInput4)) / 4;
            Console.WriteLine($"The average of {numberInput1}, {numberInput2}, {numberInput3} and {numberInput4} is: {result}");

            Console.ReadLine();
        }
    }
}
