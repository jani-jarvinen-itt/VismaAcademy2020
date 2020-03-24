using System;
using System.Collections.Generic;
using System.Text;

namespace LokitusEsimerkki
{
    // Dependency Injection (DI)
    public class Riippuvuudet
    {
        public ILokitus HaeLoki()
        {
            // nämä tiedot voitaisiin hakea esim. tietokannasta
            //ILokitus lokitus = new TiedostoLokitus();
            ILokitus lokitus = new Lokitus();

            return lokitus;
        }
    }
}
