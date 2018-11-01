using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryCSharpExercises
{
    class LargestElement
        // 1 - Write a function that returns the largest element in a list.
    {   
        public void ReturnLargestElement()
        {
            var stringList = new List<string> { "cat", "cute", "pinino" };
            var longestString = "";
            var orderedStringList = new List<string>();
            for (int i = 0; i < stringList.Count(); i++)
            {
                if (stringList[i].Length > longestString.Length)
                    longestString = stringList[i];
            }
            Console.WriteLine(longestString);
        }
    }
}
