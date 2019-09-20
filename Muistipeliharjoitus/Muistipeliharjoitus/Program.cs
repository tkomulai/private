using System;
using System.Linq;
using System.Threading;

namespace Muistipeliharjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] oikeatNumerot = new int[7];
            int[] arvatutNumerot = new int[7];
            string kayttajanarvaus;
            int oikeatvastaukset = 0;

            Random rnd = new Random();
            Console.WriteLine("Yritä muistaa alla olevat numerot. Näet numerot 5 sekunnin ajan.");
            
            for (int i = 0; i < oikeatNumerot.Length; i++)
            {
                //Arvo 5 numeroa ja sijoita ne taulukkoon
                oikeatNumerot[i] = rnd.Next(1, 8);

                //Tulosta koko taulukko konsoliin.
                Console.Write(oikeatNumerot[i] + " ");
           
            }
            // Odota 5000ms 
            Thread.Sleep(5000);
            Console.Clear();
            
            for (int i = 0; i < arvatutNumerot.Length; i++)
            {
                Console.WriteLine("Syötä " + (i + 1) + ". numero");
                kayttajanarvaus = Console.ReadLine();
                arvatutNumerot[i] = int.Parse(kayttajanarvaus);
            }
            Console.Write("Arvauksesi: ");
            foreach (int arvaus in arvatutNumerot)
            {
                Console.Write(" " + arvaus);
            }
            Console.WriteLine();
            Console.Write("Oikea rivi: ");
            foreach (int oikea in oikeatNumerot)
            {
                Console.Write(" " + oikea);
            }
            for (int i = 0; i < oikeatNumerot.Length; i++)
            {
                if(arvatutNumerot[i] == oikeatNumerot[i])
                {
                    oikeatvastaukset++;
                }
            }
            double oikeatprosentti = oikeatvastaukset * 100 / oikeatNumerot.Length;
            Console.WriteLine();
            Console.WriteLine("Oikeita vastauksia oli: " + oikeatvastaukset + "(" + oikeatprosentti + "%)");

        }
    }
}
