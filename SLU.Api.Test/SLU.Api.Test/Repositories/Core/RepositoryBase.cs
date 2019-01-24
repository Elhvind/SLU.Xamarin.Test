using SLU.Api.Test.Data.Entities;

namespace SLU.Api.Test.Core.Repositories
{
    public abstract class RepositoryBase<TEntityType> where TEntityType : IDataEntity, new()
    {
        public RepositoryBase(string jsonFileName)
        {
            JsonFileName = jsonFileName;
        }

        protected string JsonFileName { get; }
    }
}