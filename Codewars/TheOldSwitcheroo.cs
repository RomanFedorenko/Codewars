using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    //    Write a function Vowel2Index(string s)
    //that takes in a string and replaces all the vowels[a, e, i, o, u] with their respective positions within that string. 
    public static class TheOldSwitcheroo
    {
        public static string Vowel2Index(string str)
        {
           
            string vowels = "aeiou";
            
            for (int i = str.Length-1; i >=0; i--)
            {
                if (vowels.Contains(str[i]))
                {
                    str = str.Remove(i, 1).Insert(i, (i + 1).ToString());
                }
                 
            }

            return str;
        }

    }
}
