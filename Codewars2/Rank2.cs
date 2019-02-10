using System;
using System.Text.RegularExpressions;

using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Codewars2
{
    class Rank2
    {
        public static int[] rank2num(int[] nums) //[10 8 7 9 5 4 6]>>>[1 3 4 2 6 7 5]

        {
            List<int> places = new List<int>();
            List<int> ordrd = nums.OrderByDescending(c => c).ToArray().ToList(); //[10 9 8 7 6 5 4]

            foreach (int x in nums)
            {
                places.Add(ordrd.IndexOf(x) + 1);
            }
            return places.ToArray();
        }
    }
}
