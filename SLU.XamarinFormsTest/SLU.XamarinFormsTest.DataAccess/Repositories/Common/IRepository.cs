using SLU.XamarinFormsTest.DataAccess.Entities;
using System.Collections.Generic;

namespace SLU.XamarinFormsTest.DataAccess.Repositories.Common
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