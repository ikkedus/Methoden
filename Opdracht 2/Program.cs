using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal = int.Parse(Console.ReadLine());
            while (getal != 0)
            {
                if (getal > 0)
                {
                    bool isPriem = IsPriemGetal(getal);
                    Console.WriteLine(isPriem);
                }
            }
        }

        private static bool IsPriemGetal(int getal)
        {
            bool isPriem = true;
            int i = 2;
            while ((i<getal) && isPriem)
            {
                if ((getal % i)==0)
                {
                    isPriem = false;
                }
                else
                {
                    i = i + 1;
                }
            }
            return isPriem;
        }
    }
}
