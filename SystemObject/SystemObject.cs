using System;

namespace Vsite.CSharp
{
    // Definirati klasu MojaKlasa bez ikakvih članova, samo s praznom definicijom.
    class MojaKlasa
    {

    }

    public class SystemObject
    {
        public static void IspisToString()
        {
            // Otkomentirati donje naredbe.
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            MojaKlasa mk3 = new MojaKlasa();

            // Za svaki objekt (mk1, mk2, mk3) pozvati njegovu metodu ToString i ispisati na konzolu ono što ona vraća.
            Console.WriteLine(mk1.ToString());
            Console.WriteLine(mk2.ToString());
            Console.WriteLine(mk3.ToString());
        }

        public static void IspisGetType()
        {
            // Otkomentirati donje naredbe.
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            MojaKlasa mk3 = new MojaKlasa();

            // TODO: Za svaki objekt (mk1, mk2, mk3) pozvati njegovu metodu GetType i ispisati na konzolu ono što ona vraća.
            Console.WriteLine(mk1.GetType());
            Console.WriteLine(mk2.GetType());
            Console.WriteLine(mk3.GetType());
        }

        public static void IspisGetHashCode()
        {
            // Otkomentirati donje naredbe.
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            MojaKlasa mk3 = new MojaKlasa();

            // TODO: Za svaki objekt (mk1, mk2, mk3) pozvati njegovu metodu GetHashCode i ispisati na konzolu ono što ona vraća.
            Console.WriteLine(mk1.GetHashCode());
            Console.WriteLine(mk2.GetHashCode());
            Console.WriteLine(mk3.GetHashCode());

        }

        public static void IspisEquals()
        {
            // Otkomentirati donje naredbe.
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            MojaKlasa mk3 = new MojaKlasa();

            // Otkomentirati donje naredbe i ispisati na konzolu rezultate usporedbi.
            Console.WriteLine(mk1.Equals(mk2));
            Console.WriteLine(mk1.Equals(mk3));
            Console.WriteLine(mk2.Equals(mk1));
            Console.WriteLine(mk2.Equals(mk3));
            Console.WriteLine(mk3.Equals(mk1));
            Console.WriteLine(mk3.Equals(mk2));
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Ispis ToString");
            IspisToString();

            Console.WriteLine("Ispis GetType");
            IspisGetType();

            Console.WriteLine("Ispis GetHashCode");
            IspisGetHashCode();

            Console.WriteLine("Ispis Equals");
            IspisEquals();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
