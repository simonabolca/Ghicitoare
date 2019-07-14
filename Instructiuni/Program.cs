using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instructiuni
{
    class Program
    {
        static void Main(string[] args)
        {
            Meniu();
            Console.ReadKey();
        }
        static void  Meniu()
        {
            Console.Clear();
            Console.WriteLine(" Alege o optiune:");
            Console.WriteLine(" 1) Tipareste numerele");
            Console.WriteLine(" 2) Ghicitoare");
            Console.WriteLine(" 3) Exit");
            int optiune = int.Parse(Console.ReadLine());

            switch (optiune)

            {
                case 1:
                    TiparesteNumere();
                    break;

                case 2:
                    Ghicitoare();
                    break;

                case 3:
                    Console.Clear();
                    break;
            }

        }
        static void TiparesteNumere()
        {
            Console.WriteLine("Introdu un numar");
            int numar = int.Parse(Console.ReadLine());
            Console.WriteLine(" Numerele sunt");
            for (int i = 0; i <=numar; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Ghicitoare()
        {
            Console.WriteLine("Bine ai venit la ghicitoare");
            Console.WriteLine("Introdu limita superioara");
            int numarSuperior = int.Parse(Console.ReadLine());

            Random rand = new Random();
            int numarAleator = rand.Next(1, numarSuperior);
            int numarIntrodus = 0;
            int numarIncercari = 0;

            do
            {
                Console.WriteLine("Incearca un numar");
                numarIntrodus = int.Parse(Console.ReadLine());
                numarIncercari++;
            }
            while (numarIntrodus != numarAleator);
            Console.WriteLine($"Ai ghicit numarul {numarAleator} din {numarIncercari} incercari ");

        }    
    }

}
