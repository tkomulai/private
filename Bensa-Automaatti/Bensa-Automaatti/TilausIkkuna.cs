using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bensa_Automaatti
{
    public partial class TilausIkkuna : Form
    {
        public TilausIkkuna()
        {
            InitializeComponent();
            
            Tilausnappi.Click += TeeTilaus;
            sulje_nappi.Click += SuljeIkkuna;
        }

        private void SuljeIkkuna(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TeeTilaus(object sender, EventArgs e)
        {
            try
            {
                int maara = int.Parse(maara_updown.Value.ToString());

                if (maara > 0)
                {
                    if (diesel_box.Checked == true)
                    {
                        string tyyppi = "diesel";
                        if(PaivitaTankki(tyyppi, maara))
                        {
                            viesti_label.Text = "Du har beställt " + maara + " liter dieselolja.";
                            viesti_label.ForeColor = System.Drawing.Color.Green;
                        }
                        else
                        {
                            MessageBox.Show("Mängden kan inte bli större än tankens volym (100L)");
                        }
                    }

                    if (ysiviis_box.Checked == true)
                    {
                        string tyyppi = "ysiviis";
                        if (PaivitaTankki(tyyppi, maara))
                        {
                            viesti_label.Text = "Du har beställt " + maara + " liter 95 oktan.";
                            viesti_label.ForeColor = System.Drawing.Color.Green;
                        }
                        else
                        {
                            MessageBox.Show("Mängden kan inte bli större än tankens volym (100L)");
                        }
                    }

                    if (ysikasi_box.Checked == true)
                    {
                        string tyyppi = "ysikasi";
                        if (PaivitaTankki(tyyppi, maara))
                        {
                            viesti_label.Text = "Du har beställt " + maara + " liter 98 oktan.";
                            viesti_label.ForeColor = System.Drawing.Color.Green;
                        }
                        else
                        {
                            MessageBox.Show("Mängden kan inte bli större än tankens volym (100L)");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Fyll i mängde som du vilja att beställa.");
                }
            }
            catch (Exception err)
            { }
        }
        // Lisätään tankkiin tilattu määrä. Tarkistetaan, ettei uusi määrä ole suurempi kuin tilavuus (100L)
        // Kirjataan tilaus tilaukset.txt -tiedostoon
        public static bool PaivitaTankki(string tyyppi, int maara)
        {
            int vanhamaara = Hallintaikkuna.LueTankki(tyyppi);
            int uusimaara = vanhamaara + maara;
            if (uusimaara <= 100)
            {
                string filename = "C:/temp/" + tyyppi + ".txt";
                StreamWriter sw = new StreamWriter(filename);
                sw.WriteLine(uusimaara);
                sw.Close();
                KirjaaTilaus(tyyppi, maara);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void KirjaaTilaus(string tyyppi,int maara)
        {
            DateTime timestamp = DateTime.Now;
            string kirjaus = timestamp + "," + tyyppi + "," + maara + "L";
            string filename = "C:/temp/tilaukset.txt";
            StreamWriter sw = new StreamWriter(filename,true);
            sw.WriteLine(kirjaus);
            sw.Close();
        }
    }
}
