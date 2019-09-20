using System;

namespace Funktioharjoituksia
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Tee funktio nimeltä TulostaOtsikko. Funktion tulee tulostaa esim. Seuraavanlainen otsikko. 
            // TulostaOtsikko();

            // 2. Tee funktio, jossa on taulukko tai lista, jossa on neljä sananlaskua. Funktio arpoo sananlaskuista yhden ja tulostaa sen konsoliin. 
            // Funktiota kutsuttaessa ei siis välitetä mitään parametreja. Kutsu funktiota kerran
            // KerroSananLasku();

            // 3. Tee funktio nimeltä "KerroIsoin", joka saa kaksi numeerista parametria ja tulostaa niistä isoimman. Tutki funktiossa isoin arvo vaikka if-lauseen avulla. 
            // Kutsu funktiota kaksi kertaa eri parametrein
            //KerroIsoin("1", "3");
            //KerroIsoin("4", "3");
            //KerroIsoin("3", "3");

            // 4. Tee funktio nimeltä "KerroIsoin", joka saa kaksi numeerista parametria ja tulostaa niistä isoimman. Tutki funktiossa isoin arvo vaikka if-lauseen avulla. 
            // Kutsu funktiota kaksi kertaa eri parametrein
            //int suurin = KerroIsoin2("3", "5");
            //Console.WriteLine("Suurin luku on " + suurin);

            // 5. Tee funktio MuotoileLause, joka saa kaksi parametria: nimi ja pituus. Funktio tulostaa seuraavasti, jos parametrit olivat “Justin” ja 180:
            // "Justin on 180 cm pitkä"
            //MuotoileLause("Justin", 180);

            // 6. Tee funktio LaskeIka. Funktio saa syntymävuoden ja nykyisen vuoden parametreina. Funktio palauttaa iän. Tulosta ikä funktiota käyttäen konsoliin. 
            // Kysy käyttäjältä Mainissa syntymävuosi ja kuluva vuosi, ja kutsu tämän jälkeen funktiota
            //int ika = LaskeIka(1985, 2019);
            //Console.WriteLine("Ikä on " + ika + " vuotta.");

            // 7. Jatka edellistä kohtaa. Tee main-lohkoon if-lause, joka tutkii, onko käyttäjä yli 18-vuotta käyttäen LaskeIka-funktiota. 
            // Jos on, tulosta konsoliin "olet täysikäinen", jos ei ole, tulosta "olet alaikäinen". 
            //int ika = LaskeIka(2015, 2019);
            //if(ika >= 18)
            //{
            //    Console.WriteLine("Olet täysi-ikäinen.");
            //}
            //else
            //{
            //    Console.WriteLine("Olet alaikäinen");
            //}

            // 8. Muuta ensimmäisessä kohdassa tehtyä sananlasku-funktiota siten, että funktio ei tulosta sananlaskua, vaan sananlasku palautetaan. Tulosta sananlaskua funktiota käyttäen.
            string sananlasku = KerroSananLasku();
            Console.WriteLine(sananlasku);
        }

        public static void TulostaOtsikko()
        {
            Console.WriteLine("************************");
            Console.WriteLine("* Funktio-harjoituksia *");
            Console.WriteLine("************************");
        }

        // Tee funktio, jossa on taulukko tai lista, jossa on neljä sananlaskua.Funktio arpoo sananlaskuista yhden ja tulostaa sen konsoliin.
        // Funktiota kutsuttaessa ei siis välitetä mitään parametreja. Kutsu funktiota kerran.

        public static string KerroSananLasku()
        {
            string[] sananlaskut = new string[4];
            sananlaskut[0] = "Parempi pyy pivossa kuin 10 oksalla";
            sananlaskut[1] = "Lähti kuin talonmies jäiseltä peltikatolta";
            sananlaskut[2] = "Lähti kuin hauki rannasta";
            sananlaskut[3] = "Lähti kuin purkka tukasta";

            Random rnd = new Random();
            int luku = rnd.Next(0, 4);
            // Console.WriteLine(sananlaskut[luku]);
            return sananlaskut[luku];
        }

        // Tee funktio nimeltä "KerroIsoin", joka saa kaksi numeerista parametria ja tulostaa niistä isoimman.
        // Tutki funktiossa isoin arvo vaikka if-lauseen avulla.Kutsu funktiota kaksi kertaa eri parametrein.

        public static void KerroIsoin(string luku1, string luku2)
        {
            int ekaluku = int.Parse(luku1);
            int tokaluku = int.Parse(luku2);

            if (ekaluku > tokaluku)
            {
                Console.WriteLine("Luku " + ekaluku + " on suurempi kuin " + tokaluku);
            }
            else if(tokaluku > ekaluku)
            {
                Console.WriteLine("Luku " + tokaluku + " on suurempi kuin " + ekaluku);
            }
            else
            {
                Console.WriteLine("Luvut " + ekaluku + " ja " + tokaluku + " ovat yhtä suuria.");
            }
        }

        // Kopioi yllä tehty funktio KerroIsoin2-nimiseksi. Muuta funktiota siten, että funktio palauttaa isoimman numeron. Tulosta konsoliin funktiota käyttäen isompi numero. 
        public static int KerroIsoin2(string luku1, string luku2)
        {
            int ekaluku = int.Parse(luku1);
            int tokaluku = int.Parse(luku2);

            if (ekaluku > tokaluku)
            {
                return ekaluku;
            }
            else 
            {
                return tokaluku;
            }
        }

        public static void MuotoileLause(string nimi, int pituus)
        {
            Console.WriteLine(nimi + " on " + pituus + " cm pitkä.");
        }

        public static int LaskeIka(int syntymavuosi, int nykyvuosi)
        {
            int ika = nykyvuosi - syntymavuosi;
            return ika;
        }
    }
}
