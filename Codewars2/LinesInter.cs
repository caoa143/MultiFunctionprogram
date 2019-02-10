using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars2
{
    class LinesInter
    {
        public static bool LinesCross(string [] coors, string[] coors2)
        {
            foreach (string point in coors)
            {
                foreach(string point2 in coors2)
                {
                    if (point == point2)
                    {
                        return true;
                    }
                    
                }
            }
            return false;

        }
    }
}


//string[] line1 = { "a", "d", "r", "w", "p" };
//string[] line2 = { "e", "w", "q", "x", "l" };