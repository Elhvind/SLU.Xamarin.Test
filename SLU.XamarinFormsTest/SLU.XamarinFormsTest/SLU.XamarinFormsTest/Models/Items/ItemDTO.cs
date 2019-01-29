using Newtonsoft.Json;
using System;

namespace SLU.XamarinFormsTest.Models.Items
{
    [Serializable]
    public class ItemDTO
    {
        [JsonProperty("ID")]
        public int Id { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Itemnumber")]
        public string ItemNumber { get; set; }

        [JsonProperty("Price")]
        public double Price { get; set; }

        [JsonProperty("ImageURL")]
        public string ImageUrl { get; set; }
    }
}