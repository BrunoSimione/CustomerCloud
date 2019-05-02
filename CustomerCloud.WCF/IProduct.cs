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
    public interface IProduct
    {
        [OperationContract]
        void Create(ProductDTO product);

        [OperationContract]
        void Delete(Guid Id);

        [OperationContract]
        ProductDTO Read(Guid Id);

        [OperationContract]
        void Update(ProductDTO product);
    }

    
}
