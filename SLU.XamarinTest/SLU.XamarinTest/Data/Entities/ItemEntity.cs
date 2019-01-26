using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SLU.XamarinTest.Data.Entities
{
    [Serializable]
    public class ItemEntity : IDataEntity
    {
        [JsonProperty("ID")]
        public int Id { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Itemnumber")]
        public string ItemNumber { get; set; }

        [JsonProperty("ItemGroup")]
        public string ItemGroup { get; set; }

        [JsonProperty("Price")]
        public double Price { get; set; }

        [JsonProperty("WholesalerIDs")]
        public List<int> WholesalerIds { get; set; }

        [JsonProperty("ImageURL")]
        public string ImageUrl { get; set; }
    }
}