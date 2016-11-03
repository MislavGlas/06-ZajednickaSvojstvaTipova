using System;

namespace Vsite.CSharp
{
    class MojaKlasa
    {
    }

    struct MojaStruktura
    {
    }

    public class MetodaEquals
    {
        public static void UsporedbaKlasa()
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = null;

            // Usporediti objekte mk1 i mk2 korištenjem statičke metode MojaKlasa.Equals te ispisati rezultat
            Console.WriteLine(MojaKlasa.Equals(mk1, mk2));

            // Usporediti reference na objekte mk1 i mk2 korištenjem statičke metode MojaKlasa.ReferenceEquals te ispisati rezultat
            Console.WriteLine(MojaKlasa.ReferenceEquals(mk1, mk2));

            // Usporediti objekte mk1 i mk2 pozivom metode mk1.Equals te ispisati rezultat
            Console.WriteLine(mk1.Equals(mk2));

            // Usporediti objekte mk1 i mk2 pozivom metode mk2.Equals te ispisati rezultat
            // Console.WriteLine(mk2.Equals(mk1));

        }

        public static void UsporedbaStruktura()
        {
            // Storiti dvije strukture ms1 i ms2 na isti način kao i za gornje instance klasa mk1 i mk2
            MojaStruktura ms1 = new MojaStruktura();
            MojaStruktura ms2 = new MojaStruktura();

            // Usporediti objekte ms1 i ms2 korištenjem statičke metode MojaStruktura.Equals te ispisati rezultat
            Console.WriteLine(MojaKlasa.Equals(ms1, ms2));

            // Usporediti objekte ms1 i ms2 pozivom metode ms1.Equals te ispisati rezultat
            Console.WriteLine(ms1.Equals(ms2));

            // Usporediti objekte ms1 i ms2 pozivom metode ms2.Equals te ispisati rezultat
            Console.WriteLine(MojaKlasa.Equals(ms2, ms1));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Usporedba klasa");
            UsporedbaKlasa();

            Console.WriteLine("Usporedba struktura");
            UsporedbaStruktura();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
