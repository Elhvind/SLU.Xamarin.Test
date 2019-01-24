using SLU.Api.Test.Data.Entities;
using System.Collections.Generic;

namespace SLU.Api.Test.Repositories.Common
{
    public interface IRepository<TEntityType> where TEntityType : IDataEntity, new()
    {
        IEnumerable<TEntityType> Get();
        TEntityType Get(int id);
        void Create(TEntityType entity);
        void Update(TEntityType entity);
        void Delete(int id);
    }
}