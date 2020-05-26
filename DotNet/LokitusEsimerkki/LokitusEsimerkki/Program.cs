using System;

namespace LokitusEsimerkki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TietokantaTallennus tallennus = new TietokantaTallennus();
            tallennus.Tallenna(null);

            PitkäMetodi();
        }

        private static void PitkäMetodi()
        {
            ILokitus lokitus = new Lokitus();

            TietokantaTallennus tallennus = new TietokantaTallennus();
            tallennus.Tallenna(null);

            lokitus = new Lokitus();
            tallennus = new TietokantaTallennus();
            tallennus.Tallenna(null);

            Tallennus(out lokitus, out tallennus);

            tallennus = new TietokantaTallennus();
            tallennus.Tallenna(null);
            lokitus = new Lokitus();

            lokitus = new Lokitus();
            tallennus = new TietokantaTallennus();
            tallennus.Tallenna(null);

            tallennus = new TietokantaTallennus();
            tallennus.Tallenna(null);
            lokitus = new Lokitus();
        }

        private static void Tallennus(out ILokitus lokitus, out TietokantaTallennus tallennus)
        {
            tallennus = new TietokantaTallennus();
            tallennus.Tallenna(null);
            lokitus = new Lokitus();

            lokitus = new Lokitus();
            tallennus = new TietokantaTallennus();
            tallennus.Tallenna(null);

            tallennus = new TietokantaTallennus();
            tallennus.Tallenna(null);
            lokitus = new Lokitus();

            lokitus = new Lokitus();
            tallennus = new TietokantaTallennus();
            tallennus.Tallenna(null);
        }
    }
}
