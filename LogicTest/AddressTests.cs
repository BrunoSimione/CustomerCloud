using System;
using CustomerCloud.DTOs;
using CustomerCloud.Entities;
using CustomerCloud.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicTest
{
    [TestClass]
    public class AddressTests
    {
        private AddressLogic _address;

        [TestInitialize]
        public void Init()
        {
            _address = new AddressLogic();
        }

        [TestMethod]
        public void Create()
        {
            Guid id = Guid.NewGuid();
            _address.Create(new AddressDTO()
            {
                Id = id,
                City = Faker.Address.USCity(),
                Street = Faker.Address.StreetName(),
                Number = Faker.Number.RandomNumber(),
                PostalCode = Faker.Address.CanadianZipCode(),
                Province = Faker.Address.Province()
            });

            AddressDTO result = _address.Read(id);
            Assert.IsNotNull(result);
        }
    }
}
