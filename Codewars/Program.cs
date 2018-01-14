using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = PascalsTriangle.PascalTriangle(20);

            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            // Console.WriteLine(TheOldSwitcheroo.Vowel2Index("this is my string"));
        
            Console.ReadKey();
        }
    }
}
