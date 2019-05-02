using System;
using CustomerCloud.Assignment1.UnitTests.OrderDetailServiceReference;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerCloud.Assignment1.UnitTests
{
    [TestClass]
    public class OrderDetailTests
    {
        private OrderDetailDTO _dto;
        [TestInitialize]
        public void Init()
        {
            _dto = new OrderDetailDTO()
            {
                    
                Id = Guid.NewGuid(),
                Product = new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Description = "Shoes",
                    Price = 123.45M
                }
            };
        }
        
        [TestMethod]
        public void OrderDetail_Create_Test()
        {
            OrderDetailClient client = new OrderDetailClient("NetTcpBinding_IOrderDetail");
            client.Open();
            client.Create(_dto);

            OrderDetailDTO result = client.Read(_dto.Id);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void OrderDetail_Update_Test()
        {
            OrderDetailClient client = new OrderDetailClient("NetTcpBinding_IOrderDetail");
            client.Open();
            client.Create(_dto);
            _dto.Id = Guid.NewGuid();
            _dto.Product.Id = Guid.NewGuid();
            _dto.Product.Description = "Pants";
            _dto.Product.Price = 123.45M;

            client.Update(_dto);

            OrderDetailDTO result = client.Read(_dto.Id);
            Assert.IsNotNull(result);
            Assert.AreEqual("Pants", _dto.Product.Description);
            Assert.AreEqual(123.45M, _dto.Product.Price);
        }

        [TestMethod]
        public void OrderDetail_Delete_Test()
        {
            OrderDetailClient client = new OrderDetailClient("NetTcpBinding_IOrderDetail");
            client.Open();

            OrderDetailDTO exists = client.Read(_dto.Id);
            if (exists == null)
            {
                client.Create(_dto);
            }

            client.Delete(_dto.Id);

            OrderDetailDTO result = client.Read(_dto.Id);
            Assert.IsNull(result);
        }

    }
}
