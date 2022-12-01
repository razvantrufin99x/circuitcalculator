using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace circuitcalculator
{
    public class rezistenta : unitatedemasura
    {
        public double R = 0;

        public rezistenta() { }
        public rezistenta(double x) { R = x; }
        
        public void calcR(double U, double I)
        {
            R = U / I;
        }


    }
}
