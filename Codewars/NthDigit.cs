using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*The function findDigit takes two numbers as input, num and nth.It outputs the nth digit of num(counting from right to left).
       Note:
       If num is negative, ignore its sign and treat it as a positive value.
       If nth is not positive, return -1.
       Keep in mind that 42 = 00042. This means that findDigit(42, 5) would return 0.*/
    public static class NthDigit
    {
        public static int FindDigit(int num, int nth)
        {
            if (nth <= 0)
            {
                return -1;
            }
            char[] aschar = Math.Abs(num).ToString().Reverse().ToArray();

            if (nth<=aschar.Length)
            {
                return int.Parse(aschar[nth-1].ToString());
            }
            else
            {
                return 0;
            }
           
        }
    }
}
