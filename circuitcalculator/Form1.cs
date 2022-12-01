using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace circuitcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rezistor r1 = new rezistor();
            rezistor r2 = new rezistor();
            r1.r.R = 25;
            r1.i.I = 0.5;
            r1.u.calcU(r1.r.R, r1.i.I);
            r2.r.R = 30;
            r2.i.I = 0.5;
            r2.u.calcU(r2.r.R, r2.i.I);
            

            circuitserialRezistori csr12 = new circuitserialRezistori();
            csr12.R1 = r1;
            csr12.R2 = r2;

            double rst12 = csr12.calculeazaRezistentaSerieTotala();
            Text = rst12.ToString();
            Text += " ";
            double ust12 = csr12.calculeazaTensiuneaSerieTotala();
            Text += ust12.ToString();
            Text += " ";
            Text += r1.i.I.ToString(); 


            //


            Text += " ";


            //


            rezistor r3 = new rezistor();
            rezistor r4 = new rezistor();
            r3.r.R = 25;
            r3.i.I = 0;
            r3.u.U = 27.5;
            r4.r.R = 30;
            r4.i.I = 0;
            r4.u.U = 27.5;

            r3.i.calcI(r3.u.U, r3.r.R);
            r4.i.calcI(r4.u.U, r4.r.R);

            circuitparalelRezistori cpr34 = new circuitparalelRezistori();
            cpr34.R1 = r3;
            cpr34.R2 = r4;

            r3.i.I = cpr34.calculeazaCurentulI1();
            r4.i.I = cpr34.calculeazaCurentulI2();


            double rpt34 = cpr34.calculeazaRezistentaParalelaTotala();
            Text += rpt34.ToString();
            Text += " ";


            double ipt34 = cpr34.calculeazaCurentulParalelTotal();
            Text += ipt34.ToString();
            Text += " ";
            Text += r3.i.I.ToString(); 
            Text += " ";
            Text += r4.i.I.ToString(); 
            Text += " ";
            Text += (r3.i.I + r4.i.I).ToString(); 

        }
    }
}
