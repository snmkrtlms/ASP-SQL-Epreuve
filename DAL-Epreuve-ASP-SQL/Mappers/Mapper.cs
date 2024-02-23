using DAL_Epreuve_ASP_SQL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL_Epreuve_ASP_SQL.Mappers
{
    public static class Mapper
    {
        public static Produit ToProduit(this IDataRecord record)
        {
            if (record is null) return null;
            return new Produit
            {
                Id_Produit = (int)record[nameof(Produit.Id_Produit)],
                Nom = (string)record[nameof(Produit.Nom)],
                Description = (string)record[nameof(Produit.Description)],
                Prix = (decimal)record[nameof(Produit.Prix)],
                CritereEco = (string)record[nameof(Produit.CritereEco)],
                Categorie = (string)record[nameof(Produit.Categorie)]
            };
        }

        public static CritereEco ToCritereEco(this IDataRecord record)
        {
            if (record is null) return null;
            return new CritereEco
            {
                Nom = (string)record[nameof(CritereEco.Nom)]
            };
        }

        public static Categorie ToCategorie(this IDataRecord record)
        {
            if (record is null) return null;
            return new Categorie
            {
                Nom = (string)record[nameof(Categorie.Nom)]
            };
        }

        public static Media ToMedia(this IDataRecord record)
        {
            if (record is null) return null;
            return new Media
            {
                Id_Media = (int)record[nameof(Media.Id_Media)],
                Url = (string)record[nameof(Media.Url)],
                Id_Produit = (int)record[nameof(Media.Id_Produit)]
            };
        }
        public static Panier ToPanier(this IDataRecord record)
        {
            if (record is null) return null;
            return new Panier
            {
                Id_Panier = (int)record[nameof(Panier.Id_Panier)],
                Quantite = (int)record[nameof(Panier.Quantite)],
                Id_Commande = (int)record[nameof(Panier.Id_Commande)],
                Id_Produit = (int)record[nameof(Panier.Id_Produit)]
            };
        }
    }
}
