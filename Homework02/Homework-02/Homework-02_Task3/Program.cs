using System;

namespace Homework_02_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;

            Console.Write("Please input the first number: ");
            string numberInput1 = Console.ReadLine();

            Console.Write("Please input the second number: ");
            string numberInput2 = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine($"First number before switch is {numberInput1}");
            Console.WriteLine($"Second number before switch is {numberInput2}");

            int num1 = int.Parse(numberInput1);
            int num2 = int.Parse(numberInput2);

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine();

            Console.WriteLine($"The first number after the switch is {num1}");
            Console.WriteLine($"The second number after the switch is {num2}");


            Console.ReadLine();
        }
    }
}
