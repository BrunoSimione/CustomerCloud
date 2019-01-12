using System;
using System.Collections.Generic;

namespace CustomerCloud.Entities
{
    public class OrderEntity
    {
        public Guid Id { get; set; }
        public List<OrderDetailEntity> Details { get; set; }
    }
}