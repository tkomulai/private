using System;
using System.Linq;


namespace Taulukkoharjoituksia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tee yksiulotteinen taulukko, jossa on luoteltu huonekalujen nimiä (esim. tuoli, sohva, pöytä, kaappi).
            //string[] huonekalut = new string[4];

            //huonekalut[0] = "tuoli";
            //huonekalut[1] = "sohva";
            //huonekalut[2] = "pöytä";
            //huonekalut[3] = "kaappi";

            //Tulosta koko taulukko, jokainen huonekalu omalle rivilleen.

            //for(int i=0; i<huonekalut.Length; i++)
            //{
            //    Console.WriteLine(huonekalut[i]);
            //}

            //Muuta tulostusta siten, että tulostat vain kahden ensimmäisen indeksin arvot.

            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine(huonekalut[i]);
            //}

            //Muuta tulostusta siten, että taulukosta etsitään esim. sohvaa ja jos sellainen löytyy, tulostetaan se.
            //for (int i = 0; i < huonekalut.Length; i++)
            //{
            //    if(huonekalut[i] == "sohva")
            //    {
            //        Console.WriteLine(huonekalut[i]);
            //    }

            //}

            //
            // Harjoitus 2
            //

            //Tee yksiulotteinen taulukko, jossa on viisi solua. Nimeä taulukko: heitetytNoppaluvut
            //int[] heitetytNoppaluvut = new int[5];

            //Random rnd = new Random();

            //for(int i = 0; i < heitetytNoppaluvut.Length; i++)
            //{
            //    //Arvo 5 numeroa ja sijoita ne taulukkoon
            //    heitetytNoppaluvut[i] = rnd.Next(1,7);

            //    //Tulosta koko taulukko konsoliin.
            //    Console.WriteLine(heitetytNoppaluvut[i]);
            //}

            ////Laske taulukon arvojen summa ja tulosta tulos konsoliin.
            //Console.WriteLine("Arvojen summa on " + heitetytNoppaluvut.Sum());
            ////Tulosta isoin silmäluku.
            //Console.WriteLine("Suurin luku on " + heitetytNoppaluvut.Max());


            // Harjoitus 3
            int[] lottonumerot = new int[7];
            Random rnd = new Random();
            int arvottunumero;

            for (int i = 0; i < lottonumerot.Length; i++)
            {
                do
                {
                    arvottunumero = rnd.Next(1, 36);
                } while (lottonumerot.Contains(arvottunumero));

                lottonumerot[i] = arvottunumero;

                Console.WriteLine((i + 1) + ". arvottu numero on " + lottonumerot[i]);
            }
        }
    };
}
