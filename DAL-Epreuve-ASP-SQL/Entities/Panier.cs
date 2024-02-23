using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Epreuve_ASP_SQL.Entities
{
    public class Panier
    {
        public int Id_Panier { get; set; }
        public int Quantite {  get; set; }
        public int Id_Commande { get; set; }
        public int Id_Produit { get; set; }
    }
}
