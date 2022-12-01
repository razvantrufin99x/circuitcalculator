using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace circuitcalculator
{
    public class energie : unitatedemasura
    {
        public double E = 0;

        public energie() { }
        public energie(double x) { E = x; }

        public void calcE(double P, double t)
        {
            E = P * t;
        }
    }
    
}
