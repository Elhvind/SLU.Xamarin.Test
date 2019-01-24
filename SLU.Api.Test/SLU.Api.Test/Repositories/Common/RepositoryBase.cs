using SLU.Api.Test.Data.Entities;

namespace SLU.Api.Test.Common.Repositories
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