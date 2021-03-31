using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numInput = new int[6];
            int sumOfEven = 0;

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Enter the {i + 1} number: ");
                numInput[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numInput.Length; i++)
            {
                if (numInput[i] % 2 == 0)
                {
                    sumOfEven = sumOfEven + numInput[i];
                }

            }
            Console.WriteLine($"The sum of the even numbers is: {sumOfEven}");


            Console.ReadLine();
        }
    }
}
