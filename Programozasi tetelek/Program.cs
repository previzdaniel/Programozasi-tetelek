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
        }
        static void Main(string[] args)
        {
            TombKiiras();
            Osszegzes();

            Console.ReadKey();
        }

        private static void Osszegzes()
        {
            int sum = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                sum += tomb[i];
            }
            Console.WriteLine("A tömb elemeinek összege: {0}",sum);
        }
    }
}
