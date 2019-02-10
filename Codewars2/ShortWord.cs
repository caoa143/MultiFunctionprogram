using System;
using System.Text.RegularExpressions;

using System.Collections.Generic;
using System.Text;
using System.Linq;



namespace Codewars2
{
    class ShortWord
    {
        public static int FindShort(string s)
        {
            List<int> lengthList = new List<int>();

            string[] splitArr = s.Split(" ");
            foreach(string word in splitArr)
            {
                lengthList.Add(word.Length);

            }

            
            return lengthList.Min();
        }

        public static string WhichShort( string sent) //{zzzz aa bbb ccc dddd eeeee}
        {
            string smallWord = "";
            int smallIndx = 0;
            int valueCount = 0;
            List<int> lenVals = new List<int>();
            string[] splitarr2 = sent.Split(" ");

            for( int i=0; i < splitarr2.Length ; i++)
            {
                lenVals.Add(splitarr2[i].Length);    // [4 2 3 3 4 5]
                
            }

           smallIndx= lenVals.IndexOf(lenVals.Min()); //************** great

            return splitarr2[smallIndx]; //works 
        }
    }
}

//What is the shortest word