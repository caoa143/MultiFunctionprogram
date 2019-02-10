using System;
using System.Text.RegularExpressions;

using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Codewars2
{
    class Program
    {

       
        static void Main(string[] args)
        {
            string[] input = { "NORTH", "WEST", "SOUTH", "EAST" };
            //Console.WriteLine(ClockAng.CAngle(10, 20));
            Console.WriteLine(GenCode.dirReduc(input));

            Console.ReadLine();




        }
    }
}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine(TwiceOld.TwiceAsOld(30, 7));
//        Console.ReadLine();

//    }
//}
