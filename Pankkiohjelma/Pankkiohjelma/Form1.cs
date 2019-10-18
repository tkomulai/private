using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pankkiohjelma
{
    public partial class Form1 : Form
    {
        NostoIkkuna nosto = null;
        TalletusIkkuna talletus = null;

        public Form1()
        {
            InitializeComponent();
            nosto = new NostoIkkuna();
            talletus = new TalletusIkkuna();

            double saldo = LueSaldo();
            label1.Text = "Tilin saldo: " + saldo + " euroa";

            button1.Click += AvaaNosto;
            button2.Click += AvaaTalletus;
        }

        private void AvaaNosto(object sender, EventArgs e)
        {
            if (nosto.IsDisposed)
            {
                nosto = new NostoIkkuna();
            }
            nosto.Show();
        }
        private void AvaaTalletus(object sender, EventArgs e)
        {
            if (talletus.IsDisposed)
            {
                talletus = new TalletusIkkuna();
            }
            talletus.Show();
        }
        public static double LueSaldo()
        {
            string filename = "C:/temp/saldo.txt";
            StreamReader sr = new StreamReader(filename);
            double saldo = Double.Parse(sr.ReadLine());
            sr.Close();
            return saldo;
        }
        public static void KirjoitaSaldo(double saldo)
        {
            string filename = "C:/temp/saldo.txt";
            StreamWriter sw = new StreamWriter(filename);
            sw.WriteLine(saldo);
            sw.Close();
        }
    }
}
