using System;
using System.Text.RegularExpressions;

using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Codewars2
{
    class EraseDups //Made by caoa  {5 3 4 7 9 8 4 3 2 7 9 8 1 1 3} >> [5 3 4 7 9 8 2 1]
    {
        public static int [] CutDups(int[] array)
        {
            List<int> resList = new List<int>();
            foreach (int num in array)
            {
                if (resList.Contains(num) == false)
                {
                    resList.Add(num);
                }
            }
            return resList.ToArray(); //Perfect

        }

        //which duplicate?      {1,2,3,5,2,6,8,7,5}>>[2 5]
        public static int[] FindDups(int[] array)
        {
            List<int> dupsL = new List<int>();
            List<int> index = new List<int>();

            List<int> dupsResult = new List<int>();

            int countOccur = 0;
            //occurNum.Add(array.GroupBy(c => c).Where(g => g.Count() > 1).Count());

            foreach (int x in array)
            {
                foreach(int y in array)
                {
                    if (x == y)
                    {
                        countOccur += 1;
                        if (countOccur > 1)
                        {
                            dupsL.Add(y);

                        }
                    }
                    
                }
                countOccur = 0;
            }

            

             foreach (int x in dupsL)
            {
                Console.WriteLine(x);
            }
            return dupsL.ToArray();
        }
    }
}
