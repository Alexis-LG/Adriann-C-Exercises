using System;

public class PrimeNumberPrinter
{
	public void PrintPrimeNumber()
	{
        //Write a program that prints all prime numbers. 
        //(Note: if your programming language does not support arbitrary size numbers, 
        //printing all primes up to the largest number you can easily represent is fine too.)
        for (int i = 1; i < 100; i++)
        {
            if (i % 2 != 0 && i % i == 0 || i == 2)
            {
                Console.WriteLine(i);
            }

        }
        
    }
}
