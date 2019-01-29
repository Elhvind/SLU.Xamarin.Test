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
            // TODO: Dependency injection
        }

        public ICollection<ItemDTO> GetAll()
        {
            using (var httpClient = new HttpClient())
            {
                //httpClient.DefaultRequestHeaders.Add(RequestConstants.UserAgent, RequestConstants.UserAgentValue);

                var uri = new Uri(RestHelper.ApiUrl("items"));

                var response = httpClient.GetStringAsync(uri).Result;

                var result = JsonConvert.DeserializeObject<ICollection<ItemDTO>>(response);

                return result;
            }
        }
    }
}