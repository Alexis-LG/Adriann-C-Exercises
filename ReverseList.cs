using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryCSharpExercises
{
    class ReverseList
    {
        public void Reverse()
        {
            // 2 - Write function that reverses a list, preferably in place.
            var stringList = new List<string> { "cat", "cute", "pinino" };
            stringList.Reverse();
            foreach (var reverseWord in stringList)
            {
                Console.WriteLine(reverseWord);
            }
        }
    }
}
