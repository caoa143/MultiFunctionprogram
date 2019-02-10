using System;
using System.Text.RegularExpressions;

using System.Collections.Generic;
using System.Text;
using System.Linq;

//public void Insert (int index, T item);  > listname.Insert(index, obj)
namespace Codewars2
{
    class Rank
    {
        public static int[] RankNums(int[] nums) // [8,5,7,2]  higher num, higher points
        {                                        //[8 7 5 2 _ _]
            List<int> places = new List<int>();
            List<int> rankings = new List<int>();
            int stepB = 1;
            places.Add(nums.Max());
             foreach(int y in places)
            {
                
                {
                    for (int i = 1; i < nums.Length; i++)
                        while (nums[i] <= y )
                    {
                        
                        if (places.Count >= 2)
                        {
                            //if( places.Contains())
                            places.Insert(places.IndexOf(y) - 1, nums[i]);

                        }
                        if (places.Count == 1)
                        {
                            places.Add(nums[i]);
                            //stepB=stepB + 1;
                        }
                        
                        
                        if (places.Count > i)
                        {
                            break;
                        }
                    }
                    //if (places.Count > i)
                    {
                        break;
                    }
                }
            }

            foreach (int z in nums)
            {
                rankings.Add(places.IndexOf(z)+1);
            }
            return rankings.ToArray();
        }
    }
}


//input // [1,3,2] 
//output // [3,1,2]