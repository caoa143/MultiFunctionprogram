using System;
using System.Text.RegularExpressions;

using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Codewars2
{
    class Walk10
    {
        public class Kata  //{"n","s","n","s","n","s","n","s","n","s"}),
        {
            public static bool IsValidWalk(string[] walk)
            {
                int countN = 0;
                int countS = 0;

                int countE = 0;
                int countW = 0;

                if (walk.Length != 10)
                {
                    return false;
                }
                foreach (string d in walk)
                {
                    if (d == "n")
                    {
                        countN += 1;
                    }
                    if (d == "s")
                    {
                        countS += 1;
                    }
                    if (d == "e")
                    {
                        countE += 1;
                    }
                    if (d == "w")
                    {
                        countW+= 1;
                    }
                }
                //n-s only
                if (!(walk.Contains("e")|| walk.Contains("w")))
                    {
                    if (countN == countS)
                    {
                        return true;
                    }
                    return false;
                }
                //e-w only
                if (!(walk.Contains("n") || walk.Contains("s")))
                {
                    if (countE == countW)
                    {
                        return true;
                    }
                    return false;
                }

                if( countN==countS&& countE == countW)
                {
                    return true;
                }
                return false;



            }
        }
    }
}
