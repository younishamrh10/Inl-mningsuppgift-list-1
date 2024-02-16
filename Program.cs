using System;
using System.Collections.Generic;

namespace Inlämningsuppgift_list_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namnlista = new List<string>();

            Console.WriteLine("Du ska få skriva in namn, avsluta med tom rad");
            string nynamn = " ";
            while (nynamn != "")
            {
                Console.WriteLine("Skriv in ett nytt namn");
                nynamn = Console.ReadLine();
                if(nynamn != "")
                {
                    namnlista.Add(nynamn);
                }
            }

            Console.WriteLine("Här är det namnen du skriv");
            namnlista.Sort();
            namnlista.Reverse();

            foreach (string namn in namnlista)
            {
                Console.WriteLine(namn);
            }
        }
    }
}