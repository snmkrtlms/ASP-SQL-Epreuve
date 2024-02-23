using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Epreuve_ASP_SQL.Entities
{
    public class Panier
    {
        //Constructeur
        public Panier(int id_Panier, int quantite, int id_Commande, int id_Produit)
        {
            Id_Panier = id_Panier;
            Quantite = quantite;
            Id_Commande = id_Commande;
            Id_Produit = id_Produit;
        }

        public int Id_Panier { get; set; }
        public int Quantite { get; set; }
        public int Id_Commande { get; set; }
        public int Id_Produit { get; set; }
    }
}
