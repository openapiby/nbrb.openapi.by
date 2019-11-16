using System.Collections.Generic;

namespace OpenAPI.NBRB.Data.Contracts
{
    public interface IRepository<TKey, TEntity>
    {
        // TODO: Add GetAllAsync
        IEnumerable<TEntity> GetAll();
    }
}
