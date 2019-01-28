using SLU.ApiTest.DataAccess.Models;
using System.Collections.Generic;

namespace SLU.ApiTest.DataAccess.Repositories.Core
{
    public interface IRepository<TEntityType> where TEntityType : IDataEntity, new()
    {
        ICollection<TEntityType> GetAll();
        TEntityType Get(int id);
        void Create(TEntityType entity);
        bool Update(int id, TEntityType entity);
        bool Delete(int id);
    }
}