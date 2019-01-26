using Newtonsoft.Json;
using System;

namespace SLU.XamarinTest.Models
{
    [Serializable]
    public class WholesalerEntity
    {
        [JsonProperty("ID")]
        public int Id { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("LogoURL")]
        public string LogoUrl { get; set; }
    }
}