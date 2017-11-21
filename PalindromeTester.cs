using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryCSharpExercises
{
    class PalindromeTester
    {
        public static string ReverseString(string stringComparer)
        {
            char[] stringArray = stringComparer.ToCharArray();
            Array.Reverse(stringArray);
            return new string(stringArray);
        }

        public void TestForPalindrome(string compareValue)
        {
            ////6 - Write a function that tests whether a string is a palindrome.
            var stringToCompare = compareValue;
            if (stringToCompare == ReverseString(stringToCompare))
                Console.WriteLine("This string is a Palindrome");
            else if (stringToCompare != ReverseString(stringToCompare))
                Console.WriteLine("This string is not a Palindrome");
            else
                Console.WriteLine("Damn son, where did you find this?");
        }
    }
}
