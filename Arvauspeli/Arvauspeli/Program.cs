using System;

namespace Arvauspeli
{
    class Program
    {
        static void Main(string[] args)
        {
            string nimi = "Pekka";
            string arvaus;
            int arvaukset = 0;
            Console.WriteLine("Arvaa nimi tai kirjoita \"loppu\" lopettaaksesi");
            do
            {
                arvaukset++;
                arvaus = Console.ReadLine();
                if (arvaus == nimi)
                {
                    Console.WriteLine("Onneksi olkoon! Oikea vastaus oli " + nimi + ". Arvasit " + arvaukset + " kertaa");
                    break;
                }
                if(arvaus == "loppu")
                {
                    Console.WriteLine("Peli loppuu");
                    break;
                }
                Console.WriteLine("Väärin, koeta uudestaan");
            } while (arvaus != nimi);
        }
    }
}
