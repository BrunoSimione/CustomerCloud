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
    public class Address : IAddress
    {
        private BaseLogic<AddressEntity, AddressDTO> _logic;

        public Address()
        {
            _logic = new BaseLogic<AddressEntity, AddressDTO>();
        }
        public void Create(AddressDTO address)
        {
            _logic.Create(address);
        }

        public void Delete(Guid Id)
        {
            _logic.Delete(Id);
        }

        public AddressDTO Read(Guid Id)
        {
            return _logic.Read(Id);
        }

        public void Update(AddressDTO address)
        {
            _logic.Update(address);
        }
    }
}
