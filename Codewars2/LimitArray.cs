using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars2
{
    class LimitArray
    {
        public static bool SmallEnough(int[] a, int limit)
        {
            foreach (int x in a)
            {
                if (x > limit)
                {
                    return false;
                }

            }
             
                    return true;
        }
    }
}
