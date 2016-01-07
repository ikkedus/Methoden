using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int jaar = int.Parse(Console.ReadLine());

            bool isSchrikkel = IsSchrikkelJaar(jaar);
            Console.WriteLine(isSchrikkel);
        }

        private static bool IsSchrikkelJaar(int jaar)
        {
            if (jaar % 4 == 0)
            {
                if (jaar % 100 == 0)
                {
                    if (jaar % 400 == 0)
                    {
                        return true;
                    }
                }
            }
            return true;
        }
    }
}
