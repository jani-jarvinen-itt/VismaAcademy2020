using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualBasicLuokkakirjasto;

namespace CSharpKonsoliSovellus
{
    class Program
    {
        static void Main(string[] args)
        {
            throw new ApplicationException("Pöö!");


            Asiakas asiakas = new Asiakas();
            asiakas.CustomerId = 1000;
            asiakas.AsetaNimi("Matti Möttönen");
            asiakas.Osoite = "Teollisuuskatu 12 B";
            asiakas.Puhelinnumero = "1234567";

            asiakas.CustomerId++;

            int[] luvut = { 1, 2, 3 };
            // luvut[4] = 100;
            byte b1 = 200;
            byte b2 = 100;
            int summa = b1 + b2;
            Console.WriteLine(summa);

            TestiMetodi();

            KirjoitaTiedostoon();


            /*
            string nimi = null;
            if (nimi.Length > 0)
            {
                // ...
            }
            */


            /*
            int a = 100;
            string b = "200";
            string tulos = b + a;
            Console.WriteLine(tulos);
            */

            /*
            Auto auto = new Auto();
            auto.Väri = "punainen";
            auto.Huippunopeus = 250;
            auto.KäynnistäMoottori();

            Console.WriteLine("Toimii!");
            */

            Console.ReadLine();
        }

        private static void KirjoitaTiedostoon()
        {
            /*
            string polku = @"C:\Temp\Tiedosto.txt";
            FileStream tiedosto = new FileStream(polku,
                FileMode.OpenOrCreate, FileAccess.Write);
            string data = "Moikka maailma!\r\n";
            byte[] tavut = Encoding.UTF8.GetBytes(data);
            tiedosto.Write(tavut, 0, tavut.Length);
            //tiedosto.Flush();
            tiedosto.Close();
            */

            string polku = @"C:\Temp\Tiedosto.txt";
            /*
            using (FileStream tiedosto = new FileStream(polku,
                        FileMode.OpenOrCreate, FileAccess.Write))
            {
                string data = "Moikka maailma!\r\n";
                byte[] tavut = Encoding.UTF8.GetBytes(data);
                tiedosto.Write(tavut, 0, tavut.Length);
            }
            */

            FileStream tiedosto = new FileStream(polku,
                        FileMode.OpenOrCreate, FileAccess.Write);
            try
            {
                string data = "Moikka maailma!\r\n";
                byte[] tavut = Encoding.UTF8.GetBytes(data);
                tiedosto.Write(tavut, 0, tavut.Length);
            }
            finally
            {
                tiedosto.Close();
            }

            Console.WriteLine("Tiedostoon kirjoitettu.");
        }

        private static void TestiMetodi()
        {
            int[] taulukko = { 1, 2, 3, 4 };
            string nimi = "Teppo Testaaja";
            int luku = 1000;

            // GC.Collect();
        }
    }
}
