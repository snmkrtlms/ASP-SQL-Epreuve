using System;
using System.Collections.Generic;
using System.Text;

namespace Shared_Epreuve_ASP_SQL.Repositories
{
    //Commande = Panier
    public interface IPanierRepository<TEntity>
    {
        IEnumerable<TEntity> Get();
    }
}
