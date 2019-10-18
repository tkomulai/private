using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bensa_Automaatti
{
    public partial class Paaformi : Form
    {
        Hallintaikkuna hallinta = null;

        public Paaformi()
        {
            InitializeComponent();
            hallinta = new Hallintaikkuna();
  
            Hallintapaneeli_button.Click += AvaaHallintaPaneeli;

        }

        // Avataan hallintaikkuna jos tunnus + salasana on oikein
        // Täytetään labeliin mahdollinen virhetilanne ja tyhjennetään textboxit
        private void AvaaHallintaPaneeli(object sender, EventArgs e)
        {
            string username = tunnus_textbox.Text;
            string password = salasana_textbox.Text;

            if (username != "" || password != "")
            {

                if (CheckCreds(username, password))
                {
                    if (hallinta.IsDisposed)
                    {
                        hallinta = new Hallintaikkuna();
                    }
                    hallinta.Show();
                    tunnus_textbox.Text = String.Empty;
                    salasana_textbox.Text = String.Empty;
                    error_label.Text = "";

                }
                else
                {
                    tunnus_textbox.Text = String.Empty;
                    salasana_textbox.Text = String.Empty;
                    error_label.Text = "Användarnamn eller lösenord är fel!";
                    error_label.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                error_label.Text = "Fyll båda data";
                error_label.ForeColor = System.Drawing.Color.Red;
            }
        }

        // Tarkistetaan tiedostosta tunnus + salasana
        // Haetaan GetMD5Hash-funktiolta hash syötetystä salasanasta ja verrataan tekstitiedostossa olevaan
        public static bool CheckCreds(string username, string password)
        {
            using (StreamReader sr = new StreamReader("C:\\temp\\creds.txt"))
            {
                bool userok = false;
                while (sr.Peek() >= 0 && userok != true)
                {
                    string s = sr.ReadLine();
                    string[] ss = s.Split(',');
                    string fileusername = ss[0];
                    string filepassword = ss[1];

                    if (fileusername == username && filepassword == GetMD5Hash(password))
                    {
                        userok = true;
                    }

                }
                if (userok)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        // Palautetaan syötetystä stringistä luotu MD5 Hash
        // Hashissa mukana salt
        public static string GetMD5Hash(string password)
        {
            string suola = "QY0z#`K+.;@Eck0Kh5G";
            password = suola + password + suola;
            MD5CryptoServiceProvider md5Kryptaaja = new MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.ASCII.GetBytes(password);
            data = md5Kryptaaja.ComputeHash(data);

            // Tehdään data[]-taulukosta string-merkkijono
            string md5tiiviste = "";
            for (int i = 0; i < data.Length; i++)
                md5tiiviste += data[i].ToString("x2").ToLower();
            return md5tiiviste;
        }
    }
}
