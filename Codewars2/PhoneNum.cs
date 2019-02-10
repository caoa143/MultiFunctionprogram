using System;
using System.Text.RegularExpressions;

using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Codewars2
{
    class PhoneNum
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            List<int> area = new List<int>();
            List<int> first3 = new List<int>();
            List<int> last4 = new List<int>();

            area.Add(numbers[0]); area.Add(numbers[1]); area.Add(numbers[2]);

            first3.Add(numbers[3]); first3.Add(numbers[4]); first3.Add(numbers[5]);

            last4.Add(numbers[6]); last4.Add(numbers[7]); last4.Add(numbers[8]); last4.Add(numbers[9]);

            string str1 = String.Join("",area);
            string str2 = String.Join("", first3);
            string str3 = String.Join("", last4);

            return "(" + str1 + ") " + str2 + "-" + str3;



        }
    }
}

//public static string CreatePhoneNumber(int[] numbers)
//{
//    return string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], numbers[5], numbers[6], numbers[7], numbers[8], numbers[9]);
//}
//(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"