using System;
using System.Text.RegularExpressions;

using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Codewars2
{
    class RemoveSpace
    {
        public static string NoSpace(string input)  //PERFECT 
        {
            string[] spacesplit = input.Split(' ');
            string noSpace=string.Join("", spacesplit.ToArray());

            return noSpace;
        }
    }
}

//("8j8mBliB8gimjB8B8jlB",SpacesRemover.NoSpace("8 j 8   mBliB8g  imjB8B8  jl  B"));

//________________________________________OR______________________
//public static string NoSpace(string input)
//{
//    return input.Replace(" ", "");
//}
