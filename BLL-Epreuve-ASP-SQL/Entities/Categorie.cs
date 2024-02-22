using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Epreuve_ASP_SQL.Entities
{
    public class Categorie
    {
        public Categorie(string nom)
        {
            Nom = nom;
        }

        public string Nom {  get; set; }
    }
}
