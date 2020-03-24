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
        }
    }
}
