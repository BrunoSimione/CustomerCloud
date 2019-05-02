using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CustomerCloud.DTOs;
using CustomerCloud.Entities;
using CustomerCloud.Logic;

namespace CustomerCloud.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class OrderDetail : IOrderDetail
    {
        private BaseLogic<OrderDetailEntity, OrderDetailDTO> _logic;

        public OrderDetail()
        {
            _logic = new BaseLogic<OrderDetailEntity, OrderDetailDTO>();
        }
        public void Create(OrderDetailDTO orderDetail)
        {
            _logic.Create(orderDetail);
        }

        public void Delete(Guid Id)
        {
            _logic.Delete(Id);
        }

        public OrderDetailDTO Read(Guid Id)
        {
            return _logic.Read(Id);
        }

        public void Update(OrderDetailDTO orderDetail)
        {
            _logic.Update(orderDetail);
        }
    }
}
