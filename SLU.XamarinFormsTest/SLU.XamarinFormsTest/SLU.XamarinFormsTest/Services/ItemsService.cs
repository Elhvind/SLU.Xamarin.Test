using Newtonsoft.Json;
using SLU.XamarinFormsTest.Helpers;
using SLU.XamarinFormsTest.Models.Items;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SLU.XamarinFormsTest.Services
{
    public class ItemsService : IItemsService
    {
        public ItemsService()
        {
        }

        public ICollection<ItemDTO> GetAll()
        {
            using (var httpClient = new HttpClient())
            {
                var uri = new Uri(RestHelper.ApiUrl("items"));

                var response = httpClient.GetStringAsync(uri).Result;

                return JsonConvert.DeserializeObject<ICollection<ItemDTO>>(response);
            }
        }
    }
}