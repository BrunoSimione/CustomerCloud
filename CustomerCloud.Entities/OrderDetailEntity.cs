using System;

namespace CustomerCloud.Entities
{
    public class OrderDetailEntity
    {
        public Guid Id { get; set; }
        public ProductEntity Product { get; set; }
    }
}