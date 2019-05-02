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
    public interface IOrder
    {
        [OperationContract]
        void Create(OrderDTO order);

        [OperationContract]
        void Delete(Guid Id);

        [OperationContract]
        OrderDTO Read(Guid Id);

        [OperationContract]
        void Update(OrderDTO order);
    }

    
}
