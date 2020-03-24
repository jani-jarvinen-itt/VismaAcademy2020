using System;
using System.Collections.Generic;
using System.Text;

namespace LokitusEsimerkki
{
    public class TietokantaTallennus
    {
        public void Tallenna(object olio, ILokitus lokitus)
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
    }
}
