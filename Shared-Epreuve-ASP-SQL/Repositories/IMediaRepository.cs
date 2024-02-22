using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Shared_Epreuve_ASP_SQL.Repositories
{
    public interface IMediaRepository<TEntity> : ICRUDRepository<TEntity, int>
    {
    }
}
