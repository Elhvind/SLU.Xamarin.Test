using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SLU.ApiTest.Models
{
    [Serializable]
    public class ItemEntity
    {
        [JsonProperty("ID")]
        public int Id { get; set; }

        [JsonProperty("Name")]
        [Required]
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }

        [JsonProperty("Itemnumber")]
        [Required]
        public string ItemNumber { get; set; }

        [JsonProperty("ItemGroup")]
        public string ItemGroup { get; set; }

        [JsonProperty("Price")]
        [Required]
        public double Price { get; set; }

        [JsonProperty("WholesalerIDs")]
        public List<int> WholesalerIds { get; set; }

        [JsonProperty("ImageURL")]
        public string ImageUrl { get; set; }
    }
}