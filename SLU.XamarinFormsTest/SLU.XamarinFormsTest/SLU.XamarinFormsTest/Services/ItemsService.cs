using Newtonsoft.Json;
using SLU.XamarinFormsTest.Helpers;
using SLU.XamarinFormsTest.Models.Items;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace SLU.XamarinFormsTest.Services
{
    public class ItemsService : IItemsService
    {
        private const string ItemsApiEndpoint = "items";

        public ItemsService()
        {
        }

        public async Task<ICollection<ItemDTO>> GetAll()
        {
            using (var httpClient = new HttpClient())
            {
                var uri = new Uri(RestHelper.ApiUrl(ItemsApiEndpoint));

                var response = await httpClient.GetStringAsync(uri);

                return JsonConvert.DeserializeObject<ICollection<ItemDTO>>(response);
            }
        }

        public async Task<ItemDTO> Get(int id)
        {
            using (var httpClient = new HttpClient())
            {
                var uri = new Uri(RestHelper.ApiUrl($"{ItemsApiEndpoint}/{id}"));

                var response = await httpClient.GetStringAsync(uri);

                return JsonConvert.DeserializeObject<ItemDTO>(response);
            }
        }

        public async Task<ItemDetailsDTO> GetDetails(int id)
        {
            using (var httpClient = new HttpClient())
            {
                var uri = new Uri(RestHelper.ApiUrl($"{ItemsApiEndpoint}/{id}/details"));

                var response = await httpClient.GetStringAsync(uri);

                return JsonConvert.DeserializeObject<ItemDetailsDTO>(response);
            }
        }
    }
}