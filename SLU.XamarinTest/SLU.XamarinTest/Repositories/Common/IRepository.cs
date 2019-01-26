using SLU.XamarinTest.Data.Entities;
using System.Collections.Generic;

namespace SLU.XamarinTest.Repositories.Common
{
    public interface IRepository<TEntityType> where TEntityType : IDataEntity, new()
    {
        IEnumerable<TEntityType> GetAll();
        TEntityType Get(int id);
        void Create(TEntityType entity);
        bool Update(int id, TEntityType entity);
        bool Delete(int id);
    }
}