using System;
using System.Text.RegularExpressions;

using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Codewars2
{
    class Likes
    {
        public static string Likes3(string[] name)
        {
            if (name.Length == 0)
            {
                return "no one likes this";
            }

            if (name.Length == 1)
            {
                return name[0] + " likes this";
            }

            if (name.Length == 2)
            {
                return name[0] + " and " + name[1] + " like this";
            }
            if (name.Length == 3)
            {
                return name[0] + ", " + name[1] + ", and " + name[2] + " like this";
            }

            int plusLikes = name.Length - 2;
            if (name.Length >= 4)
            {
                return name[0] + ", " + name[1] + ", and " + plusLikes + " others like this";
            }
            else
                return "fuck you";
        }
    }
}

//Kata.Likes(new string[0]) => "no one likes this"
//Kata.Likes(new string[] {"Peter"}) => "Peter likes this"
//Kata.Likes(new string[] {"Jacob", "Alex"}) => "Jacob and Alex like this"
//Kata.Likes(new string[] {"Max", "John", "Mark"}) => "Max, John and Mark like this"
//Kata.Likes(new string[] {"Alex", "Jacob", "Mark", "Max"}) => "Alex, Jacob and 2 others like this"
//For 4 or more names, the number in and 2 others simply increases.