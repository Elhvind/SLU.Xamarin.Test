using SLU.XamarinFormsTest.DataAccess.Entities;
using SLU.XamarinFormsTest.DataAccess.Repositories.Common;
using SLU.XamarinFormsTest.DataAccess.Repositories.Interfaces;

namespace SLU.XamarinFormsTest.DataAccess.Repositories
{
    public class WholesalerRepository : RepositoryBase<WholesalerEntity>, IRepository<WholesalerEntity>, IWholesalerRepository
    {
        public WholesalerRepository() : base("wholesaler.json")
        {
        }
    }
}