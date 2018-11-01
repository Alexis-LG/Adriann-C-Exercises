using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryCSharpExercises
{
    class RunningTotal
    {
        public void RunTotal()
        {
            //5 - Write a function that computes the running total of a list.
            var numberList = new List<int> { 20, 30, 50 };
            Console.WriteLine("Total sum of the numbers in the list is {0}", numberList.Sum());

        }
    }
}
