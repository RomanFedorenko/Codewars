using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*Your task is to make a function that can take any non-negative integer as a argument and return it with its digits in descending order.
          Essentially, rearrange the digits to create the highest possible number.
            Examples:
            Input: 21445 Output: 54421
            Input: 145263 Output: 654321
            Input: 1254859723 Output: 9875543221*/

    public static class DescendingOrderKata
    {
        public static int DescendingOrder(int num)
        {
            return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
        }
    }
}
