using SLU.ApiTest.DataAccess.Repositories;
using SLU.ApiTest.DataAccess.Repositories.Interfaces;
using SLU.ApiTest.Services.Interfaces;

namespace SLU.ApiTest.Services
{
    public class WholesalerService : IWholesalerService
    {
        private readonly IWholesalerRepository _wholesalerRepository;

        public WholesalerService()
        {
            _wholesalerRepository = new WholesalerRepository();
        }
    }
}
