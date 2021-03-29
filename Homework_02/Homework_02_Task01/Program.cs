using System;

namespace Homework_02_Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1;

            Console.Write("Please enter the first number: ");
            string numberInput1 = Console.ReadLine();

            bool checkInput1 = double.TryParse(numberInput1, out number1);

            while (!checkInput1)
            {
                Console.Write("Please enter the first number with numbers: ");
                numberInput1 = Console.ReadLine();
                checkInput1 = double.TryParse(numberInput1, out number1);
            }


            double number2;

            Console.Write("Please enter the second number: ");
            string numberInput2 = Console.ReadLine();


            bool checkInput2 = double.TryParse(numberInput2, out number2);

            while (!checkInput2)
            {
                Console.Write("Please enter the second number with numbers: ");
                numberInput2 = Console.ReadLine();
                checkInput2 = double.TryParse(numberInput2, out number2);
            }

            Console.WriteLine();

            Console.WriteLine("The first number you have entered is: " + number1);
            Console.WriteLine("The second number you have entered is: " + number2);

            Console.WriteLine();

            Console.Write("Please enter the operation you want to be executed: ");
            string operation = Console.ReadLine();

            while (operation != "+" && operation != "-" && operation != "*" && operation != "/")
            {
                Console.Write("Please enter a valid operation: ");
                operation = Console.ReadLine();
            }

            Console.WriteLine();

            if (operation == "+")
            {
                double result = number1 + number2;
                Console.WriteLine($"The addition of the two numbers {number1} and {number2} is {result}");
            }
            else if (operation == "-")
            {
                double result = number1 - number2;
                Console.WriteLine($"The subtraction of the two numbers {number1} and {number2} is {result}");
            }
            else if (operation == "*")
            {
                double result = number1 * number2;
                Console.WriteLine($"The multiplication of the two numbers {number1} and {number2} is {result}");
            }
            else
            {
                double result = number1 / number2;
                Console.WriteLine($"The division of the two numbers {number1} and {number2} is {result}");
            }


            Console.ReadLine();
        }
    }
}
