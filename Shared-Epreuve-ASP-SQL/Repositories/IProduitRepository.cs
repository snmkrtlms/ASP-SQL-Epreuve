using System;
using System.Collections.Generic;
using System.Text;

namespace Shared_Epreuve_ASP_SQL.Repositories
{
    public interface IProduitRepository<TEntity> : ICRUDRepository<TEntity, int>
    {
        IEnumerable<TEntity> GetPopulaires();
        IEnumerable<TEntity> GetByCategorie(string categorie);
        IEnumerable<TEntity> GetByCritereEco(string critereEco);
        IEnumerable<TEntity> GetByNom(string nomProduit);
    }
}
