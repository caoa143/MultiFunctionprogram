using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars2
{
    class XOsBool
    {
        public static bool XO(string input)
        {
            int xCount = 0;
            int oCount = 0;

            foreach ( char let in input)
            {
                if (let == 'x' || let == 'X')
                {
                    xCount += 1;
                }

                if (let == 'o' || let == 'O')
                {
                    oCount += 1;
                }
            }

            if (xCount == oCount)
            {
                return true;
            }
            else
                return false;
        }
    }
}
