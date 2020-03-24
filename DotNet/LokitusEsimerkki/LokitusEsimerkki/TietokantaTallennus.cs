using System;
using System.Collections.Generic;
using System.Text;

namespace LokitusEsimerkki
{
    public class TietokantaTallennus
    {
        private ILokitus lokitus;

        // constructor / rakentaja
        public TietokantaTallennus() : base()
        {
            Riippuvuudet r = new Riippuvuudet();
            lokitus = r.HaeLoki();
        }

        public void Tallenna(object olio)
        {
            try
            {
                // tallennetaan olio tietokantaan tässä...
            }
            catch (Exception ex)
            {
                string virhe = ex.Message;
                lokitus.Virhe(virhe);
            }
        }

        public object Lataa(string id)
        {
            try
            {
                // haetaan olio tietokannasta tässä...
            }
            catch (Exception ex)
            {
                string virhe = ex.Message;
                lokitus.Virhe(virhe);
            }

            return null;
        }
    }
}
