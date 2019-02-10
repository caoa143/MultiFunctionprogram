using System;
using System.Text.RegularExpressions;

using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Codewars2
{
    class RevString
    {
        public static string Solution(string str)
        {
            List<char> letters = new List<char>();
            foreach (char x in str)
            {
                letters.Add(x);
            }
            letters.Reverse();
            string revString = string.Join("", letters);

            return revString;
        }
    }
}
