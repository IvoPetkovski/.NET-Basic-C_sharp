using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes;
            Console.Write("Please enter how much minutes you want to convert to seconds: ");
            string minutesInput = Console.ReadLine();

            bool checkInput = int.TryParse(minutesInput, out minutes);

            while (!checkInput || minutes < 0)
            {
                Console.Write("Please input minutes with a positive number: ");
                minutesInput = Console.ReadLine();
                checkInput = int.TryParse(minutesInput, out minutes);
            }

            int result = ConvertToSeconds(minutes);
            Console.WriteLine($"The minutes calculated in seconds are {result}");
        }

        public static int ConvertToSeconds(int minutesInput)
        {
            int result;
            result = minutesInput * 60;
            return result;
        }
    }
}
