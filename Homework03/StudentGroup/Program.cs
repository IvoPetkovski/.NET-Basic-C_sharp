using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = new string[] { "Ivan", "Angela", "Petar", "Sofija", "Aleksandar" };
            string[] studentsG5 = new string[] { "Marjan", "Emilija", "Bojan", "Teodora", "Anita" };
            int num;


            Console.Write("Please enter the student group with 1 or 5 (G1 or G5): ");
            string numberInput = Console.ReadLine();
            bool checkInput = int.TryParse(numberInput, out num);

            while (!checkInput || (num != 1 && num != 5))
            {
                Console.Write("Please enter 1 or 5 with NUMBERS to see the names of the Groups: ");
                numberInput = Console.ReadLine();
                checkInput = int.TryParse(numberInput, out num);
            }
            if (num == 1)
            {
                Console.WriteLine("The Students in G1 are:");
                for (int i = 0; i < studentsG1.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {studentsG1[i]}");
                }
            }
            else if (num == 5)
            {
                Console.WriteLine("The Students in G5 are:");
                for (int i = 0; i < studentsG5.Length; i++)
                { 
                    Console.WriteLine($"{i + 1}. {studentsG5[i]}");
                }
            }
        }
    }
}
