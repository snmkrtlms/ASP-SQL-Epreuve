using ASP_Epreuve_ASP_SQL.Models;
using BLL_Epreuve_ASP_SQL.Entities;

namespace ASP_Epreuve_ASP_SQL.Handlers
{
    public static class Mapper
    {
        #region Produit
        public static ProduitListItemViewModel ToListItem(this Produit entity)
        {
            if (entity is null) return null;
            return new ProduitListItemViewModel
            {
                Id_Produit = entity.Id_Produit, 
                Nom = entity.Nom,
                Description = entity.Description,
                Prix = entity.Prix,
                CritereEco = entity.CritereEco,
                Categorie = entity.Categorie,
            };
        }

        public static ProduitDetailsViewModel ToDetails(this Produit entity)
        {
            if (entity is null) return null;
            return new ProduitDetailsViewModel
            {
                Id_Produit = entity.Id_Produit,
                Nom = entity.Nom,
                Description = entity.Description,
                Prix = entity.Prix,
                CritereEco = entity.CritereEco,
                Categorie = entity.Categorie,
            };
        }

        public static Produit ToBLL(this ProduitCreateForm entity)
        {
            if (entity is null) return null;
            return new Produit(
                0,
                entity.Nom,
                entity.Description,
                entity.Prix,
                entity.CritereEco,
                entity.Categorie
            );
        }

        public static ProduitEditForm ToEditForm( this Produit entity )
        {
            if (entity is null) return null;
            return new ProduitEditForm
            {
                Id_Produit = entity.Id_Produit,
                Nom = entity.Nom,
                Description = entity.Description,
                Prix = entity.Prix,
                CritereEco = entity.CritereEco,
                Categorie = entity.Categorie,
            };
        }

        public static Produit ToBLL(this ProduitEditForm entity)
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
        public static ProduitDeleteViewModel ToDelete(this Produit entity)
        {
            if (entity is null) return null;
            return new ProduitDeleteViewModel()
            {           
                Id_Produit = entity.Id_Produit,
                Nom = entity.Nom,
                Description = entity.Description,
                Prix = entity.Prix,
                CritereEco = entity.CritereEco,
                Categorie = entity.Categorie,
            };
        }
        #endregion

        public static Media ToBLL(this MediaCreateForm entity)
        {
            return new Media(
                0,
                entity.Url.FileName,
                entity.Id_Produit
            );
        }
    }
}
