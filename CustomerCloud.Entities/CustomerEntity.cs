﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCloud.Entities
{
    [Table("Customers")]
    public class CustomerEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public AddressEntity Address { get; set; }
        public List<OrderEntity> Orders { get; set; }
    }
}