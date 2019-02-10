using System;
using System.Text.RegularExpressions;

using System.Collections.Generic;
using System.Text;
using System.Linq;



namespace Codewars2
{
    class GenCode
    {
        public static string[] dirReduc(String[] arr)
        {
            List<string> arrL = arr.ToList();
            int repC = 0;
            int repLimit = arr.Length;
            while (repC != repLimit)
            {
                if (arrL.Count == 1)
                {
                    break;
                }

                for (int i = 0; i < arr.Length - 1; i++)
                //{"NORTH", "WEST", "SOUTH", "EAST"}
                {
                    if (arrL.Count == 1)
                    {
                        break;
                    }
                    if (arrL.Count == 0)
                    {
                        string[] none = { };
                        return none;
                    }
                    if (arrL[i] == "NORTH" && arrL[i + 1] == "SOUTH")
                    {
                        arrL.Remove(arrL[i]); arrL.Remove(arrL[i]);
                        repC += 1;
                        break;
                    }
                    if (arrL[i] == "SOUTH" && arrL[i+1] == "NORTH")
                    {
                        arrL.Remove(arrL[i]); arrL.Remove(arrL[i]);
                        repC += 1;
                        break;
                    }
                    if (arrL[i] == "EAST" && arrL[i+1] == "WEST")
                    {
                        arrL.Remove(arrL[i]); arrL.Remove(arrL[i]);
                        repC += 1;
                        break;
                    }
                    if (arrL[i] == "WEST" && arrL[i+1] == "EAST")
                    {
                        arrL.Remove(arrL[i]); arrL.Remove(arrL[i]);
                        repC += 1;
                        break;
                    }
                    repC += 1;
                    if (repC ==repLimit)
                    {
                        return arrL.ToArray();
                    }
                }
                repC += 1;
            }

            return arrL.ToArray();
        }
    }
}

//{"NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST"};
//{ "WEST" };