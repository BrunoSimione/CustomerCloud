using CustomerCloud.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CustomerCloud.WCF
{ 
    [ServiceContract]
    public interface IOrderDetail
    {
        [OperationContract]
        void Create(OrderDetailDTO orderDetail);

        [OperationContract]
        void Delete(Guid Id);

        [OperationContract]
        OrderDetailDTO Read(Guid Id);

        [OperationContract]
        void Update(OrderDetailDTO orderDetail);
    }

    
}
