using System;
using System.Text.RegularExpressions;

using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Codewars2
{
    class CountDups
    {
        public static int DuplicateCount(string str)
        {
            return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count(); //group by numbers, whenever >1 apprearance, count those
        }
        //---------------------------------------------------------------

    }
    
}

//Assert.AreEqual(0, Kata.DuplicateCount(""));
//    Assert.AreEqual(0, Kata.DuplicateCount("abcde"));
//    Assert.AreEqual(2, Kata.DuplicateCount("aabbcde"));
//    Assert.AreEqual(2, Kata.DuplicateCount("aabBcde"), "should ignore case");