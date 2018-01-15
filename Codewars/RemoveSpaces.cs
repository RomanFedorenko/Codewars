using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    // Simple, remove the spaces from the string, then return the resultant string.
    public static class RemoveSpaces
    {
        public static string NoSpace(string input)
        {
            return input.Replace(" ", string.Empty);
        }
    }
}
