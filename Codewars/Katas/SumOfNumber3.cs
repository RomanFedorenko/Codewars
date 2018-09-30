using System;
using System.Collections.Generic;
using System.Linq;

namespace Codewars.Katas
{
    //    Given two integers a and b, which can be positive or negative, 
    //    find the sum of all the numbers between including them too and return it.
    //    If the two numbers are equal return a or b.

    //Note: a and b are not ordered!

    //Examples
    //GetSum(1, 0) == 1   // 1 + 0 = 1
    //GetSum(1, 2) == 3   // 1 + 2 = 3
    //GetSum(0, 1) == 1   // 0 + 1 = 1
    //GetSum(1, 1) == 1   // 1 Since both are same
    //GetSum(-1, 0) == -1 // -1 + 0 = -1
    //GetSum(-1, 2) == 2  // -1 + 0 + 1 + 2 = 2

   public static class SumOfNumber3
    {
        public static int GetSum(int a, int b)
        {        
            return Enumerable.Range(Math.Min(a, b),(Math.Max(a,b)-Math.Min(a,b))+1).Sum();
        }
    }
}
