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
    public interface IAddress
    {
        [OperationContract]
        void Create(AddressDTO address);

        [OperationContract]
        void Delete(Guid Id);

        [OperationContract]
        AddressDTO Read(Guid Id);

        [OperationContract]
        void Update(AddressDTO address);
    }

    
}
