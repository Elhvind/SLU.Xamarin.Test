using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace SLU.ApiTest.DataAccess.Models
{
    [Serializable]
    public class WholesalerDTO
    {
        [JsonProperty("ID")]
        public int Id { get; set; }

        [JsonProperty("Name")]
        [Required]
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }

        [JsonProperty("LogoURL")]
        [Required]
        public string LogoUrl { get; set; }
    }
}