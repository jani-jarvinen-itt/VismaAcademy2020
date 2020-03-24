using System;
using System.IO;

namespace LokitusEsimerkki
{
    public class Lokitus : ILokitus
    {
        public void Virhe(string viesti)
        {
            Console.WriteLine("VIRHE: " + viesti);
        }
    }

    public class TiedostoLokitus : ILokitus
    {
        public void Virhe(string viesti)
        {
            const string Lokitiedosto = @"C:\Temp\Sovellus.log";
            File.AppendAllText(Lokitiedosto, "VIRHE: " + viesti);
        }
    }
}