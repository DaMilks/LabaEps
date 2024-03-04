using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaEps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPlot_Click(object sender, EventArgs e)
        {
            double A=Convert.ToDouble(textBoxA.Text);
            double B=Convert.ToDouble(textBoxB.Text);
            double T=Convert.ToDouble(textBoxT.Text);
            double E8=Convert.ToDouble(textBoxE8.Text);
            double Es = Convert.ToDouble(textBoxEs.Text);

            double omega, Re, Im, phi, mod, eps1, eps2;
            for(double f=0;f<2/T;f+=1)
            {
                omega = Math.PI * 2 * f;
                Re = 1 - Math.Pow(omega * T, 1 - A) * Math.Cos(Math.PI / 2 * (1 - A));
                Im = -Math.Pow(omega * T, 1 - A) * Math.Sin(Math.PI / 2 * (1 - A));
                mod = Math.Pow(Re * Re + Im + Im, B / 2);
                phi = Math.Atan(Im / Re);
                eps1 = E8 + ((Es - E8) / mod) * Math.Cos(-phi * B);
                eps2= Es - (Es - E8) / mod * Math.Sin(-phi * B);
                chartE1F.Series[0].Points.Add(f, eps1);
                chartE2F.Series[0].Points.Add(f, eps2);
                chartE2E1.Series[0].Points.Add(eps1, eps2);
                textBox1.Text += $"{f} {eps1} \n";
            }
        }
    }
}
