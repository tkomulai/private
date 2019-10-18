using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pankkiohjelma
{
    public partial class NostoIkkuna : Form
    {
        public NostoIkkuna()
        {
            InitializeComponent();
            double saldo = Form1.LueSaldo();
            label2.Text = "Tilin saldo: " + saldo + " euroa";
            button1.Click += TeeNosto;
        }

        private void TeeNosto(object sender, EventArgs e)
        {
            try
            {
                if (numericUpDown1.Value != 0)
                {
                    double nykysaldo = Form1.LueSaldo();
                    double nostosumma = Double.Parse(numericUpDown1.Value.ToString());
                    double uusisaldo = nykysaldo - nostosumma;
                    if (uusisaldo >= 0)
                    {
                        Form1.KirjoitaSaldo(uusisaldo);
                        numericUpDown1.Text = String.Empty;
                        label3.Text = "Nostettu " + nostosumma + " euroa";
                        label3.ForeColor = label3.ForeColor = System.Drawing.Color.Green;
                        label2.Text = "Tilin saldo: " + uusisaldo + " euroa";
                    }
                    
                    else
                    {
                        label3.Text = "Tilillä ei riittävästi katetta!";
                        label3.ForeColor = label3.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
            catch (Exception err)
            { }
        }

    }
}
