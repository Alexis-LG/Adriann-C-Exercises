using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryCSharpExercises
{
    class GuessingGame
    {
        public void GuessTheNumber(int input)
        {
            //Write a guessing game where the user has to guess a secret number. 
            //After every guess the program tells the user whether their number 
            //was too large or too small. At the end the number of tries needed should be printed. 
            //It counts only as one try if they input the same number multiple times consecutively.

            Random random = new Random();
            int secretNumber = random.Next(10);

            Console.WriteLine("GAME: Guess the number");
            Console.WriteLine(secretNumber);
            var triesList = new List<int>();
            while (true)
            {
                input = Convert.ToInt16(Console.ReadLine());
                triesList.Add(input);
                if (input > secretNumber)
                    Console.WriteLine("The number is too large.");
                else if (input < secretNumber)
                    Console.WriteLine("The number is too small.");
                else
                    break;
            }
            Console.WriteLine("You've guessed the number!");
            Console.WriteLine("You've tried {0} times", triesList.Distinct().Count());
        }
    }
}
