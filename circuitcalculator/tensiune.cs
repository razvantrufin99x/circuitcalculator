using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace circuitcalculator
{
    public class tensiune : unitatedemasura
    {
        public double U = 0;

        public tensiune() { }
        public tensiune(double x) { U = x; }

        public void calcU(double R, double I)
        {
            U = R * I;
        }
    }
}
