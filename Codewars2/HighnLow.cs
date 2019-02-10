using System;
using System.Text.RegularExpressions;

using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Codewars2
{
    class HighnLow
    {
        public static string HighAndLow(string numbers)
        {
            string[] strToArr = numbers.Split(" ");
            List<int> listNums = new List<int>();
            List<int> resNums = new List<int>();



            for (int i = 0; i < strToArr.Length; i++)
            {
                Convert.ToInt32(i.ToString());
                listNums.Add(i);
            }
            int[] toArr = listNums.ToArray();
            int[] descArr = toArr.OrderByDescending(i => i).ToArray();

            resNums.Add(descArr[0]);
            resNums.Add(descArr[descArr.Length - 1]);

            return string.Join(" ",resNums.ToArray());



        }
    }
}
