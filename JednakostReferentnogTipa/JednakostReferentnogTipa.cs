using System;
using System.Diagnostics;

namespace Vsite.CSharp
{
    // U klasi Osoba iz projekta MetodaEqualsZaReferentiTip definirati operatore == i != tako da donji primjeri daju očekivane rezultate.

    class JednakostReferentnogTipa
    {
        static void Jednakost(Osoba osobaA, Osoba osobaB)
        {
            Console.WriteLine(string.Format("{0} == {1}: {2}", osobaA, osobaB, osobaA == osobaB));
            Console.WriteLine(string.Format("{0} != {1}: {2}", osobaA, osobaB, osobaA != osobaB));
        }

        static void Main(string[] args)
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = osobaA;
            Jednakost(osobaA, osobaB);

            // novi "Janko" s istim matičnim brojem
            osobaB = new Osoba("Janko", 1);
            Jednakost(osobaA, osobaB);

            // novi "Janko" s drugim matičnim brojem
            osobaB = new Osoba("Janko", 2);
            Jednakost(osobaA, osobaB);

            // dvije osobe s različitim imenima i MB
            osobaB = new Osoba("Darko", 2);
            Jednakost(osobaA, osobaB);

            osobaB = null;
            Jednakost(osobaA, osobaB);

            osobaA = null;
            Jednakost(osobaA, osobaB);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
