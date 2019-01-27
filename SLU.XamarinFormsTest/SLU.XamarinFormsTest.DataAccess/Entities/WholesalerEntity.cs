using Newtonsoft.Json;
using System;

namespace SLU.XamarinFormsTest.DataAccess.Entities
{
    [Serializable]
    public class WholesalerEntity : IDataEntity
    {
        [JsonProperty("ID")]
        public int Id { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("LogoURL")]
        public string LogoUrl { get; set; }
    }
}