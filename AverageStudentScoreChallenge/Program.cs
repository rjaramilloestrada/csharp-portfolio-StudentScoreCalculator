using System;
using System.Reflection.Metadata.Ecma335;

namespace AverageStudentScoreChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "0";
            int scoreCount = 0;
            int scoreTotal = 0;
            int currentScoreNum = 0;

            while (userInput != "-1")
            {
                Console.WriteLine("Last score entered was {0}", currentScoreNum);
                Console.WriteLine("Please enter the next score");
                Console.WriteLine("Current amount of entries is {0}", scoreCount);
                Console.WriteLine("Please enter -1 to calculate the average");

                userInput = Console.ReadLine();
                if (userInput.Equals("-1"))
                {
                    Console.WriteLine("-----------------------------------------");
                    double averageScore = (double)scoreTotal / (double)scoreCount;
                    Console.WriteLine("The average score of students is {0}", averageScore);
                }
                if (int.TryParse(userInput, out currentScoreNum) && currentScoreNum > 0 && currentScoreNum < 21)
                {
                    scoreTotal = scoreTotal + currentScoreNum;
                }
                else
                {
                    if (!(userInput.Equals("-1")))
                    {
                        Console.WriteLine("Please enter a value between 1 and 20!");
                    }
                    continue;
                }

                scoreCount++;

            }

            Console.ReadLine();
        }
    }

}


