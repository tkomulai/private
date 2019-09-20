using System;

namespace Toistorakenneharjoituksia
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i=10; i <= 20; i++)
            //{
            //    if(i == 11 || i == 16 || i == 19)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //for(int i=1; i <= 5; i++)
            //{
            //    Console.WriteLine("Hei Teemu");
            //}

            //for(int i=1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            //Random random = new Random();
            //int numero;
            //for(int i =1; i <= 7; i++)
            //{
            //    numero = random.Next(1, 40);
            //    Console.WriteLine(numero);
            //}

            // Tee ohjelma, joka "heittää" noppaa ja näyttää tuloksen (eli arvotaan numero väliltä 1-6). Tämän jälkeen ohjelma kysyy, heitetäänkö uudestaan. 
            //Jos käyttäjä vastaa k, ohjelma heittää uudestaan. Jos käyttäjä vastaa e, ohjelma loppuu. Vinkki! Saattaa olla, että tarvitset toiston ehdossa erisuuri-merkkiä, joka on !=

            //Random random = new Random();
            //string syote;

            //do
            //{
            //    Console.WriteLine(random.Next(1, 7));
            //    Console.WriteLine("Heitetäänkö uudestaan?");
            //    syote = Console.ReadLine();
            //} while (syote == "k");

            //Kysy käyttäjältä mistä numerosta tulostetaan mihin numeroon asti. Eli kysy ensin yksi luku ja sitten toinen luku. Jos käyttäjä antoi luvut 2 ja 4, tulostetaan numero 2 3 4.
            string syote1;
            string syote2;

            Console.WriteLine("Anna ensimmäinen luku");
            syote1 = Console.ReadLine();
            Console.WriteLine("Anna toinen luku");
            syote2 = Console.ReadLine();
            Console.WriteLine("Tulostetaan luvusta " + syote1 + " lukuun " + syote2);
            for(int i=int.Parse(syote1); i <= int.Parse(syote2); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
