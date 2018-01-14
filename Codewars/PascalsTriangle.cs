using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
   // Write a function that, given a depth(n), returns a single-dimensional array representing Pascal's Triangle to the n-th level.
    public static class PascalsTriangle
    {

        public static List<int> PascalTriangle(int n)
        {

            List<int> numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < i + 1; j++)
                {
                    BigInteger element = factorial(i) / (factorial(j) * factorial(i - j));
                    numbers.Add((int)element);
                    
                }

            }
            return numbers;
        }


        public static BigInteger factorial(int num)
        {
            BigInteger fact = 1;
            for (int i = num; i > 0; i--)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
