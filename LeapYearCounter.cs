using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryCSharpExercises
{   //10 - Write a program that prints the next 20 leap years.
    class LeapYearCounter
    {
        public void LeapCount()
        {
            for (int year = 2017; year < 2097; year++)
            {
                if (year % 4 != 0)
                    continue;
                else if (year % 100 != 0)
                    Console.WriteLine(year);
                else if (year % 400 != 0)
                    continue;
                else
                    Console.WriteLine(year);
            }
        }
    }
}
