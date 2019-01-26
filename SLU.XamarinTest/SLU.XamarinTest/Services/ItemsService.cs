using SLU.XamarinTest.Helpers.Rest;
using SLU.XamarinTest.Models;
using SLU.XamarinTest.Services.Rest;
using System.Collections.Generic;

namespace SLU.XamarinTest.Services
{
    public class ItemsService
    {
        private readonly IRestService _restService;
        private readonly string _restUrl;

        public ItemsService()
        {
            _restService = new RestService();
            _restUrl = RestHelper.RestUrl(RestHelper.Types.Items);
        }

        public List<Item> GetAllItems()
        {
            var items = _restService.Get<Item>(_restUrl).Result;

            return items;
        }
    }
}