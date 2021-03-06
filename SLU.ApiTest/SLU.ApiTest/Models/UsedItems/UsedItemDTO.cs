﻿using Newtonsoft.Json;
using System;

namespace SLU.ApiTest.Models.UsedItems
{
    [Serializable]
    public class UsedItemDTO
    {
        [JsonProperty("ID")]
        public int Id { get; set; }

        [JsonProperty("WholesalerID")]
        public int WholesalerId { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Itemnumber")]
        public string ItemNumber { get; set; }

        [JsonProperty("ItemGroup")]
        public string ItemGroup { get; set; }

        [JsonProperty("Price")]
        public double Price { get; set; }

        [JsonProperty("Amount")]
        public double Amount { get; set; }

        [JsonProperty("Date")]
        public DateTime Date { get; set; }
    }
}