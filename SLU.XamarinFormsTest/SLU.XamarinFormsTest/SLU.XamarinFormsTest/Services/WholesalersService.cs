using SLU.XamarinFormsTest.DataAccess.Repositories;
using SLU.XamarinFormsTest.DataAccess.Repositories.Interfaces;

namespace SLU.XamarinFormsTest.Services
{
    public class WholesalersService : IWholesalersService
    {
        private readonly IWholesalerRepository _wholesalerRepository;

        public WholesalersService()
        {
            // TODO: Dependency injection
            _wholesalerRepository = new WholesalerRepository();
        }
    }
}