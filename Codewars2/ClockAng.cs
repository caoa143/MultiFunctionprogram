using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars2
{
    class ClockAng
    {
        public static string CAngle(double H, double M)
        {
            double minPos = M / 5;
            double pAngle = Math.Abs(minPos - H)*30; //Large angle pre-movement
            double movAngle = M * 0.5;                  //angle hour hand moved

            double finalAng = 0;

            if (H >= minPos)
            {
                finalAng = pAngle + movAngle;
            }

            if (H < minPos)
            {
                finalAng = pAngle - movAngle;

            }

            if (finalAng > 180)
            {
                double finalAngle2 = 360 - finalAng;
                return finalAng + " OR " + finalAngle2;
            }

            return finalAng.ToString() ;


        }
    }
}
