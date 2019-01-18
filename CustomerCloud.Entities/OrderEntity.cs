using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerCloud.Entities
{
    [Table("Orders")]
    public class OrderEntity
    {
        public Guid Id { get; set; }
        public List<OrderDetailEntity> Details { get; set; }
    }
}