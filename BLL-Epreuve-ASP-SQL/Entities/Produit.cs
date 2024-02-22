using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Epreuve_ASP_SQL.Entities
{
    public class Produit
    {

        public int Id_Produit { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public decimal Prix { get; set; }
        public string CritereEco { get; set; }
        public string Categorie { get; set; }

        //Constructeur
        public Produit(int id_Produit, string nom, string description, decimal prix, string critereEco, string categorie)
        { 
            Id_Produit= id_Produit;
            Nom = nom;
            Description = description;
            Prix = prix;
            CritereEco = critereEco;
            Categorie = categorie;
        }
    }
}