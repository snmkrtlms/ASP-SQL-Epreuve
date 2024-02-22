using BLL_Epreuve_ASP_SQL.Entities;
using DAL = DAL_Epreuve_ASP_SQL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Epreuve_ASP_SQL.Mappers
{
    public static class Mapper
    {
        #region Produit
        public static Produit ToBLL(this DAL.Produit entity)
        {
            if (entity is null) return null;
            return new Produit(
                entity.Id_Produit,
                entity.Nom,
                entity.Description,
                entity.Prix,
                entity.CritereEco,
                entity.Categorie
            );
        }

        public static DAL.Produit ToDAL(this Produit entity)
        {
            if (entity is null) return null;
            return new DAL.Produit
            {
                Id_Produit = entity.Id_Produit,
                Nom = entity.Nom,
                Description = entity.Description,
                Prix = entity.Prix,
                CritereEco = entity.CritereEco,
                Categorie = entity.Categorie
            };
        }
        #endregion

        public static CritereEco ToBLL(this DAL.CritereEco entity)
        {
            if (entity is null) return null;
            return new CritereEco(
                entity.Nom
            );
        }

        public static Categorie ToBLL(this DAL.Categorie entity)
        {
            if (entity is null) return null;
            return new Categorie(
                entity.Nom
            );
        }

        #region Media
        public static Media ToBLL(this DAL.Media entity)
        {
            if (entity is null) return null;
            return new Media(
                entity.Id_Media,
                entity.Url,
                entity.Id_Produit
            );
        }
        public static DAL.Media ToDAL(this Media entity)
        {
            if (entity is null) return null;
            return new DAL.Media
            {
                Id_Media = entity.Id_Media,
                Url = entity.Url,
                Id_Produit = entity.Id_Produit
            };
        }
        #endregion
    }
}
