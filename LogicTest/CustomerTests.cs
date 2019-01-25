using AutoMapper;
using CustomerCloud.DTOs;
using CustomerCloud.Entities;
using CustomerCloud.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTest
{
    [TestClass]
    class CustomerTests
    {
        [TestMethod]
        public void Create()
        {
            Mapper.Reset();
            CustomerLogic customerLogic = new CustomerLogic();
            CustomerDTO cust = CreateCustomer();
            customerLogic.Create(cust);
            CustomerDTO result = customerLogic.Read(cust.Id);
            Assert.IsNotNull(result);
            customerLogic.Delete(cust.Id);
        }


        public void Read()
        {
            Mapper.Reset();
            BaseLogic<CustomerEntity, CustomerDTO> customerLogic = new BaseLogic<CustomerEntity, CustomerDTO>();
            CustomerDTO cust = CreateCustomer();
            customerLogic.Create(cust);
            CustomerDTO result = customerLogic.Read(cust.Id);
            Assert.IsNotNull(result);
            Assert.AreEqual(cust.Id, result.Id);
        }

        public void Update()
        {

        }

        public void Delete()
        { }

        private CustomerDTO CreateCustomer()
        {
            throw new NotImplementedException();
        }

    }
}
