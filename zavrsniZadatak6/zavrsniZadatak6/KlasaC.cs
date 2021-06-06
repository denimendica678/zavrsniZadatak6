using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavrsniZadatak6
{
    public class KlasaC
    {
        public int Zbroj(int[] brojevi)
        {
            int sum = 0;

            foreach (int d in brojevi)
            {
                sum += d;
            }

            return sum;

        }
        public int Prosjek(int[] brojevi)
        {
            int pro = 0;

            foreach (int d in brojevi)
            {
                pro += d;
            }

            pro = pro / brojevi.Length;

            return pro;
        }


    }
}
