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
    public interface ICustomer
    {
        [OperationContract]
        void Create(CustomerDTO customer);

        [OperationContract]
        void Delete(Guid Id);

        [OperationContract]
        CustomerDTO Read(Guid Id);

        [OperationContract]
        void Update(CustomerDTO customer);
    }

    
}
