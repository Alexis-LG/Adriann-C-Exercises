using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryCSharpExercises
{
    class MultiplicationTable
    {
        public void Multiplicate()
        {
            // Write a program that prints a multiplication table for numbers up to 12.
            var product = 0;
            for (int firstFactor = 1; firstFactor <= 12; firstFactor++)
            {
                for (int secondFactor = 1; secondFactor <= 12; secondFactor++)
                {
                    product = firstFactor * secondFactor;
                    Console.WriteLine(product);
                }
            }
        }


}
