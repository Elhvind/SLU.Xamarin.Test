using SLU.Api.Test.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SLU.Api.Test.Common.Repositories
{
    public abstract class RepositoryBase<TEntityType> where TEntityType : IDataEntity, new()
    {
        public RepositoryBase(string jsonFileName)
        {
            JsonFileName = jsonFileName;
        }

        protected string JsonFileName { get; }

        protected IEnumerable<TEntityType> ReadJsonFile()
        {
            return new List<TEntityType>();
        }

        protected void WriteJsonFile(IEnumerable<TEntityType> entities)
        {

        }

        public virtual void Delete(int id)
        {
            var allEntites = ReadJsonFile();
            var filteredEntites = allEntites.Where(x => x.Id != id).ToList();
            WriteJsonFile(filteredEntites);
        }

        public virtual IEnumerable<TEntityType> Get()
        {
            return ReadJsonFile();
        }

        public virtual TEntityType Get(int id)
        {
            return ReadJsonFile().FirstOrDefault(x => x.Id == id);
        }
    }
}