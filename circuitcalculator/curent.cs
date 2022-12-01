using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace circuitcalculator
{
    public class curent : unitatedemasura
    {
        public double I = 0;

        public curent() { }
        public curent(double x) { I = x; }

        public void calcI(double U, double R)
        {
            I = U / R;
        }
    
    }
}
