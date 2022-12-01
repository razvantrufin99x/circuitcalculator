using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace circuitcalculator
{
    public class circuitparalelRezistori:circuitparalel
    {
        public rezistor R1 = new rezistor();
        public rezistor R2 = new rezistor();

        public double calculeazaRezistentaParalelaTotala()
        {
            return (R1.r.R * R2.r.R) / (R1.r.R + R2.r.R);
        }

        public double calculeazaTensiuneaParalelaTotala()
        {
            return R1.u.U ;
        }

        public double calculeazaCurentulParalelTotal()
        {
            return R1.i.I + R2.i.I;
        }

        public double calculeazaCurentulI1()
        {
            return R2.i.I * (R2.r.R/( R1.r.R + R2.r.R));
        }

        public double calculeazaCurentulI2()
        {
            return R1.i.I * (R1.r.R / (R1.r.R + R2.r.R));
        }

        public double calculeazaPutereaParalelaTotala()
        {
            return R1.p.P + R2.p.P;
        }

        public double calculeazaEnergiaParalelaTotala()
        {
            return R1.e.E + R2.e.E;
        }
    }
}
