using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Exercises_Elementary
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Write a program that prints ‘Hello World’ to the screen.
            //Console.WriteLine("Hello World.");

            //2 - Write a program that asks the user for their name and greets them with their name.
            //Console.WriteLine("What's your name?");
            //var input = Console.ReadLine();
            //Console.WriteLine("Hello " + input);

            //3 - Modify the previous program such that only the users Alice and Bob are greeted with their names.
            //Console.WriteLine("What's your name?");
            //var input = Console.ReadLine();
            //if (input != null && (input.Equals("Alice") || input.Equals("Bob")))
            //{
            //    Console.WriteLine("Hello " + input);
            //}

            //4 -  Write a program that asks the user for a number n and prints the sum of the numbers 1 to n
            //Console.WriteLine("Enter a number:");
            //var input = Convert.ToInt32(Console.ReadLine());
            //var sum = 0;

            //for (var i = 0; i <= input; i++)
            //{
            //    sum += i;
            //}

            //Console.WriteLine(sum);
            //Console.ReadKey();

            //// 5 - Modify the previous program such that only multiples of three or five are considered in the sum, e.g. 3, 5, 6, 9, 10, 12, 15 for n=17
            //Console.WriteLine("Enter a number:");
            //var input = Convert.ToInt32(Console.ReadLine());
            //var listOfInts = new List<int>(input);
            //var total = 0;
            //for (int i = 0; i < input; i++)
            //{
            //    total = input - i;
            //    if (total%3==0 || total%5==0)
            //    {
            //        listOfInts.Add(total);
            //    }

            //}
            //Console.WriteLine(listOfInts.Sum());

            // 6 - Write a program that asks the user for a number n and gives them the possibility to choose between computing the sum and computing the product of 1,…,n.
            //    Console.WriteLine("Enter a number:");
            //    var input = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Do you want to process the sum or the product of the number?");
            //    var choiceInput = Console.ReadLine();

            //    if (choiceInput == "Sum")
            //    {
            //        var sum = 0;
            //        for (var i = 0; i <= input; i++)
            //        {
            //            sum += i;
            //        }
            //        Console.WriteLine("Total sum is: {0}", sum);


            //    }
            //    else if (choiceInput == "Product")
            //    {
            //        var product = 1;
            //        for (int i = 1; i <= input; i++)
            //        {
            //            product *= i;
            //        }
            //        Console.WriteLine("Total product is: {0}", product);
            //    }
            //    else

            //        Console.WriteLine("Incorrect choice. Please try again.");

            // 7 - Write a program that prints a multiplication table for numbers up to 12.
            //    var product = 0;
            //    for (int firstFactor = 1; firstFactor <= 12; firstFactor++)
            //    {
            //        for (int secondFactor = 1; secondFactor <= 12 ; secondFactor++)
            //        {
            //            product = firstFactor * secondFactor;
            //            Console.WriteLine(product);
            //        }
            //    }

            ////Write a program that prints all prime numbers. (Note: if your programming language does not support arbitrary size numbers, printing all primes up to the largest number you can easily represent is fine too.)
            //for (int i = 1; i < 100; i++)
            //{
            //    if (i%2 != 0 && i%i == 0 || i == 2)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //Write a guessing game where the user has to guess a secret number. After every guess the program tells the user whether their number was too large or too small. At the end the number of tries needed should be printed. I counts only as one try if they input the same number multiple times consecutively.
        //    Random random = new Random();
        //    int secretNumber = random.Next(10);

        //    Console.WriteLine("GAME: Guess the number");
        //    Console.WriteLine(secretNumber);
        //    var triesList = new List<int>();
        //    while (true)
        //    {
        //        var input = Convert.ToInt16(Console.ReadLine());
        //        triesList.Add(input);
        //        if (input > secretNumber)
        //            Console.WriteLine("The number is too large.");
        //        else if (input < secretNumber)
        //            Console.WriteLine("The number is too small.");
        //        else
        //            break;
        //    }
        //    Console.WriteLine("You've guessed the number!");
        //    Console.WriteLine("You've tried {0} times",triesList.Distinct().Count());
        //}
        }
    }

    
}
