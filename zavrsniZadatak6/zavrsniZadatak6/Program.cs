using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavrsniZadatak6
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasaC prosjek = new KlasaC();
            

            int[] brojevi = new int[5];
            Console.WriteLine("Unesite pet brojeva: ");

            for (int i = 0; i < 5; i++)
            {
                brojevi[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Zbroj unesenih brojeva je: " + prosjek.Zbroj(brojevi) + ", a prosjek unesenih brojeva je: " + prosjek.Prosjek(brojevi));
            

            Console.ReadKey();

        }
    }
}
