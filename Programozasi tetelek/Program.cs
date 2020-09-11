using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozasi_tetelek
{
    class Program
    {
        static int[] tomb = new int[10] {12,7,2,4,45,99,1,8,95,50};

        static void TombKiiras()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                if (i == 9)
                {
                    Console.WriteLine(tomb[i]);
                    break;
                }
                Console.Write(tomb[i] + ", ");
            }
            Console.WriteLine("**********************************************");
        }

        static void Osszegzes()
        {
            int sum = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                sum += tomb[i];
            }
            Console.WriteLine("A tömb elemeinek összege: {0}", sum);
            Console.WriteLine("**********************************************");
        }

        static void Megszamlalas()
        {
            int db = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 3 == 0)
                {
                    db++;
                }
            }
            Console.WriteLine("{0} olyan szám van, amely osztható 3-mal.", db);
            Console.WriteLine("**********************************************");
        }

        static void Eldontes()
        {
            int i = 0;

            while (i<tomb.Length && i !=69)
            {
                i++;
            }
            
            if (i<tomb.Length)
            {
                Console.WriteLine("Volt 69");
            }
            else
            {
                Console.WriteLine("Nem volt 69");
            }
            Console.WriteLine("**********************************************");
        }

        static void Kivalasztas()
        {
            int i = 0;
            while (i < tomb.Length && tomb[i] != 50)
            {
                i++;
            }
            Console.WriteLine("Az 50 a {0}. helyen van", i+1);
            Console.WriteLine("**********************************************");

        }

        static void Kereses()
        {
            int i = 0;

            while (i < tomb.Length && tomb[i] != 50)
            {
                i++;
            }

            if (i < tomb.Length)
            {
                Console.WriteLine("Van benne 50. a(z) {0}. helyen", i+1);
            }
            else
            {
                Console.WriteLine("Nincs benne 50.");
            }
        }
        static void Main(string[] args)
        {
            TombKiiras();
            Osszegzes();
            Megszamlalas();
            Eldontes();
            Kivalasztas();
            Kereses();

            Console.ReadKey();
        }


    }
}
