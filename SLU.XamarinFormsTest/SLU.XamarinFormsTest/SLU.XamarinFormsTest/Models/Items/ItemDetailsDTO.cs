using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SLU.XamarinFormsTest.Models.Items
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