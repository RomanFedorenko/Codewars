using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public static class PopulationGrowth
    {
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            double currentPop = p0 ;
            int years = 0;
            while (p > currentPop)
            {
                currentPop += Math.Floor(currentPop * (percent / 100))+ aug;           
                years++;
            }
            return years;
        }
    }
}
