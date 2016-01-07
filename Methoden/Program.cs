using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methoden
{
    class Program
    {
        static void Main(string[] args)
        {
            float prijs = int.Parse(Console.ReadLine());

            float btw = BerekenBtw(prijs);

            Console.WriteLine(prijs);
            Console.WriteLine(btw);
            Console.WriteLine(prijs + btw);
        }

        private static float BerekenBtw(float prijs)
        {
            return (float)(prijs * 0.21);
        }
    }
}
