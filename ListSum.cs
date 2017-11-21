using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryCSharpExercises
{
    class ListSum
    {
        public void Sum()
        {
            //7 - Write three functions that compute the sum of the numbers in a list: using a for-loop, a while-loop and recursion. 
            //(Subject to availability of these constructs in your language of choice.)
            var numberList = new List<int> { 10, 20, 30 };
            var numberListTotal = 0;
            var i = 0;
            for (i = 0; i < numberList.Count; i++)
                numberListTotal += numberList[i];

            Console.WriteLine(numberListTotal);

            while (i < numberList.Count)
            {
                numberListTotal += numberList[i];
                i++;
            }
            Console.WriteLine(numberListTotal);
            // Recursion part needs to be added
        }
    }
}
