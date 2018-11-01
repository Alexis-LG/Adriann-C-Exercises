using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryCSharpExercises
{
    class OccurChecker
    {
        public void OccurCheck(string value)
        {
            // 3 - Write a function that checks whether an element occurs in a list.
            var stringList = new List<string> { "cat", "cute", "pinino" };
            Console.WriteLine(stringList.Contains(value));
        }
    }
}
