using Newtonsoft.Json;

namespace SLU.Api.Test.Data.Entities
{
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