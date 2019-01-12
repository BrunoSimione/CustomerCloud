using System;

namespace CustomerCloud.Entities
{
    public class ProductEntity
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}