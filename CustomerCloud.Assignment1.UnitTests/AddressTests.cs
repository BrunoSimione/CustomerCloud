using CustomerCloud.Assignment1.UnitTests.AddressServiceReference;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCloud.Assignment1.UnitTests
{
    [TestClass]
    public class AddressTests
    {
        AddressDTO _dto;

        [TestInitialize]
        public void Init()
        {
            _dto = new AddressDTO()
            {
                Id = Guid.NewGuid(),
                City = "Toronto",
                Number = 19,
                PostalCode = "N5A4H7",
                Province = "Ontario",
                Street = "Humber Bvld."
            };
        }
        [TestMethod]
        public void Create_Address()
        {
            AddressServiceReference.AddressClient address = new AddressClient("BasicHttpBinding_IAddress");
            address.Open();
            address.Create(_dto);

            AddressDTO result = address.Read(_dto.Id);
            Assert.IsNotNull(result);
        }
    }
}
