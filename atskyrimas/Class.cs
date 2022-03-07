using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bandymas
{
    internal class matematika
    {
        public int n = 2;
        public long ats = 0;
        public void progresija()
        {
            long i = 1;
            long b = 2;
            double end = Math.Pow(10, 15);
            while (ats <= end)
            {
                ats = i * b;
                i = b;
                b = ats;
                n++;
            }
        }
    }

    class skaiciavimas : matematika
    {
        public int skaicius;
        public int ats = 1;
        public skaiciavimas(int sk)
        {
            skaicius = sk;
        }

        public void mate()
        {
            for (int i = 1; i <= skaicius; i++)
            {
                ats *= i;
            }
        }
    }
}