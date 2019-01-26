using SLU.XamarinTest.Services.Rest;

namespace SLU.XamarinTest.Services
{
    public class UsedItemsService
    {
        private readonly IRestService _restService;

        public UsedItemsService()
        {
            _restService = new RestService();
        }
    }
}