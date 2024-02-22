using System;
using System.Collections.Generic;
using System.Text;

namespace Shared_Epreuve_ASP_SQL.Repositories
{
    public interface ICritereEcoRepository<TEntity>
    {
        IEnumerable<TEntity> Get();
    }
}
