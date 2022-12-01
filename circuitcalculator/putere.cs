using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace circuitcalculator
{
    public class putere : unitatedemasura
    {
        public double P = 0;

        public putere() { }
        public putere(double x) { P = x; }

        public void calcP(double U, double I)
        {
            P = U * I;
        }

        public void calcP2(double U, double R)
        {
            P = (U*U)/R;
        }

        public void calcP3(double R, double I)
        {
            P = (I*I)*R;
        }

    }
}
