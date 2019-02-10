using System;
using System.Text.RegularExpressions;

using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Codewars2
{
    class Palindrome
    {
        public static bool IsPalindrome(object line)
        {
            string fucku = line.ToString().ToLower();

            if( fucku.Length % 2 == 0) //even
            {
                for (int i = 0; i < (fucku.Length / 2) - .5; i++)
                {
                    if (fucku[i] == fucku[fucku.Length - i - 1]){
                        return true;
                    }
                }

            }

            if (fucku.Length % 2 != 0) //odd
            {
                for (int i = 0; i < (fucku.Length / 2); i++)
                {
                    if (fucku[i] == fucku[fucku.Length - i - 1])
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
