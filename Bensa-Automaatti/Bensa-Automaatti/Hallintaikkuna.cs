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
    public partial class Hallintaikkuna : Form
    {
        // Alustetaan timer, jolla päivitetään hallintaikkuna
        System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();
        TilausIkkuna tilaus = null;

        public Hallintaikkuna()
        {
            InitializeComponent();

            // Alustetaan TilausIkkuna
            tilaus = new TilausIkkuna();

            // Määritetään, että Tilaa-napista aukeaa TilausIkkuna
            Tilaa_lisaa_nappi.Click += AvaaTilausIkkuna;

            // Päivitetään hallintaikkuna sekunnin välein
            _timer.Interval = 1000;
            _timer.Tick += PaivitaTankit;
            _timer.Start();

        }

        private void AvaaTilausIkkuna(object sender, EventArgs e)
        {
            if (tilaus.IsDisposed)
            {
                tilaus = new TilausIkkuna();
            }
            tilaus.Show();
        }

        // Luetaan tiedostosta tankin tilanne, käyttäen tyyppi-parametriä
        public static int LueTankki(string tyyppi)
        {

            string filename = "C:/temp/" + tyyppi + ".txt";
            StreamReader sr = new StreamReader(filename);
            int tankkistatus = int.Parse(sr.ReadLine());
            sr.Close();
            return tankkistatus;
        }

        // Metodi, jolla päivitetään tankkien status + värit + mahdollinen tilausnappi
        void PaivitaTankit(object sender, EventArgs e)
        {
            string diesel = "diesel";
            string ysiviis = "ysiviis";
            string ysikasi = "ysikasi";

            diesel_bar.Value = LueTankki(diesel);
            ysiviis_bar.Value = LueTankki(ysiviis);
            ysikasi_bar.Value = LueTankki(ysikasi);

            ysiviis_varoitus.Text = ysiviis_bar.Value + " / 100";
            ysikasi_varoitus.Text = ysikasi_bar.Value + " / 100";
            diesel_varoitus.Text = diesel_bar.Value + " / 100";

            if (ysiviis_bar.Value < 50 && ysiviis_bar.Value > 10)
            {
                ysiviis_bar.ForeColor = System.Drawing.Color.Yellow;
                ysiviis_varoitus.ForeColor = System.Drawing.Color.Yellow;
            }
            else if (ysiviis_bar.Value < 10)
            {
                ysiviis_bar.ForeColor = System.Drawing.Color.Red;
                ysiviis_varoitus.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                ysiviis_bar.ForeColor = System.Drawing.Color.Green;
                ysiviis_varoitus.ForeColor = System.Drawing.Color.Green;
            }

            if (ysikasi_bar.Value < 50 && ysikasi_bar.Value > 10)
            {
                ysikasi_bar.ForeColor = System.Drawing.Color.Yellow;
                ysikasi_varoitus.ForeColor = System.Drawing.Color.Yellow;
            }
            else if (ysikasi_bar.Value < 10)
            {
                ysikasi_bar.ForeColor = System.Drawing.Color.Red;
                ysikasi_varoitus.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                ysikasi_bar.ForeColor = System.Drawing.Color.Green;
                ysikasi_varoitus.ForeColor = System.Drawing.Color.Green;
            }

            if (diesel_bar.Value < 50 && diesel_bar.Value > 10)
            {
                diesel_bar.ForeColor = System.Drawing.Color.Yellow;
                diesel_varoitus.ForeColor = System.Drawing.Color.Yellow;
            }
            else if (diesel_bar.Value < 10)
            {
                diesel_bar.ForeColor = System.Drawing.Color.Red;
                diesel_varoitus.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                diesel_bar.ForeColor = System.Drawing.Color.Green;
                diesel_varoitus.ForeColor = System.Drawing.Color.Green;
            }

            if (diesel_bar.Value < 10 || ysiviis_bar.Value < 10 || ysikasi_bar.Value < 10)
            {
                Tilaa_lisaa_nappi.Visible = true;
            }
        }
    }
}
