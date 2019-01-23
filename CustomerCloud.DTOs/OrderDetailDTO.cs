using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCloud.DTOs
{
    public class OrderDetailDTO
    {
        public Guid Id { get; set; }
        public ProductDTO Product { get; set; }
    }
}
