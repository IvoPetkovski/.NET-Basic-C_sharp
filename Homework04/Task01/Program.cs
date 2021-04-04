using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("Please enter the age: ");
            string ageInput = Console.ReadLine();

            bool checkInput = int.TryParse(ageInput, out age);

            while (!checkInput || age < 0)
            {
                Console.Write("Please enter the age with a positive number: ");
                ageInput = Console.ReadLine();
                checkInput = int.TryParse(ageInput, out age);
            }

            int result = CalcAge(age);
            Console.WriteLine($"The age calculated in days is {result}");
            
        }

        public static int CalcAge(int ageYears)
        {
            int result;
            result = ageYears * 365;
            return result;
        }
    }
}
