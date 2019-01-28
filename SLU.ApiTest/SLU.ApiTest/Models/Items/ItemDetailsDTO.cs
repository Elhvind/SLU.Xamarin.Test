using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SLU.ApiTest.Models
{
    [Serializable]
    public class ItemDetailsDTO : ItemDTO
    {
        [JsonProperty("ItemGroup")]
        public string ItemGroup { get; set; }
        [JsonProperty("WholesalerIDs")]
        public List<int> WholesalerIds { get; set; }
    }
}