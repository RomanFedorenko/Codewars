using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*Parse and count numbers in string
      str = "Enter number: @" or "Enter answer: @+@" or "Enter answer: @-@"
      @ = any number*/

    public static class ParseAndCount
    {
        public static int PaC(string str)
        {
            string ext = str.Substring(str.LastIndexOf(":") + 1).Trim(' ');
            if (str.Contains("number"))
            {
               return Int32.Parse(ext);
            }
            int[] numbers = Array.ConvertAll(ext.Split('+', '-'), Int32.Parse);
            return ext.Contains("+") ? numbers[0] + numbers[1] : numbers[0] - numbers[1];
                       
        }
    }
}
