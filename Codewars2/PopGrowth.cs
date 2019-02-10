using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars2
{
    class PopGrowth
    {
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            int yearCount = 0;

            double popValue = p0;
            double perc = percent / 100;

            while (popValue < p)
            {
                popValue = popValue + (popValue * perc) + aug;
                yearCount += 1;
            }

            return yearCount;
        }
    }
}

//How many years does the town need to see its population greater or equal to p = 1200 inhabitants?