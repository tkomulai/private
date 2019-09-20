using System;

namespace ika
{
    class Program
    {
        static void Main(string[] args)
        {
            int ika = 48;

            // Tulostusehdot
            if (ika > 0 && ika < 18)
            {
                Console.WriteLine("Olet alaikäinen");
            }
            if (ika >= 15)
            {
                Console.WriteLine("Saat ajaa mopoa");
                if(ika == 16 || ika == 17)
                {
                    Console.WriteLine("Saat ajaa kevaria");
                }
            }
            if(ika >= 65)
            {
                Console.WriteLine("Olet eläkeläinen");
            }
            if(ika >= 58 && ika < 65)
            {
                Console.WriteLine("Mene varhaiseläkkeelle");
            }
            if(ika == 18)
            {
                Console.WriteLine("Olet aikuinen ja saat ajaa autoa");
            }
            if(ika == 65)
            {
                Console.WriteLine("Hyviä eläkepäiviä!");
            }
            if(ika >= 40 && ika <= 50)
            {
                Console.WriteLine("Parasta keski-ikää!");
            }
            if (ika >= 18 && ika == 20 || ika == 30 || ika == 40 || ika == 50 || ika == 60 || ika == 70 || ika == 80 || ika == 100)
            {
                Console.WriteLine("Onnea pyöreistä!");
            }
            if(ika == 100)
            {
                Console.WriteLine("**********");
                Console.WriteLine("O N N E A !");
                Console.WriteLine("**********");
            }
            else
            {
                Console.WriteLine("Olet Aikuinen");
            }


        }
    }
}
