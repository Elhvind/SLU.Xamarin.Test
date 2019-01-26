using SLU.XamarinTest.DataAccess.Entities;
using SLU.XamarinTest.DataAccess.Repositories.Common;
using SLU.XamarinTest.DataAccess.Repositories.Interfaces;

namespace SLU.XamarinTest.DataAccess.Repositories
{
    public class WholesalerRepository : RepositoryBase<WholesalerEntity>, IRepository<WholesalerEntity>, IWholesalerRepository
    {
        public WholesalerRepository() : base("wholesaler.json")
        {
        }
    }
}