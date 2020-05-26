using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKonsoliSovellus
{
    public class Asiakas
    {
        // kenttä/field
        private string nimi;

        public void AsetaNimi(string nimi)
        {
            this.nimi = nimi;
            Console.WriteLine("Uusi nimi asetettu: " + nimi);
        }

        // kenttä/field
        private string osoite;
        // ominaisuus/property
        public string Osoite
        {
            get
            {
                return osoite;
            }
            set
            {
                osoite = value;
                Console.WriteLine("Uusi osoiet asetettu: " + Osoite);
            }
        }

        public string Puhelinnumero { get; set; }

        public int CustomerId { get; set; }
    }
}
