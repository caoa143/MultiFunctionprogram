using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars2
{
    class Prime
    {
        public static bool IsPrime(int n)
        {
           
                if (n < 2)
                    return false;
                if (n == 2)
                    return true;
                if (n % 2 == 0)
                    return false;
                for (int i = 3; i * i <= n; i +=2) //why =2? (i+=2) becuase it skips even numbers which are all unPrime
                {
                //(IMPPORTANT ...START AT 3)
                    if (n % i == 0)
                        return false;
                }
                return true;
            
        }

        //PRINT EVERY NUMBER UP UNTIL X

        public static void PrintPrime(int x)
        {
            List<int> output = new List<int>();
            for (int i = 0; i <= x; i++)
            {
                if (Prime.IsPrime(i) == true)
                {
                    output.Add(i);
                }
            }


            foreach (int num in output)
            {
                Console.WriteLine(num);
            }

        }
    }
}
