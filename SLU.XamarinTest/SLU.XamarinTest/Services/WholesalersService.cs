using SLU.XamarinTest.DataAccess.Repositories;
using SLU.XamarinTest.DataAccess.Repositories.Interfaces;

namespace SLU.XamarinTest.Services
{
    public class WholesalersService
    {
        private readonly IWholesalerRepository _wholesalerRepository;

        public WholesalersService()
        {
            // TODO: Dependency injection
            _wholesalerRepository = new WholesalerRepository();
        }
    }
}