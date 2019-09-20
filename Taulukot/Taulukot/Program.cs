using System;
using System.Linq; // saadaan apuja taulukon tietojen käsittelyyn

namespace Taulukot
{
    class Program
    {
        static void Main(string[] args)
        {
            //int luku = 3;
            //Console.WriteLine(luku);

            // 6-soluisen taulukon alustus, joka sisältää 
            int[] opiskelijoidenIat = new int[6];

            //opiskelijoidenIat[0] = 45;
            //opiskelijoidenIat[1] = 19;
            //opiskelijoidenIat[2] = 20;
            //opiskelijoidenIat[3] = 40;
            //opiskelijoidenIat[4] = 31;
            //opiskelijoidenIat[5] = 30;

            // jos arvotaan, haetaan tietokannasta, kysytään käyttäjältä, käytetään for-loopia

            Random rnd = new Random();

            //opiskelijoidenIat[0] = rnd.Next(24, 50);
            //opiskelijoidenIat[1] = rnd.Next(24, 50);
            //opiskelijoidenIat[2] = rnd.Next(24, 50);
            //opiskelijoidenIat[3] = rnd.Next(24, 50);
            //opiskelijoidenIat[4] = rnd.Next(24, 50);
            //opiskelijoidenIat[5] = rnd.Next(24, 50);


            for (int i = 0; i < opiskelijoidenIat.Length; i++)
            {
                opiskelijoidenIat[i] = rnd.Next(24, 50);
            }

           // Koko taulukon tulostus
                for (int i = 0; i < opiskelijoidenIat.Length; i++)
                {
                    //if (opiskelijoidenIat[i] >= 30)
                    //{
                    Console.WriteLine(opiskelijoidenIat[i]);
                    //}


                }

            Console.WriteLine("Ikien keskiarvo " + opiskelijoidenIat.Average());
            Console.WriteLine("Vanhin opiskelija on iältään " + opiskelijoidenIat.Max());
        }
    }
}
