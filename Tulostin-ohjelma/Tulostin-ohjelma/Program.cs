using System;

namespace Tulostin_ohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekija = "Teemu Komulainen";
            int pisteet;
            pisteet = 0;

            Console.WriteLine("Pelihahmo keräsi omenan, josta saa 10 pistettä");

            pisteet = pisteet + 10;
            Console.WriteLine("Pisteet: " + pisteet);

            //Console.Write("Ohjelman tekijä: "); // Jos WriteLine, lisää rivinvaihdon loppuun
            
            //Console.WriteLine(tekija);

            //Console.WriteLine("Ohjelman tekijä on " + tekija + ".");
           


        }
    }
}
