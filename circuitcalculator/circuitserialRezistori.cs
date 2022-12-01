using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace circuitcalculator
{
    public class circuitserialRezistori : circuitserial
    {
        public rezistor R1 = new rezistor();
        public rezistor R2 = new rezistor();

        public double calculeazaRezistentaSerieTotala()
        {
            return R1.r.R + R2.r.R;
        }

        public double calculeazaTensiuneaSerieTotala()
        {
            return R1.u.U + R2.u.U;
        }

        public double calculeazaCurentulSerieTotal()
        {
            return R1.i.I;
        }

        public double calculeazaTensiuneaU1()
        {
            return R2.u.U * (R1.r.R / (R1.r.R + R2.r.R));
        }

        public double calculeazaTensiuneaU2()
        {
            return R1.u.U * (R2.r.R / (R1.r.R + R2.r.R));
        }

        public double calculeazaPutereaSerieTotala()
        {
            return R1.p.P + R2.p.P;
        }

        public double calculeazaEnergiaSerieTotala()
        {
            return R1.e.E + R2.e.E;
        }


    }
}
