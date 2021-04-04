using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Please enter the name of the Football Team: ");
            string nameTeam = Console.ReadLine();
            Console.WriteLine("");
            
            Console.Write("Please enter the number of wins for this Football Team: ");
            string winsInput = Console.ReadLine();
            int wins = CheckInput(winsInput);
            Console.WriteLine("");

            Console.Write("Please enter the number of draws for this Football Team: ");
            string drawsInput = Console.ReadLine();
            int draws = CheckInput(drawsInput);
            Console.WriteLine("");

            Console.Write("Please enter the number of losses for this Football Team: ");
            string lossesInput = Console.ReadLine();
            int losses = CheckInput(lossesInput);
            Console.WriteLine("");

            int result = CalculateGames(wins, draws, losses);
            Console.WriteLine($"The Football Team \"{nameTeam}\" has {wins} wins, {draws} draws, {losses} losses.");
            Console.WriteLine($"The total amount of {result} points.");

        }

        public static int CheckInput(string numberInput)
        {
            int number;
            bool checkInput = int.TryParse(numberInput, out number);

            while (!checkInput || number < 0)
            {
                Console.Write("Please enter the input with a positive number: ");
                numberInput = Console.ReadLine();
                checkInput = int.TryParse(numberInput, out number);
            }
            return number;

        }

        public static int CalculateGames(int num1, int num2, int num3)
        {
            int result = (num1 * 3) + (num2 * 1) + (num3 * 0);
            return result;
        }
    }
}
