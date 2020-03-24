using System;

namespace LokitusEsimerkki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //ILokitus lokitus = new TiedostoLokitus();
            ILokitus lokitus = new Lokitus();

            TietokantaTallennus tallennus = new TietokantaTallennus();
            tallennus.Tallenna(null, lokitus);
        }
    }
}
