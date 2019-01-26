using SLU.XamarinTest.Services.Rest;

namespace SLU.XamarinTest.Services
{
    public class WholesalersService
    {
        private readonly IRestService _restService;

        public WholesalersService()
        {
            _restService = new RestService();
        }
    }
}