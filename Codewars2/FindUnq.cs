using System;
using System.Text.RegularExpressions;

using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Codewars2
{
    class FindUnq
    {
        public static int GetUnique(IEnumerable<int> numbers)
        {
            List<int> dupsL = new List<int>();
            List<int> index = new List<int>();

            List<int> dupsResult = new List<int>();
            List<int> unqL = new List<int>();
            int countOccur = 0;
            foreach (int x in numbers)
            {
                foreach (int y in numbers)
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

            foreach (int z in numbers)
            {
                if (!(dupsL.Contains(z))){
                    unqL.Add(z);
                }
            }



            return unqL[0];
        }
    }
}


//other________________
//public static int GetUnique(IEnumerable<int> numbers)
//{
//    int[] numArray = numbers.ToArray();

//    int prevNum = numbers.First();
//    for (int i = 0; i < numArray.Length - 1; i++)
//    {
//        if (numArray[i] != prevNum)
//        {
//            if (numArray[i + 1] == numArray[i])
//                return prevNum;
//            else
//                return numArray[i];
//        }
//    }

//    return 0;
//}

    ///or sort by asc/desc and return first/last