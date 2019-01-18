using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerCloud.Entities
{
    [Table("Products")]
    public class ProductEntity
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}