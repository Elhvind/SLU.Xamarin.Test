using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace SLU.ApiTest.Models
{
    [Serializable]
    public class ItemDTO
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

        [JsonProperty("Price")]
        [Required]
        public double Price { get; set; }

        [JsonProperty("ImageURL")]
        public string ImageUrl { get; set; }
    }
}