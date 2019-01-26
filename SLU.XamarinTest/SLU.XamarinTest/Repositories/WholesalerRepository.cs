using SLU.XamarinTest.Common.Repositories;
using SLU.XamarinTest.Data.Entities;
using SLU.XamarinTest.Repositories.Common;
using SLU.XamarinTest.Repositories.Interfaces;

namespace SLU.XamarinTest.Repositories
{
    public class WholesalerRepository : RepositoryBase<WholesalerEntity>, IRepository<WholesalerEntity>, IWholesalerRepository
    {
        public WholesalerRepository() : base("wholesaler.json")
        {
        }
    }
}