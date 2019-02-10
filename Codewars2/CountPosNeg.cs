using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars2
{
    class CountPosNeg
    {
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            int posCount = 0;
            int negSum = 0;

            List<int> resultList = new List<int>();

            foreach (int num in input)
            {
                if (num > 0)
                {
                    posCount += 1;
                }
                if (num < 0)
                {
                    negSum += num;
                }

                
            }

            
            resultList.Add(posCount);
            resultList.Add(negSum);



            return resultList.ToArray();

        }
    }
}

//______________________OR
//int c = 0;
//int s = 0;
//        if (input == null || input.Length == 0){
//          return new int[]{};
//        }
//        for (int i = 0; i<input.Length; i++){  
//          if (input[i] > 0){
//            c += 1;
//          }
//          if (input[i] < 0){
//            s += input[i];
//          }
//        }
//        return new int[]{c, s};
//        }
