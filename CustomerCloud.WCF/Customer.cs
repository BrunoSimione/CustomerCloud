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
    public class Customer : ICustomer
    {
        private BaseLogic<CustomerEntity, CustomerDTO> _logic;

        public Customer()
        {
            _logic = new BaseLogic<CustomerEntity, CustomerDTO>();
        }
        public void Create(CustomerDTO customer)
        {
            _logic.Create(customer);
        }

        public void Delete(Guid Id)
        {
            _logic.Delete(Id);
        }

        public CustomerDTO Read(Guid Id)
        {
            return _logic.Read(Id);
        }

        public void Update(CustomerDTO customer)
        {
            _logic.Update(customer);
        }
    }
}
