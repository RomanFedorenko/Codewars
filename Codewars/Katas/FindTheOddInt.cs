using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars.Katas
{
    public static class FindTheOddInt
    {
        // Given an array, find the int that appears an odd number of times.
        // There will always be only one integer that appears an odd number of times.
        public static int find_it(int[] seq)
        {            
            return seq.FirstOrDefault(x => seq.Count(y => y == x) % 2 != 0);
        }
    }
}
