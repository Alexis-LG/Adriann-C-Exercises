using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryCSharpExercises
{
    class ReturnOdd
    {
        public void ReturnOddElement()
        {
            // 4 - Write a function that returns the elements on odd positions in a list.
            var stringList = new List<string> { "cat", "cute", "pinino", "element", "elementz", "moar elementz" };
            for (int i = 0; i < stringList.Count; i++)
            {
                if (i % 2 != 0 && i % i == 0)
                    Console.WriteLine(stringList[i]);
                else
                    continue;
            }
        }
    }
}
