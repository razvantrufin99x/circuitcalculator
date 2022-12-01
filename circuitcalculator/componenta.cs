using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace circuitcalculator
{
    public class componenta
    {
        public List<unitatedemasura> unitatidemasura = new List<unitatedemasura>();
        public List<pin> pini = new List<pin>();

        public pin pinA = new pin();
        public pin pinB = new pin();

        public rezistenta r = new rezistenta();
        public tensiune u = new tensiune();
        public curent i = new curent();
        public putere p = new putere();
        public energie e = new energie();


    }
}
