using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars2
{
    public class TwiceOld
    {
        public static int TwiceAsOld(int dadYears, int sonYears)
        {
            int dadCount = dadYears;
            int sonCount = sonYears;

            int dadCount2 = dadYears;
            int sonCount2 = sonYears;
            int yearsCount = 0;

            while (dadCount != sonCount * 2|| dadCount2 != sonCount2 * 2)
            {
                yearsCount += 1;
                dadCount += 1;
                sonCount += 1;

                dadCount2 -= 1;
                sonCount2 -= 1;
                
            }

            return yearsCount;
        }
    }
}

//Your function takes two arguments:

//current father's age (years)
//current age of his son(years)
//Сalculate how many years ago the father was twice as old as his son(or in how many years he will be twice as old).

//(16, TwiceAsOldSolution.TwiceAsOld(30, 7));