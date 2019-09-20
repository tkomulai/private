using System;

namespace ehtolauseita
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. tehtävä
            int luku1 = 5;
            int luku2 = 3;

            // 1
            if(luku1 == luku2)
            {
                Console.WriteLine("Tehtävä 1.1: Luvut ovat yhtä suuret");
            }
            else
            {
                Console.WriteLine("Tehtävä 1.1: Luvut ovat erisuuret");
            }
            
            // 2
            if(luku1 > luku2)
            {
                Console.WriteLine("Tehtävä 1.2: Luku1 on suurempi kuin luku2");
            }
            else
            {
                Console.WriteLine("Tehtävä 1.2: Luku1 ei ole suurempi kuin luku2");
            }

            // 3
            if(luku1 >= luku2)
            {
                Console.WriteLine("Tehtävä 1.3: Luku1 on suurempi tai yhtäsuuri kuin luku2");
            }
            else
            {
                Console.WriteLine("Tehtävä 1.3: Luku1 ei ole suurempi tai yhtäsuuri kuin luku2");
            }

            // 4
            if(luku1 != luku2)
            {
                Console.WriteLine("Tehtävä 1.4: Luku1 on erisuuri kuin luku2");
            }
            else
            {
                Console.WriteLine("Tehtävä 1.4: Luku1 ei ole erisuuri kuin luku2");
            }


            // 2. tehtävä
            int luku3 = 12;
            int luku4 = 15;
            int luku5 = 12;

            // 1
            if(luku3 == luku4 && luku3 == luku5 && luku4 == luku5)
            {
                Console.WriteLine("Tehtävä 2.1: Kaikki luvut ovat yhtä suuria");
            }
            else
            {
                Console.WriteLine("Tehtävä 2.1: Kaikki luvut eivät ole yhtä suuria");
            }

            // 2 Tutki, onko luku1 ja luku2 yhtä suuria TAI luku2 ja luku3 yhtä suuria
            if(luku3 == luku4 || luku4 == luku5)
            {
                Console.WriteLine("Tehtävä 2.2: Luvut ovat yhtä suuria");
            }
            else
            {
                Console.WriteLine("Tehtävä 2.2: Luvut eivät ole yhtä suuria");
            }

            // 3 Tutki, onko luku1 isompi kuin luku2 JA luku1 yhtä suuri kuin luku3.
            if(luku3 > luku4 && luku3 == luku5)
            {
                Console.WriteLine("Tehtävä 2.3: Kyllä");
            }
            else
            {
                Console.WriteLine("Tehtävä 2.3: Ei");
            }

            // 4 Tutki, onko luku1 isompi kuin luku2. Jos ei ole, tutki onko luku2 isompi kuin luku3
            if(luku3 > luku4)
            {
                Console.WriteLine("Tehtävä 2.4: Luku3 on suurempi kuin luku4");
            }
            else if(luku4 > luku5)
            {
                Console.WriteLine("Tehtävä 2.4: Luku4 on suurempi kuin luku5");
            }

            // 5 Tutki, onko luku1 ja luku2 yhtä suuria. Jos ei ole, tutki, onko luku1 ja luku3 yhtä suuria.
            if (luku3 == luku4)
            {
                Console.WriteLine("Tehtävä 2.5: Luku3 on yhtäsuuri kuin luku4");
            }
            else if(luku3 == luku5)
            {
                Console.WriteLine("Tehtävä 2.5: Luku3 on yhtäsuuri kuin luku5");
            }

            // 3. tehtävä
            string nimi1 = "Pekka";
            string nimi2 = "Tauno";
            string nimi3 = "Donald";

            // 1 Tutki, onko nimi1 ja nimi2 samoja
            if (nimi1 == nimi2)
            {
                Console.WriteLine("Tehtävä 3.1: Nimi1 on sama kuin nimi2");
            }

            // 2 Tutki, onko nimi1 ja nimi2 erisuuria
            if (nimi1 != nimi2)
            {
                Console.WriteLine("Tehtävä 3.2: Nimi1 on eri kuin nimi2");
            }

            // 3 Tutki, onko nimi1 ja nimi2 samoja. Jos ei ole, tutki onko nimi1 ja nimi3 samoja.
            if (nimi1 == nimi2)
            {
                Console.WriteLine("Tehtävä 3.3: Nimi1 on sama kuin nimi2");
            }
            else if(nimi1 == nimi3)
            {
                Console.WriteLine("Tehtävä 3.3: Nimi1 on sama kuin nimi3");
            }
        }
    }
}
