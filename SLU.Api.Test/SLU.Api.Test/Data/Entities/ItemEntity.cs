using System.Collections.Generic;

namespace SLU.Api.Test.Data.Entities
{
    public class ItemEntity : IDataEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ItemNumber { get; set; }
        public string ItemGroup { get; set; }
        public double Price { get; set; }
        public List<int> WholesalerIds { get; set; }
        public string ImageUrl { get; set; }
    }
}