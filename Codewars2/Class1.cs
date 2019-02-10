using System;
using System.Text.RegularExpressions;

using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Codewars2
{
   

public class Kata
    {
        public static string AbbrevName(string name)
        {
            List<char> letter = new List<char>();
            string[] separate = name.Split(' ');
            foreach (string subname in separate)
            {
                letter.Add(subname[0]);
            }

            string newString=string.Join(".", letter.ToArray());

            return newString.ToUpper();
        }

    }
}

//("S.H", Kata.AbbrevName("Sam Harris")