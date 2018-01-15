using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*Triangular numbers are so called because of the equilateral triangular shape that they occupy when laid out as dots.i.e.

            1st(1)   2nd(3)    3rd(6)
            *        **        ******
                     *         ***
                               *
    You need to return the nth triangular number.You should return 0 for out of range values:*/
    public static class TriangularTreasure
    {

        public static int Triangular(int n)
        {
                     
            return n>0 ? (n * (n + 1)) / 2 : 0;

        }
    }
}
