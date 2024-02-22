using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Shared_Epreuve_ASP_SQL.Repositories
{
    public interface ICRUDRepository<TEntity, TId> 
    {
        IEnumerable<TEntity> Get();
        TEntity Get(TId id);
        TId Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TId id);
    }
}
