using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = Console.ReadLine();
            OnderzoekTekst(tekst);
        }

        private static void OnderzoekTekst(string tekst)
        {
            int i = 0;
            int komma=0, punt = 0, puntkomma = 0;
            for (int j = 0; j < tekst.Length; j++)
            {
                char c = tekst[i];
                if (c == ',')
                {
                    komma++;
                }
                if (c == '.')
                {
                    punt++;
                }
                if (c == ';')
                {
                    puntkomma++;
                }
            }
            Console.WriteLine(komma);
            Console.WriteLine(punt);
            Console.WriteLine(puntkomma);
        }
    }
}
