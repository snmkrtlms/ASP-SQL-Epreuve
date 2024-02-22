using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Epreuve_ASP_SQL.Entities
{
    public class CritereEco
    {
        public CritereEco(string nom)
        {
            Nom = nom;
        }

        public string Nom { get; set; }
    }
}
