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
        private AddressLogic _addressLogic;
        private AddressDTO _addressLogicDTO;

        [TestInitialize]
        public void Init()
        {
            _addressLogic = new AddressLogic();
            _addressLogicDTO = new AddressDTO()
                {
                    Id = Guid.NewGuid(),
                    City = Faker.Address.USCity(),
                    Street = Faker.Address.StreetName(),
                    Number = Faker.Number.RandomNumber(),
                    PostalCode = Faker.Address.CanadianZipCode(),
                    Province = Faker.Address.Province()
                };
        }

        [TestMethod]
        public void Create()
        {
            _addressLogic.Create(_addressLogicDTO);
            AddressDTO result = _addressLogic.Read(_addressLogicDTO.Id);

            Assert.IsNotNull(result);
        }

        public void Update()
        {
            
           // _addressLogic.Update( );
        }

        

    }
}
