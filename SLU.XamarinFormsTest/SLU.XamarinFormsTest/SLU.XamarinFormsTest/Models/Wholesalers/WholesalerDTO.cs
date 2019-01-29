using Newtonsoft.Json;
using System;

namespace SLU.XamarinFormsTest.Models.Wholesalers
{
    [Serializable]
    public class WholesalerDTO
    {
        [JsonProperty("ID")]
        public int Id { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("LogoURL")]
        public string LogoUrl { get; set; }
    }
}